using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer{ FirstName = "Hasan" },
                new Student{ FirstName = "Ali" },
                new Person{ FirstName = "Ahmet" }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }

    class Customer : Person // Sadece 1 yerden inheritence alınabilir
    {
        public String City { get; set; }
    }

    class Student : Person
    {
        public String Department { get; set; }
    }
}
