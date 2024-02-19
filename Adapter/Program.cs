

ProductManager productManager = new ProductManager(new HBALogger());
//* we want to use Log4Net package but Log4Net is not type of ILogger we used in our project (maybe in 50 methods),
//* so we create an Adapter class and implemented ILogger, adapted Log4Net methods in our ILogger method bodies.
ProductManager productManager2 = new ProductManager(new Log4NetAdapter());

productManager.Save();
Console.WriteLine($"");
productManager2.Save();


class ProductManager
{
    private ILogger _logger;

    public ProductManager(ILogger logger)
    {
        _logger = logger;
    }

    public void Save()
    {
        _logger.Log("User Data");
        Console.WriteLine($"Saved");
    }
}

interface ILogger
{
    void Log(string message);
}

class HBALogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logged: {message}");
    }
}

//! Nuget package, cant modify
class Log4Net
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logged with Log4Net: {message}");
    }
}

//* Solution: Adaptation of Log4Net with ILogger
class Log4NetAdapter : ILogger
{
    private Log4Net _log4Net;

    public Log4NetAdapter()
    {
        _log4Net = new Log4Net();
    }

    public void Log(string message)
    {
        _log4Net.LogMessage(message);
    }
}
