using System;

namespace Uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Įveskite pirmo trikampio statinio ilgį: ");
            double statinis1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Įveskite antro trikampio statinio ilgį: ");
            double statinis2 = Convert.ToDouble(Console.ReadLine());

            double izambine = Math.Sqrt(Math.Pow(statinis1, 2) + Math.Pow(statinis2, 2));
            Console.WriteLine($"Trikampio įžambinės ilgis: '{izambine}'");
        }
    }
}
