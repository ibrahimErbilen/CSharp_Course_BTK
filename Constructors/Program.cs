using System;

CustomerManager customerManager = new CustomerManager(10);
//customerManager.Add();
customerManager.List();

CustomerManager customerManager2 = new CustomerManager();
//customerManager2.Add();
customerManager2.List();

Product product = new Product { Id = 1, Name = "Laptop" };

EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
employeeManager.Add();

PersonManager personManager = new PersonManager("Product");
personManager.Add();

// Teacher teacher = new Teacher(); // can not create an instance of static class
Teacher.number = 10; // Everybody can access this because this is on ram
// statics are assign once use everywhere

Utilities.Validate("hba");

Manager.DoSomething(); // static can use without creating object
Manager manager = new Manager();
manager.DoSomething2();// non-static can used with object

Console.ReadLine();
class CustomerManager
{
    int _count = 15;
    public CustomerManager(int count)
    {
        _count = count; // Constructor creates new objects with specifications
    }

    public CustomerManager() { } // empty Constuctor creates objects as defalut
    public void List()
    {
        Console.WriteLine("Listed {0} items.", _count);
    }
    public void Add()
    {
        Console.WriteLine("Added");
    }
}

class Product
{
    public Product()
    {

    }
    int _id;
    string _name;
    public Product(int id, string name)
    {
        _id = id;
        _name = name;
    }
    public int Id { get; set; }
    public string Name { get; set; }
}

interface ILogger
{
    void Log();
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file");
    }
}

class EmployeeManager
{
    private ILogger _logger;
    public EmployeeManager(ILogger Logger)
    {
        _logger = Logger;
    }
    public void Add()
    {
        _logger.Log();
        Console.WriteLine("Added");
    }
}

class BaseClass
{
    private string _entity;
    public BaseClass(string entity)
    {
        _entity = entity;
    }
    public void Message()
    {
        Console.WriteLine("message : {0}", _entity);
    }
}

class PersonManager : BaseClass
{
    public PersonManager(string entity) : base(entity)
    {

    }
    public void Add()
    {
        Console.WriteLine("Added to database");
        Message();
    }
}

static class Teacher
{
    public static int number { get; set; }  // have to be static because of class
}

static class Utilities
{
    public static void Validate(string user)
    {
        Console.WriteLine("Validation is Done fore user : {0}", user);
    }
}

class Manager
{
    public static void DoSomething()
    {
        Console.WriteLine("Done");
    }

    public void DoSomething2()
    {
        Console.WriteLine("Done2");
    }
}
