#region main

President president = new President();

VicePresident vicePresident = new VicePresident();
vicePresident.SetSuccessor(president);

Manager manager = new Manager();
manager.SetSuccessor(vicePresident);

Expense expense1 = new()
{
    Detail = "Expense1",
    Amount = 99
};

Expense expense2 = new()
{
    Detail = "Expense2",
    Amount = 159
};

Expense expense3 = new()
{
    Detail = "Expense3",
    Amount = 1999
};

manager.HandleExpense(expense1);
manager.HandleExpense(expense2);    // manager calls vicePresident because of limit of Expense Amount
manager.HandleExpense(expense3);    // manager calls vicePresident, then vicePresident 
                                    // calls president because of limit of Expense Amount

#endregion



class Expense
{
    public string? Detail { get; set; }
    public decimal Amount { get; set; }
}

abstract class ExpenseHandlerBase
{
    protected ExpenseHandlerBase? Successor;
    public abstract void HandleExpense(Expense expense);
    public void SetSuccessor(ExpenseHandlerBase successor)
    {
        Successor = successor;
    }
}

class Manager : ExpenseHandlerBase
{
    public override void HandleExpense(Expense expense)
    {
        if (expense.Amount <= 100)
        {
            Console.WriteLine($"Manager handled the expense. Expense Detail: {expense.Detail}");
        }
        else if (Successor != null)
        {
            Successor.HandleExpense(expense);
        }
    }
}

class VicePresident : ExpenseHandlerBase
{
    public override void HandleExpense(Expense expense)
    {
        if (expense.Amount > 100 && expense.Amount <= 1000)
        {
            Console.WriteLine($"VicePresident handled the expense. Expense Detail: {expense.Detail}");
        }
        else if (Successor != null)
        {
            Successor.HandleExpense(expense);
        }
    }
}

class President : ExpenseHandlerBase
{
    public override void HandleExpense(Expense expense)
    {
        if (expense.Amount > 1000)
        {
            Console.WriteLine($"President handled the expense. Expense Detail: {expense.Detail}");
        }
        else if (Successor != null)
        {
            Successor.HandleExpense(expense);
        }
    }
}
