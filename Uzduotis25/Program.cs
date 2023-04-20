using System;
using System.Linq;

namespace Uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Liepti vartotojui įvesti 5 pažymius 
             * VIENOJE eilutėje atskiriant tarpu. 
             * Rasti didžiausią pažymį.
             */

            Console.Write($"Įveskite 5 pažymius atskiriant juos tarpu: ");
            string ivedimas = Console.ReadLine(); // "5 7 8 10 6 3"
            string[] suskaidytasIvedimas = ivedimas.Split(' ');

            int[] skaiciai = new int[suskaidytasIvedimas.Length];
            for (int i = 0; i < suskaidytasIvedimas.Length; i++)
            {
                skaiciai[i] = Convert.ToInt32(suskaidytasIvedimas[i]);
            }

            Console.WriteLine(suskaidytasIvedimas.Max());
            Console.WriteLine($"Didžiausias pažymys: {skaiciai.Max()}");

            /*
             * Liepti vartotojui įvesti 5 pažymius 
             * VIENOJE eilutėje atskiriant kableliu. 
             * Rasti mažiausią pažymį.
             */

            Console.Write("Įveskite 5 pažymius, atskiriant juos kableliu: ");
            ivedimas = Console.ReadLine(); // "9,8,5,10,8"
            string[] pazymiaiTekstiniai = ivedimas.Split(',');

            int[] pazymiaiSkaitiniai = new int[pazymiaiTekstiniai.Length];
            for (int i = 0; i < pazymiaiTekstiniai.Length; i++)
            {
                pazymiaiSkaitiniai[i] = Convert.ToInt32(pazymiaiTekstiniai[i]);
            }

            Console.WriteLine("Mažiausias pažymys: " + pazymiaiSkaitiniai.Min());
        }
    }
}
