using System;
using System.Linq;

namespace ConsoleApplication_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Add();
            var x = Sum0(15, 12);
            Console.WriteLine(x);
            var y = Sum2(15);
            Console.WriteLine(y);
            var z = Sum2(15, 50);
            Console.WriteLine(z);
            Console.WriteLine();

            int number1 = 10;
            int number2 = 108;
            var result = Sum3(number1, number2);
            Console.WriteLine("Result : " + result);
            Console.WriteLine(number1);
            Console.WriteLine();

            int num1 = 10;
            int num2 = 20;  // ref anahtarı kullanılarak ana değişken de değiştirilebilir.
            var result1 = Sum4(ref num1, num2);
            Console.WriteLine(result1);
            Console.WriteLine(num1);

            int numb1;          // out için değişkene atama yapmak mecburi değildir.
            int numb2 = 20;     // out anahtarı kullanılarak ana değişken de değiştirilebilir.
            var result2 = Sum5(out numb1, numb2);
            Console.WriteLine(result1);
            Console.WriteLine(num1);
            Console.WriteLine();

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 2));
            Console.WriteLine();

            Console.WriteLine(Add2(1, 2, 3, 4));
            Console.WriteLine(Add3(1, 2, 3, 4));

            Console.ReadLine(); // Input Wait
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Sum0(int x, int y)
        {
            Console.WriteLine(x + " + " + y + " = " + (x + y));
            return x + y;
        }

        static int Sum2(int x, int y = 100)
        {
            return x + y;
        }

        //static int Sum3(int x = 10, int y)  // Defaultu verilen değer sağda olmak zorundadır!
        //{
        //    return x + y;
        //}

        static int Sum3(int num1, int num2)
        {
            num1 = 30;  // Global number1 not changes !
            return num1 + num2;
        }

        static int Sum4(ref int number1, int number2)   // ref anahtarı kullanılarak ana değişken de değiştirilebilir.
        {
            number1 = 2000;
            return number1 + number2;
        }
        static int Sum5(out int number1, int number2)   // out anahtarı kullanılarak ana değişken de değiştirilebilir.
        {
            number1 = 2000;     // Method içinde set edilmesi zorunlu mu ? Araştır !
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)      // Aynı method ismi ile override edildi
        {                   // Burada 3 parametre gelirse bu; 2 parametre gelirse üstteki çalışır!
            return number1 * number2 * number3;
        }

        static int Add2(params int[] numbers)
        {
            return numbers.Sum();
        }
        static int Add3(int number1, params int[] numbers)
        {
            return numbers.Sum();
        }

        //static int Add4(int number1, params int[] numbers, int number2) // Params 'in sonda olması gerekir.
        //{
        //    return numbers.Sum();
        //}
    }
}
