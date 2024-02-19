using System.Collections;


Employee hasan = new Employee() { Name = "Hasan" };

Employee ali = new Employee() { Name = "Ali" };

hasan.AddSubordinate(ali);

Employee mehmet = new Employee() { Name = "Mehmet" };

Contractor rifki = new Contractor() { Name = "Rıfkı" };

mehmet.AddSubordinate(rifki);

hasan.AddSubordinate(mehmet);

Employee ahmet = new Employee() { Name = "Ahmet" };

ali.AddSubordinate(ahmet);

Console.WriteLine($"{hasan.Name}");
foreach (Employee manager in hasan)
{
    Console.WriteLine($"\t{manager.Name}");

    foreach (IPerson employee in manager)
    {
        Console.WriteLine($"\t\t{employee.Name}");
    }
}

interface IPerson
{
    string Name { get; set; }
}


class Contractor : IPerson
{
    public string Name { get; set; }
}

class Employee : IPerson, IEnumerable<IPerson>
{
    List<IPerson> _subordinates = new List<IPerson>();

    public void AddSubordinate(IPerson person)
    {
        _subordinates.Add(person);
    }

    public void RemoveSubordinate(IPerson person)
    {
        _subordinates.Remove(person);
    }

    public IPerson GetSubordinate(int index)
    {
        return _subordinates[index];
    }

    public string Name { get; set; }

    public IEnumerator<IPerson> GetEnumerator()
    {
        foreach (var subordinate in _subordinates)
        {
            yield return subordinate;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _subordinates.GetEnumerator();
    }
}
