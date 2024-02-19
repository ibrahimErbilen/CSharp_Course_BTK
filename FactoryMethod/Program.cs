
CustomerManager customerManager = new CustomerManager(new LoggerFactory());
customerManager.Save();

CustomerManager customerManager1 = new CustomerManager(new LoggerFactory2());
customerManager1.Save();


public class CustomerManager
{
    private ILoggerFactory _loggerFactory;

    public CustomerManager(ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory;
    }

    public void Save()
    {
        Console.WriteLine("Saved.");
        ILogger logger = _loggerFactory.CreateLogger();
        logger.Log();
    }
}

public class LoggerFactory : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        return new HBLogger();
    }
}
public class LoggerFactory2 : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        return new Log4NetLogger();
    }
}

public interface ILoggerFactory
{
    ILogger CreateLogger();
}

public interface ILogger
{
    void Log();
}

public class HBLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged With HBLogger.");
    }
}
public class Log4NetLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged With Log4NetLogger.");
    }
}
