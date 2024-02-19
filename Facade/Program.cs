

CustomerManager customerManager = new CustomerManager();

customerManager.Save();


class Logging : ILogging
{
    public void Log()
    {
        Console.WriteLine($"Logged");
    }
}

interface ILogging
{
    void Log();
}

class Caching : ICaching
{
    public void Cache()
    {
        Console.WriteLine($"Cached");
    }
}

interface ICaching
{
    void Cache();
}

class Authorize : IAuthorize
{
    public void CheckUser()
    {
        Console.WriteLine($"User Checked");
    }
}

interface IAuthorize
{
    void CheckUser();
}

class Validation : IValidate
{
    public void ValidateUser()
    {
        Console.WriteLine($"User Validated");
    }
}

interface IValidate
{
    void ValidateUser();
}

class CustomerManager
{
    CrossCuttingConcernsFacade _concerns;

    public CustomerManager()
    {
        _concerns = new CrossCuttingConcernsFacade();
    }

    public void Save()
    {
        _concerns.Logging.Log();
        _concerns.Caching.Cache();
        _concerns.Authorize.CheckUser();
        _concerns.Validation.ValidateUser();
        Console.WriteLine($"Saved");
    }
}


class CrossCuttingConcernsFacade
{
    public ILogging Logging;
    public ICaching Caching;
    public IAuthorize Authorize;
    public IValidate Validation;

    public CrossCuttingConcernsFacade()
    {
        Logging = new Logging();
        Caching = new Caching();
        Authorize = new Authorize();
        Validation = new Validation();
    }
}
