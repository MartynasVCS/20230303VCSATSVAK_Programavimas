using System;

namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašykite metodą, kuris pasisveikintų su vartotoju.
             * Vartotojas turi įvesti savo vardą, amžių ir hobio pavadinimą.
             * Visi šie duomenys yra duodami metodui, 
             * kuris visą šią informaciją išveda formatuotai:
             */

            string vardas = VartotojoIvedimas("Įrašykite savo vardą");
            int amzius = Convert.ToInt32(VartotojoIvedimas("Įrašykite savo amžių"));
            string hobis = VartotojoIvedimas("Įrašykite savo hobį");

            PasisveikinimasSuVartotoju(vardas, amzius, hobis);
        }

        private static string VartotojoIvedimas(string zinute)
        {
            Console.Write($"{zinute}: ");
            return Console.ReadLine();
        }

        private static void PasisveikinimasSuVartotoju(string vardas, int amzius, string hobis)
        {
            Console.WriteLine();
            Console.WriteLine($"Labas, tavo vardas {vardas}, tau {amzius} metų.");
            Console.WriteLine($"Tavo mylimiausias hobis yra {hobis}.");
            Console.WriteLine();
        }
    }
}
