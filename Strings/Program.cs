using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Hasan Basri";

            var result = sentence.Length;
            var result2 = sentence.Clone();

            sentence = "My name is Ahmet";
            Console.WriteLine(sentence);
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("t");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("is");
            Console.WriteLine(result5);
            var result6 = sentence.IndexOf("Ali");
            Console.WriteLine(result6); // bulamazsa -1 

            var result7 = sentence.IndexOf(" ");
            Console.WriteLine(result7);

            var result8 = sentence.LastIndexOf(" ");
            Console.WriteLine(result8);

            var result9 = sentence.Insert(0, "Hello");
            Console.WriteLine(result9);

            var result10 = sentence.Substring(3);
            Console.WriteLine(result10);
            var result11 = sentence.Substring(3, 4);
            Console.WriteLine(result11);

            var result12 = sentence.ToLower();
            Console.WriteLine(result12);

            var result13 = sentence.ToUpper();
            Console.WriteLine(result13);

            var result14 = sentence.Replace(" ", "-");
            Console.WriteLine(result14);

            var result15 = sentence.Remove(2);
            Console.WriteLine(result15);

            var result16 = sentence.Remove(2, 5);
            Console.WriteLine(result16);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara"; // string is a char array
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
            Console.WriteLine("{0} {1}", city, city2);
        }
    }
}
