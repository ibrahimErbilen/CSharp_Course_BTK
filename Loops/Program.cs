using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();

            // WhileLoop();

            // DoWhileLoop();

            // ForeachLoop();

            if (isPrimeNumber(11))
            {
                Console.WriteLine("This is prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }

            Console.ReadLine();
        }

        private static bool isPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static void ForeachLoop()
        {
            string[] students = { "Engin", "Hasan", "Ali" };

            foreach (var student in students)
            {
                // student = "Ahmet";  // foreach içinde tanımlanan değişkene müdahale edemezsin.
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int sayi = 10;
            do
            {
                Console.WriteLine(sayi);
                sayi--;
            } while (sayi >= 0);
        }

        private static void WhileLoop()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;                // Unutursan sonsuz döngüye girer.
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            Console.WriteLine();

            for (int i = 0; i < 100; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            Console.WriteLine();

            for (int i = 100; i > 0; i -= 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
