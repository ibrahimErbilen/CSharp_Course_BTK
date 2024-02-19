Customer customer1 = new Customer()
{
    Id = 1,
    FirstName = "Hasan Basri",
    LastName = "Ayhaner",
    City = "Konya"
};

//* customer2 is completely different object, not reference of customer1
Customer customer2 = (Customer)customer1.Clone();   // if not casted default is Person type
customer2.FirstName = "Veli";

Console.WriteLine($"{customer1.FirstName}");
Console.WriteLine($"{customer2.FirstName}");

public abstract class Person
{
    public abstract Person Clone();

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Customer : Person
{
    public string City { get; set; }

    public override Person Clone()
    {
        return (Person)MemberwiseClone();
    }
}
