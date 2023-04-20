using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Susikurti žodžių sąrašą. 
             * 
             * Rasti trumpiausią ir ilgiausią žodžius, 
             * juos išvesti į ekraną, 
             * prie kiekvieno pasakant iš kiek raidžių jis yra sudarytas.
             *      Tip: string kintamasis iš tiesų yra char masyvas, 
             *      todėl galite naudoti zodis.Length
             */

            List<string> zodziuSarasas = new List<string>();
            zodziuSarasas.Add("žodis");
            zodziuSarasas.Add("šokoladas");
            zodziuSarasas.Add("pienas");
            zodziuSarasas.Add("akvariumas");
            zodziuSarasas.Add("du");

            int indeksasIlgiausio = -1;
            int ilgisIlgiausio = Int32.MinValue;
            int indeksasTrumpiausio = -1;
            int ilgisTrumpiausio = Int32.MaxValue;

            for (int i = 0; i < zodziuSarasas.Count; i++)
            {
                if (zodziuSarasas.ElementAt(i).Length > ilgisIlgiausio)
                {
                    indeksasIlgiausio = i;
                }

                if (zodziuSarasas.ElementAt(i).Length < ilgisTrumpiausio)
                {
                    indeksasTrumpiausio = i;
                }
            }

            Console.WriteLine($"Ilgiausias žodis: '{zodziuSarasas.ElementAt(indeksasIlgiausio)}', jo ilgis: '{zodziuSarasas.ElementAt(indeksasIlgiausio).Length}'");
            Console.WriteLine($"Trumpiausias žodis: '{zodziuSarasas.ElementAt(indeksasTrumpiausio)}', jo ilgis: '{zodziuSarasas.ElementAt(indeksasTrumpiausio).Length}'");
        }
    }
}
