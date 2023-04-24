using System;
using System.Collections.Generic;

namespace Uzduotis39
{
    internal class Dienynas
    {
        List<Mokinys> mokiniai;

        internal Dienynas(List<Mokinys> mokiniai)
        {
            this.mokiniai = mokiniai;
        }

        internal void IvestiPazymius(string pamoka, Mokinys mokinys, List<double> pazymiai)
        {
            int mokinioNr = -1;

            for (int i = 0; i < mokiniai.Count; i++)
            {
                if (mokiniai[i].vardas == mokinys.vardas && mokiniai[i].pavarde == mokinys.pavarde)
                {
                    mokinioNr = i;
                }
            }

            if (mokinioNr == -1)
            {
                Console.WriteLine("Mokinio nėra");
                return;
            }
            else
            {
                int pamokosNr = -1;

                for (int i = 0; i < mokiniai[mokinioNr].pazymiai.Count; i++)
                {
                    if (mokiniai[mokinioNr].pazymiai[i].pamoka == pamoka)
                    {
                        pamokosNr = i;
                    }
                }

                if (pamokosNr == -1)
                {
                    Console.WriteLine($"Mokinys {mokinys.vardas} {mokinys.pavarde} neturi {pamoka} pamokos pažymių. Įrašomi nauji pažymiai.");
                    mokiniai[mokinioNr].pazymiai.Add(new PamokosPazymiai(pamoka, pazymiai));
                }
                else
                {
                    Console.WriteLine($"Papildome {mokinys.vardas} {mokinys.pavarde} {pamoka} pamokos pažymius.");
                    foreach (double pazymys in pazymiai)
                    {
                        mokiniai[mokinioNr].pazymiai[pamokosNr].pazymiai.Add(pazymys);
                    }
                }
            }
        }

        internal void Spausdinti()
        {
            Console.WriteLine();
            Console.WriteLine("Dienynas");
            foreach (Mokinys mokinys in mokiniai)
            {
                mokinys.Spausdinti();
            }
        }
    }
}
