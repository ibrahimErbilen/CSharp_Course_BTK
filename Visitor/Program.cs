#region main

Manager manager = new Manager("Hasan", 14000);
Manager manager1 = new Manager("Ali", 13800);

Worker worker = new Worker("Ahmet", 9100);
Worker worker1 = new Worker("Enes", 9150);

manager.Subordinates.Add(manager1);

manager1.Subordinates.Add(worker);
manager1.Subordinates.Add(worker1);

OrganizationalStructure organizationalStructure = new OrganizationalStructure(manager);

PayrollVisitor payrollVisitor = new PayrollVisitor();
PayRiseVisitor payRiseVisitor = new PayRiseVisitor();

organizationalStructure.Accept(payrollVisitor);
organizationalStructure.Accept(payRiseVisitor);

#endregion


class OrganizationalStructure
{
    public EmployeeBase Employee;

    public OrganizationalStructure(EmployeeBase firstEmployee)
    {
        Employee = firstEmployee;
    }

    public void Accept(VisitorBase visitor)
    {
        Employee.Accept(visitor);
    }
}

abstract class EmployeeBase
{
    public abstract void Accept(VisitorBase visitor);
    public string? Name { get; set; }
    public decimal Salary { get; set; }
}

class Manager : EmployeeBase
{
    public Manager(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
        Subordinates = new List<EmployeeBase>();
    }

    public List<EmployeeBase> Subordinates { get; set; }
    public override void Accept(VisitorBase visitor)
    {
        visitor.Visit(this);

        foreach (var employee in Subordinates)
        {
            employee.Accept(visitor);
        }
    }
}

class Worker : EmployeeBase
{
    public Worker(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public override void Accept(VisitorBase visitor)
    {
        visitor.Visit(this);
    }
}

abstract class VisitorBase
{
    public abstract void Visit(Manager manager);
    public abstract void Visit(Worker worker);
}

class PayrollVisitor : VisitorBase
{
    public override void Visit(Manager manager)
    {
        // Business logic here
        Console.WriteLine($"{manager.Name} paid {manager.Salary}");
    }

    public override void Visit(Worker worker)
    {
        // Business logic here
        Console.WriteLine($"{worker.Name} paid {worker.Salary}");
    }
}

class PayRiseVisitor : VisitorBase
{
    public override void Visit(Manager manager)
    {
        // Business logic here
        Console.WriteLine($"{manager.Name} salary increased to {manager.Salary * (decimal)1.2}");
    }

    public override void Visit(Worker worker)
    {
        // Business logic here
        Console.WriteLine($"{worker.Name} salary increased to {worker.Salary * (decimal)1.1}");
    }
}
