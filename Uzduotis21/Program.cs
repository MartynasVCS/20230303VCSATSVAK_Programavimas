using System;
using System.Linq;

namespace Uzduotis21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurti 2 masyvus su duomenimis, 
             * išbandant abu kūrimo būdus 
             *      iškart su  duomenimis
             *      pirma nusirodant dydį ir tada priskiriant reikšmes.
             *  Pasibandymui išsivesti norimus duomenis iš visų šių masyvų:
             *      skirtą studentų pažymiams saugoti;
             *      skirtą mašinų markėms saugoti.
             */

            int[] pazymiai = { 7, 6, 10, 9, 5, 8, 8, 9, 10 };

            string[] markes = new string[5];
            markes[0] = "Audi";
            markes[1] = "VW";
            markes[2] = "BMW";
            markes[3] = "Škoda";
            markes[4] = "Volvo";

            // Kelios masyvų reikšmės
            Console.WriteLine(markes[2]);
            Console.WriteLine(markes[3]);
            Console.WriteLine();

            Console.WriteLine(pazymiai[0]);
            Console.WriteLine(pazymiai[1]);
            Console.WriteLine(pazymiai[2]);
            Console.WriteLine();

            // Masyvų ilgiai (elementų kiekis masyve)
            Console.WriteLine(pazymiai.Length);
            Console.WriteLine(markes.Length);
            Console.WriteLine();

            // Masyvų pirmi elementai dviem būdais
            Console.WriteLine(pazymiai.First());
            Console.WriteLine(pazymiai[0]);
            Console.WriteLine(markes.First());
            Console.WriteLine(markes[0]);

            // Masyvų paskutiniai elementai dviem būdais
            Console.WriteLine(pazymiai.Last());
            Console.WriteLine(pazymiai[pazymiai.Length - 1]);
            Console.WriteLine(markes.Last());
            Console.WriteLine(markes[markes.Length - 1]);
        }
    }
}
