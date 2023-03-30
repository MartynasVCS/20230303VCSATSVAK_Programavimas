using System;

namespace DemoIvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Įveskite savo vardą: ");
            string ivedimas = Console.ReadLine();
            Console.WriteLine($"Tavo vardas: {ivedimas}");

            Console.Write("Įveskite savo amžių: ");
            Console.WriteLine(Console.ReadLine());

            Console.Write("Įveskite savo ūgį: ");
            double ugis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ugis);

            // Simbolio įvedimas
            Console.Write("Įveskite pirmą simbolį: ");
            int simbolisAscii = Console.Read();
            char simbolis = Convert.ToChar(simbolisAscii);
            Console.WriteLine(simbolis);
            Console.ReadLine();

            // Console.Read keistumai.
            Console.WriteLine("Įveskite du simbolius ir paanalizuokite gautą rezultatą.");
            Console.WriteLine(Console.Read());
            Console.WriteLine(Console.Read());
            Console.WriteLine(Console.Read());
            Console.WriteLine(Console.Read());
            Console.WriteLine(Console.Read());
        }
    }
}
