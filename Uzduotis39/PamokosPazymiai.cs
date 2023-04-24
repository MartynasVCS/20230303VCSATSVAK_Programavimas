using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis39
{
    internal class PamokosPazymiai
    {
        internal string pamoka;
        internal List<double> pazymiai;

        internal PamokosPazymiai(string pamoka, List<double> pazymiai)
        {
            this.pamoka = pamoka;
            this.pazymiai = pazymiai.ToList();
        }

        internal void Spausdinti()
        {
            Console.Write($"{pamoka}:   ");
            foreach (double pazymys in pazymiai)
            {
                Console.Write($"{pazymys} ");
            }
            Console.WriteLine();

        }
    }
}
