using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                default:
                    Console.WriteLine("Bu sayı için işlem yok");
                    break;
            }

            Console.ReadLine();



            //var number = -1;

            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0 - 100.");
            //}
            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101 - 200.");
            //}
            //else if (number > 200 || number < 0)
            //{
            //    Console.WriteLine("Number is not between 0 - 200.");
            //}




            //var number = 92;
            //if(number < 100)
            //{
            //    if (number >= 90 && number < 95)
            //    {
            //        Console.WriteLine("Number is between 90 - 95.");
            //    }
            //}

        }
    }
}
