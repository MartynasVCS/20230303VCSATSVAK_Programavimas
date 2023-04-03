using System;

namespace Uzduotis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite reikiamus kintamuosius užduočiai atlikti. 
             * Į ekraną išveskite: 
             * Automobilio {markė} {modelis} ({metai} m.) rida - {rida} km.
             * Tarp {} nurodyti reikiami kintamieji, 
             * šiose vietose jų reikšmės turi būti įstatytos.
             */

            string marke = "Toyota";
            string modelis = "Corolla";
            int metai = 1997;
            int rida = 449567;

            Console.Write($"Automobilio {marke} {modelis}");
            Console.Write($"({metai} m.) rida - ");
            Console.WriteLine($"{rida} km.");
        }
    }
}
