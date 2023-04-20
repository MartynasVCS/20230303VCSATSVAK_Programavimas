using System;
using System.Linq;

namespace Uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Susikurkite savaitės temperatūrų rodmenų masyvą.
             * Raskite:
             *      žemiausią temperatūrą;
             *      didžiausią temperatūrą;
             *      vidurkį;
             *      Temperatūrų, esančių žemiau už vidurkį, kiekį;
             *      Temperatūrų, esančių aukščiau už vidurkį, kiekį.
             */

            int[] temperaturos = { 15, 14, 17, 16, 13, 10, 20, 21, 19 };
            double vidurkis = (double)temperaturos.Sum() / temperaturos.Length;
            double vidurkisFunkcija = temperaturos.Average();
            int kiekisZemiauUzVidurki = 0;
            int kiekisAuksciauUzVidurki = 0;

            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (temperaturos[i] < vidurkis) kiekisZemiauUzVidurki++;
                if (temperaturos[i] > vidurkis) kiekisAuksciauUzVidurki++;
            }

            Console.WriteLine($"Žemiausia temperatūra: {temperaturos.Min()}");
            Console.WriteLine($"Aukščiausia temperatūra: {temperaturos.Max()}");
            Console.WriteLine($"Temperatūrų vidurkis: {vidurkis}");
            Console.WriteLine($"Temperatūrų, esančių žemiau už vidurkį, kiekis: {kiekisZemiauUzVidurki}");
            Console.WriteLine($"Temperatūrų, esančių aukščiau už vidurkį, kiekis: {kiekisAuksciauUzVidurki}");
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Susikurkite studentų pažymių masyvą. 
             * Raskite:
             *      geriausią pažymį;
             *      kiek mokinių yra gavę dešimtukus;
             *      kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4);
             *      pažymių vidurkį.
             */

            int[] pazymiai = { 3, 2, 10, 10, 10, 9, 8, 6, 6, 7, 1, 10, 8, 7 };
            int geriausiasPazymys = pazymiai.Max();
            double vidurkisPazymiu = (double)pazymiai.Sum() / pazymiai.Length;
            int kiekisDesimtuku = 0;
            int kiekisNeigiamiu = 0;

            foreach (int pazymys in pazymiai)
            {
                if (pazymys == 10) kiekisDesimtuku++;
                if (pazymys < 4) kiekisNeigiamiu++;
            }

            Console.WriteLine($"Geriausias pažymys: {geriausiasPazymys}");
            Console.WriteLine($"Kiek mokinių yra gavę dešimtukus: {kiekisDesimtuku}");
            Console.WriteLine($"Kiek mokinių yra gavę neigiamą pažymį: {kiekisNeigiamiu}");
            Console.WriteLine($"Pažymių vidurkis: {vidurkisPazymiu}");
        }
    }
}
