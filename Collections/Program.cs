using System;
using System.Collections.Generic;
using System.Linq;
// List0();
// List1();

Dictionary<string, dynamic> map = new Dictionary<string, dynamic>();
map.Add("name", "Hasan");
map.Add("age", 22);


Console.WriteLine(map["name"]);
Console.WriteLine(map["age"]);
// Console.WriteLine(map["friend"]); // keyNotFounr Error

foreach (var item in map)
{
    Console.WriteLine("{0} : {1}", item.Key, item.Value);
}

Console.WriteLine(map.ContainsKey("name"));
Console.WriteLine(map.ContainsKey("friend"));
Console.WriteLine(map.ContainsValue("Hasan"));
Console.WriteLine(map.ContainsValue("Ahmet"));

Console.ReadLine();

static void List0()
{
    // string[] cities = new string[2] { "Ankara", "Konya" };
    // this array have 2 values and cant add a 3rd value

    List<string> cities = new List<string> { "Ankara" };
    // this list can use as a array and you can add new items to list.
    cities.Add("Konya");
    cities.Add("İstanbul");
    cities.Add("Adana");
    cities.Add("İzmir");

    List<string> countries = new List<string>();

    countries.Add("Türkiye");
    countries.Add("Russia");
    countries.Add("England");


    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }

    Console.WriteLine();

    foreach (var country in countries)
    {
        Console.WriteLine(country);
    }
}

static void List1()
{
    List<string> list = new List<string>();
    list.Add("listItem1");

    List<Customer> customerList = new List<Customer>();

    customerList.Add(new Customer { id = 1, firstName = "Hasan" });
    customerList.Add(new Customer { id = 2, firstName = "Engin" });

    var customer2 = new Customer { id = 3, firstName = "Ali" };
    customerList.Add(customer2);
    customerList.AddRange(new Customer[2]
    {
    new Customer { id = 4, firstName = "Ahmet" },
    new Customer { id = 5, firstName = "Mustafa" },
    });

    // customerList.Clear(); // removes all elements from list

    var isContains = customerList.Contains(new Customer { id = 1, firstName = "Hasan" });
    Console.WriteLine("isContains : {0}", isContains);   // false because we dont look to values we are looking for reference.
    var isContains2 = customerList.Contains(customer2);
    Console.WriteLine("isContains2 : {0}", isContains2);

    Console.WriteLine("Customer2 in index : {0}", customerList.IndexOf(customer2));
    Console.WriteLine("Customer2 in index reverse search : {0}", customerList.LastIndexOf(customer2));

    customerList.Add(customer2); // reverse search will find this and give index of this
    Console.WriteLine("Customer2 in index : {0}", customerList.IndexOf(customer2));
    Console.WriteLine("Customer2 in index reverse search : {0}", customerList.LastIndexOf(customer2));

    customerList.Insert(0, customer2);  // insert item to given index
    Console.WriteLine("Customer2 in index : {0}", customerList.IndexOf(customer2));
    Console.WriteLine("Customer2 in index reverse search : {0}", customerList.LastIndexOf(customer2));

    customerList.Remove(customer2); // will remove first and exits
    Console.WriteLine("Customer2 in index : {0}", customerList.IndexOf(customer2));
    Console.WriteLine("Customer2 in index reverse search : {0}", customerList.LastIndexOf(customer2));

    customerList.RemoveAll(c => c.firstName == "Ahmet"); // will remove all that have fistname "Ahmet"


    foreach (var customer in customerList)
    {
        Console.WriteLine("id : {0} , name : {1}", customer.id, customer.firstName);
    }
    var count = customerList.Count();
    Console.WriteLine("Count : {0}", count);
}

class Customer
{
    public int id { get; set; }
    public string firstName { get; set; }

}
