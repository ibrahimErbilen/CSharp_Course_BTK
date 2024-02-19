using System;

Student student = new Student();
student.Save2();
Console.ReadLine();


class Customer
{
    private int Id { get; set; }
    protected int number { get; set; }
    // private variables can used in just this class
    // protected variables can used when inheritence
    // 
    public void Save()
    {
    }
}

class Student : Customer
{
    public void Save2()
    {
        number++;
        Console.WriteLine(number);
    }
}

public class Course // internal is default
{
    public void Create()
    {
        Console.WriteLine("Created");
    }
    // public string Name { get; set; }
    private class Nested // Private class can define in another class
    {                    // error when try to define in namespace

    }
}
