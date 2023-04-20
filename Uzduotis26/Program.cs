using System;
using System.Collections.Generic;
using System.Linq;

namespace Uzduotis26
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Sugeneruokite atsitiktinio dydžio sąrašą, 
             * kurį užpildykite atsitiktiniais skaičiais nuo 1 iki 100. 
             * Raskite:
             *      mažiausią skaičių;
             *      didžiausią skaičių;
             *      vidurkį;
             *      kiek skaičių yra žemesni už vidurkį;
             *      lyginių skaičių sumą;
             */

            List<int> skaiciai = new List<int>();
            Random randomGeneratorius = new Random();
            int sarasoIlgis = randomGeneratorius.Next(5, 50);
            int kiekisMazesniuUzVidurki = 0;
            int sumaLyginiuSkaiciu = 0;

            for (int i = 0; i < sarasoIlgis; i++)
            {
                skaiciai.Add(randomGeneratorius.Next(1, 101));
            }

            foreach (int skaicius in skaiciai)
            {
                Console.Write($"{skaicius} ");
                if (skaicius < skaiciai.Average()) kiekisMazesniuUzVidurki++;
                if (skaicius % 2 == 0) sumaLyginiuSkaiciu += skaicius;
            }
            Console.WriteLine();

            Console.WriteLine($"Elementų kiekis: {sarasoIlgis}");
            Console.WriteLine($"Mažiausias skaičius: {skaiciai.Min()}");
            Console.WriteLine($"Didžiausias skaičius: {skaiciai.Max()}");
            Console.WriteLine($"Vidurkis: {skaiciai.Average()}");
            Console.WriteLine($"Kiek skaičių yra žemesni už vidurkį: {kiekisMazesniuUzVidurki}");
            Console.WriteLine($"Lyginių skaičių suma: {sumaLyginiuSkaiciu}");
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui pasirinkti kiek 
             * studentų pažymių nori suvesti į sąrašą.  
             * 
             * Tegul jis užpildo šį sąrašą duomenimis, 
             * įvedant juos per konsolę. 
             * 
             * Raskite:
             *      didžiausią pažymį;
             *      mažiausią pažymį;
             *      vidurkį;
             */

            Console.Write("Kiek studentų pažymių norite suvesti į sarašą?: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());

            List<int> pazymiai = new List<int>();

            for (int i = 0; i < kiekis; i++)
            {
                Console.Write($"Įveskite {i + 1} pažymį: ");
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine($"Didžiausias pažymys: {pazymiai.Max()}");
            Console.WriteLine($"Mažiausias pažymys: {pazymiai.Min()}");
            Console.WriteLine($"Pažymių vidurkis: {pazymiai.Average()}");
        }
    }
}
