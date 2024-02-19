// See https://aka.ms/new-console-template for more information

var utilities = new Utilities();

List<string> result = utilities.BuildList<string>("Ankara", "Konya", "Antalya");

foreach (var item in result)
{
    Console.WriteLine($"{item}");
}

var result2 = utilities.BuildList<Customer>(new Customer("Hasan"), new Customer("Mustafa"), new Customer("Ahmet"));

foreach (var customer in result2)
{
    Console.WriteLine($"{customer.FirstName}");
}

class Utilities
{
    public List<T> BuildList<T>(params T[] items)
    {
        return new List<T>(items);
    }
}

public interface IEntity
{

}

public class Product : IEntity
{

}

public class Student : IEntity
{

}

public class Customer : IEntity
{
    public string? FirstName { get; set; }


    public Customer(string firstName)
    {
        FirstName = firstName;
    }

    public Customer()
    {
    }
}

//! class: reference type, struct: value type
public interface IRepository<T> where T : class, IEntity, new()
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}


public interface StudentDal : IRepository<Student>
{

}

public interface IProductDal : IRepository<Product>
{

}

public interface ICustomerDal : IRepository<Customer>
{
    void GetPopularCustomer();
}

public class ProductDal : IProductDal
{
    public void Add(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }
}


public class CustomerDal : ICustomerDal
{
    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public void GetPopularCustomer()
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }
}

// interface IProductDal
// {
//     List<Product> GetAll();
//     Product Get(int id);
//     void Add(Product product);
//     void Delete(Product product);
//     void Update(Product product);
// }

// interface ICustomerDal
// {
//     List<Customer> GetAll();
//     Customer Get(int id);
//     void Add(Customer customer);
//     void Delete(Customer customer);
//     void Update(Customer customer);
// }
