using System;
using System.Data;

int number1 = 10;
int number2 = 20;

number2 = number1;
number1 = 30;       // this is value type

Console.WriteLine("Number1 : {0}", number1);
Console.WriteLine("Number2 : " + number2.ToString());


string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
string[] cities2 = new string[] { "Bursa", "Balıkersir", "Bolu" };

cities2 = cities1;  // this is reference type
cities1[0] = "İstanbul"; // changes can visible in both arrays

foreach (var city in cities1)
{
    Console.WriteLine(city);
}
foreach (var city in cities2)
{
    Console.WriteLine(city);
}

DataTable dataTable;//  = new DataTable(); // tihs requires mode space on ram
DataTable dataTable2 = new DataTable();
dataTable = dataTable2;

Console.ReadLine();
