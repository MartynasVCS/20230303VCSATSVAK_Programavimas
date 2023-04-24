using System;
using System.Collections.Generic;

namespace Uzduotis39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Mokinys> mokiniai = new List<Mokinys>
            {
                new Mokinys("Martynas", "Martynauskas"),
                new Mokinys("Petras", "Petrauskas")
            };

            Dienynas dienynas = new Dienynas(mokiniai);
            dienynas.IvestiPazymius("matematika", mokiniai[0], new List<double> { 10, 9, 8 });
            dienynas.IvestiPazymius("matematika", mokiniai[1], new List<double> { 10, 9, 8 });
            dienynas.IvestiPazymius("lietuvių", mokiniai[0], new List<double> { 10, 9, 8 });
            dienynas.IvestiPazymius("lietuvių", mokiniai[1], new List<double> { 10, 9, 8 });

            dienynas.Spausdinti();
            Console.WriteLine();

            dienynas.IvestiPazymius("matematika", mokiniai[0], new List<double> { 8, 7, 5 });
            dienynas.IvestiPazymius("kūno kultūra", mokiniai[0], new List<double> { 2, 10 });

            dienynas.Spausdinti();
            Console.WriteLine();
        }
    }
}
