using System;
using System.Collections.Generic;

namespace Uzduotis39
{
    internal class Mokinys
    {
        internal string vardas;
        internal string pavarde;
        internal List<PamokosPazymiai> pazymiai;

        internal Mokinys(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            pazymiai = new List<PamokosPazymiai>();
        }

        internal void Spausdinti()
        {
            Console.WriteLine();
            Console.WriteLine($"Mokinys: {vardas} {pavarde}");
            foreach (PamokosPazymiai pamoka in pazymiai)
            {
                pamoka.Spausdinti();
            }
        }
    }
}
