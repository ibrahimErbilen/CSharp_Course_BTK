


CreditManager manager = new CreditManager();


Console.WriteLine($"{manager.Calculate()}");
Console.WriteLine($"{manager.Calculate()}");

Console.WriteLine($"CreditManagers Completed");

CreditManagerProxy managerProxy = new CreditManagerProxy();

Console.WriteLine($"{managerProxy.Calculate()}");
Console.WriteLine($"{managerProxy.Calculate()}");

Console.WriteLine($"CreditManagerProxies Completed");


abstract class CreditBase
{
    public abstract int Calculate();
}

class CreditManager : CreditBase
{
    public override int Calculate()
    {
        int result = 1;
        for (int i = 1; i <= 5; i++)
        {
            result *= i;
            Thread.Sleep(1000);
        }

        return result;
    }
}

class CreditManagerProxy : CreditBase
{
    private CreditManager _creditManager;
    private int _cachedValue;

    public override int Calculate()
    {
        if (_creditManager is null)
        {
            _creditManager = new CreditManager();
            _cachedValue = _creditManager.Calculate();
        }

        return _cachedValue;
    }
}
