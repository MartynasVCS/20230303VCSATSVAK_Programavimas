using System;
using System.Linq;

namespace Uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurkite kintamąjį, 
             * kuris pasakytų kiek automobilis vidutiniškai sunaudoja 
             * degalų 100 – ui km. 
             * Susikurkite masyvą, kuriame saugotumėte skirtingose
             * kelionėse nuvažiuotų kilometrų rodmenis. 
             * Raskite:
             *      trumpiausią kelionę;
             *      ilgiausią kelionę;
             *      kiek kuro sąnaudų sunaudojo automobilis 
             *          (skaičiavimui reikės rasti visus nuvažiuotus km).
             */

            double sanaudosSimtuiKm = 7.5;
            int[] keliones = { 115, 2548, 26, 225, 225, 135, 150, 254 };

            double sanaudosVisuKelioniu = sanaudosSimtuiKm * keliones.Sum() / 100;

            Console.WriteLine($"Trumpiausia kelionė: {keliones.Min()}");
            Console.WriteLine($"Ilgiausia kelionė: {keliones.Max()}");
            Console.WriteLine($"Nuvažiuota kilometrų: {keliones.Sum()}");
            Console.WriteLine($"Kuro sąnaudos: {sanaudosVisuKelioniu}");
        }
    }
}
