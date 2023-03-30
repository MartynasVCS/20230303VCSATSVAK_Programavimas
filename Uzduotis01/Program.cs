using System;

namespace Uzduotis01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1 punktas
            string name = "Martynas";
            Console.WriteLine("Labas " + name);
            Console.WriteLine();

            // 2 punktas
            int age = 34;
            Console.WriteLine("Ivestas amzius: " + age);
            Console.WriteLine();

            // 3 punktas
            int number = 25;
            // Pirmas budas
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);

            // Antras budas
            Console.WriteLine("{0}{1}{2}{3}{4}", number, number, number, number, number);

            // Trecias budas
            Console.WriteLine("{0}{0}{0}{0}{0}", number);
            Console.WriteLine();

            // Ketvirtas būdas
            Console.WriteLine($"{number}{number}{number}{number}{number}");
            Console.WriteLine();

            // 4 punktas
            Console.WriteLine("{0} {0} {0} {0} {0}", number);

            // Kitas būdas
            Console.WriteLine($"{number} {number} {number} {number} {number}");
            Console.WriteLine();
        }
    }
}
