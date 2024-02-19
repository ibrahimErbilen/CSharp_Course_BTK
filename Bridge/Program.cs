
CustomerManager customerManager = new CustomerManager();

customerManager.MessageSenderBase = new EMailSender();

customerManager.UpdateCustomer();



abstract class MessageSenderBase
{
    public void Save()
    {
        Console.WriteLine($"Message Saved");
    }

    public abstract void Send(Body body);
}

class Body
{
    public string Title { get; set; }
    public string Text { get; set; }
}

class SmsSender : MessageSenderBase
{
    public override void Send(Body body)
    {
        Console.WriteLine($"{body.Title} was sent via SmsSender");
    }
}

class EMailSender : MessageSenderBase
{
    public override void Send(Body body)
    {
        Console.WriteLine($"{body.Title} was sent via EMailSender");
    }
}



class CustomerManager
{
    public MessageSenderBase MessageSenderBase { get; set; }
    public void UpdateCustomer()
    {
        MessageSenderBase.Send(new() { Title = "About Profile Update" });
        Console.WriteLine($"Customer Updated");
    }
}
