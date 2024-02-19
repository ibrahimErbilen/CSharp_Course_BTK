
CustomerManager customerManager = new CustomerManager();

// customerManager.SendMessage();
// customerManager.ShowAlert();

MyDelegate myDelegate = customerManager.SendMessage;

myDelegate();

// myDelegate.Invoke();
myDelegate += customerManager.ShowAlert;
Console.WriteLine($"");
myDelegate();

myDelegate -= customerManager.SendMessage;

Console.WriteLine($"");

myDelegate();

Console.WriteLine($"");

MyDelegate2 myDelegate2 = customerManager.SendMessage2;

myDelegate2 += customerManager.ShowAlert2;

myDelegate2("Hello");

Maths maths = new Maths();
MyDelegate3 myDelegate3 = maths.Sum;

int result = myDelegate3(2, 3);
Console.WriteLine($"Result: {result}");

Console.WriteLine($"");
myDelegate3 += maths.Multiply;

var result2 = myDelegate3(2, 3);
Console.WriteLine($"Result: {result2}");

public delegate void MyDelegate();
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);

public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine($"Hello Customer");
    }

    public void ShowAlert()
    {
        Console.WriteLine($"Be careful!");
    }

    public void SendMessage2(string message)
    {
        Console.WriteLine($"{message}");
    }

    public void ShowAlert2(string alert)
    {
        Console.WriteLine($"{alert}!");
    }
}

public class Maths
{
    public int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
}
