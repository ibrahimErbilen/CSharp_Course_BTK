
var customerManager = CustomerManager.CreateAsSingleton();

customerManager.Save();

public class CustomerManager
{
    static CustomerManager? _customerManager;
    static object _lockObject = new object();
    private CustomerManager()
    {

    }
    public static CustomerManager CreateAsSingleton()
    {
        lock (_lockObject)
        {
            if (_customerManager == null)
            {
                _customerManager = new CustomerManager();
            }
        }

        return _customerManager;
    }
    public void Save()
    {
        Console.WriteLine($"Customer Saved Successfully");
    }
}
