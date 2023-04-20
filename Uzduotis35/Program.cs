using System;
using System.Linq;

namespace Uzduotis35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Sukurti void tipo metodą, kuriam paduosim masyvą.
             * 
             * Metodas turi išvesti masyvo sumą 
             *      (sumai skaičiuoti naudoti for ciklą ir .Sum()  funkciją. 
             *      Tuomet metodas išves į konsolę 2 tokias pačias sumas
             *      suskaičiuotas skirtingais būdais)
             * 
             * Išsikviesti metodą.
             */

            int[] masyvas = { 5, 7, 8, 15, 20, 3, 5, 17 };

            SkaiciuotiSuma(masyvas);
        }

        private static void SkaiciuotiSuma(int[] masyvas)
        {
            int sumaCiklo = 0;

            for (int i = 0; i < masyvas.Length; i++)
            {
                sumaCiklo += masyvas[i];
            }

            int sumaMasyvo = masyvas.Sum();

            Console.WriteLine(sumaCiklo);
            Console.WriteLine(sumaMasyvo);
        }
    }
}
