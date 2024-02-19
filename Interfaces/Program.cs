using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            // Rule1();

            // InterfaceDemo();

            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void InterfaceDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void Rule1()
        {
            // IPerson person = new IPerson(); // Oluşturulamaz
            IPerson person = new Customer();
            IPerson person1 = new Student();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();

            manager.Add(new Customer
            {
                Id = 1,
                FirstName = "Hasan Basri",
                LastName = "Ayhaner",
                Address = "Istanbul",
            });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Coşkun",
                Departmant = "IIBF",
            };

            manager.Add(student);
        }
    }

    interface IPerson       // Soyut nesne
    {
        int Id { get; set; }    // burada erişim belirteci kullanılmaz public vs.
        String FirstName { get; set; }
        String LastName { get; set; }

    }

    class Customer : IPerson          // Somut nesne
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Address { get; set; }

    }

    class Student : IPerson           // Somut nesne
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public String Departmant { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)     // sadece IPerson özelliklerine erişilebilir.
        {
            Console.WriteLine("{0} {1} Eklendi", person.FirstName, person.LastName);
        }
    }
}
