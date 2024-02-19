using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Engin";
            string student2 = "Hasan";
            string student3 = "Ali";

            string[] students = { "Engin", "Hasan", "Ali" }; // 3 elmandan fazla eleman saklamaz.

            string[] students2 = new string[3];     // 3 elmandan fazla eleman saklamaz.
            students2[0] = "Engin";
            students2[1] = "Hasan";
            students2[2] = "Ali";

            Console.WriteLine(students[1]);
            Console.WriteLine(students2[1]);
            Console.WriteLine();

            Console.WriteLine("Students : ");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();


            // Çok boyutlu dizi
            string[,] bolgeSehir = new string[5, 3]
            {
                { "İstanbul" ,"İzmit" ,"Balıkesir" },
                { "Ankara","Konya","Kırıkkale" },
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"},
            }; // 5 bölge için 3 büyük şehir

            for (int i = 0; i <= bolgeSehir.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeSehir.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeSehir[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
