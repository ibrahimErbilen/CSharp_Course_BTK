Customer customer = new Customer() { Id = 1, LastName = "Ayhaner", Age = 23 };

CustomerDal customerDal = new CustomerDal();

customerDal.Add(customer);

customerDal.AddNew(customer);

[ToTable("Customers")]
[ToTable("TblCustomers")]
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string FirstName { get; set; }
    [RequiredProperty]
    public string LastName { get; set; }
    [RequiredProperty]
    public int Age { get; set; }
}

class CustomerDal
{
    [Obsolete("Don't use Add, instead use AddNew method.")]
    public void Add(Customer customer)
    {
        Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added!");
    }

    public void AddNew(Customer customer)
    {
        Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.LastName}, {customer.Age} added!");
    }
}

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]      // valid on all types
class RequiredPropertyAttribute : Attribute
{

}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]    // valid on Classes
class ToTableAttribute : Attribute
{
    private string _tableName;

    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}
