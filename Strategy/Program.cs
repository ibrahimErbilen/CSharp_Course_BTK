CustomerManager customerManager = new CustomerManager();

customerManager.CreditCalculatorBase = new After2010CreditCalculator();
customerManager.SaveCredit();

customerManager.CreditCalculatorBase = new Before2010CreditCalculator();
customerManager.SaveCredit();


abstract class CreditCalculatorBase
{
    public abstract void Calculate();
}


class Before2010CreditCalculator : CreditCalculatorBase
{
    public override void Calculate()
    {
        Console.WriteLine($"Credit Calculated Using Before2010");
    }
}

class After2010CreditCalculator : CreditCalculatorBase
{
    public override void Calculate()
    {
        Console.WriteLine($"Credit Calculated Using After2010");
    }
}


class CustomerManager
{
    public CreditCalculatorBase CreditCalculatorBase { get; set; }
    public void SaveCredit()
    {
        Console.WriteLine($"Customer Manager Business");
        CreditCalculatorBase.Calculate();
    }
}
