using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveikas pasauli!");
            Console.WriteLine();

            // Kintamųjų išvedimas
            int amzius = 25;
            float ugis = 2.15f;
            Console.WriteLine("amzius");
            Console.WriteLine(amzius);
            Console.WriteLine();

            Console.WriteLine("Labas " + "vakaras");
            Console.WriteLine("Mano amžius: " + amzius + ", o mano ūgis: " + ugis);
            Console.WriteLine("Mano amžius: {0}, o mano ūgis: {1}", amzius, ugis);
            Console.WriteLine($"Mano amžius: {amzius}, o mano ūgis: {ugis}");

            Console.Write("Labas");
            Console.WriteLine("Labas");
            Console.Write("Labas");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
