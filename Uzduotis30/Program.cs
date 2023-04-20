using System;

namespace Uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Leiskite vartotojui įvesti 
             * du sveikuosius skaičius į programą.  
             * Sukurkite ir panaudokite šiuos metodus:
             *      Suma;
             *      Skirtumas;
             *      Sandauga;
             *      Dalmuo;
             */

            int skaicius1 = Konvertavimas(Ivedimas("Įveskite pirmą skaičių"));
            int skaicius2 = Konvertavimas(Ivedimas("Įveskite antrą skaičių"));

            int suma = Suma(skaicius1, skaicius2);
            int skirtumas = Skirtumas(skaicius1, skaicius2);
            int sandauga = Sandauga(skaicius1, skaicius2);
            double dalmuo = Dalyba(skaicius1, skaicius2);

            Spausdinimas(skaicius1, skaicius2, suma.ToString(), '+');
            Spausdinimas(skaicius1, skaicius2, skirtumas.ToString(), '-');
            Spausdinimas(skaicius1, skaicius2, sandauga.ToString(), '*');
            Spausdinimas(skaicius1, skaicius2, dalmuo.ToString(), '/');
        }

        private static void Spausdinimas(int skaicius1, int skaicius2, string rezultatas, char veiksmas)
        {
            Console.WriteLine($"{skaicius1} {veiksmas} {skaicius2} = {rezultatas}");
        }

        private static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        private static int Sandauga(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }

        private static int Skirtumas(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        private static int Suma(int skaicius1, int skaicius2)
        {
            return skaicius1 + skaicius2;
        }

        private static int Konvertavimas(string ivedimas)
        {
            return Convert.ToInt32(ivedimas);
        }

        private static string Ivedimas(string zinute)
        {
            Console.Write($"{zinute}: ");
            return Console.ReadLine();
        }
    }
}
