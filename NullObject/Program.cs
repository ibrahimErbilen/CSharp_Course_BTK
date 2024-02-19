#region main

CustomerManager customerManager = new CustomerManager(new NLogLogger());
customerManager.Save();

CustomerManagerTest customerManagerTest = new CustomerManagerTest();
customerManagerTest.SaveTest();

#endregion


public class CustomerManager
{
    private ILogger _logger;

    public CustomerManager(ILogger logger)
    {
        _logger = logger;
    }

    public void Save()
    {
        Console.WriteLine($"Saved");
        _logger.Log();
    }
}

public interface ILogger
{
    void Log();
}

class Log4NetLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine($"Logged with Log4Net");
    }
}

class NLogLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine($"Logged with NLog");
    }
}

class StubLogger : ILogger
{
    private static StubLogger? _stubLogger;
    private static object _lock = new object();

    private StubLogger() { }

    public static StubLogger GetLogger()
    {
        lock (_lock)
        {
            if (_stubLogger == null)
            {
                _stubLogger = new StubLogger();
            }
        }

        return _stubLogger;
    }
    public void Log()
    {
    }
}

class CustomerManagerTest
{
    public void SaveTest()
    {
        Console.WriteLine("Save Test Started");
        CustomerManager customerManager = new CustomerManager(StubLogger.GetLogger());
        customerManager.Save();
        Console.WriteLine("Save Test Passed");
    }
}
