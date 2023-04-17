using System;

namespace DemoMetodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DemoMetodai.Program.Pasisveikinimas(); // Pilnas kelias į metodą
            Pasisveikinimas(); // Kadangi kviečiame metodą toje pačioje klasėje tai užtenka tik metodo pavadinimo
            string vardas = "Petrai";

            // Parameter list
            PasisveikinimasNaudojantVarda("Pauliau");
            PasisveikinimasNaudojantVarda(vardas);
            Suma(7, 8);

            // Return type
            double dalmuo = Dalyba(10, 3);
            Console.WriteLine(dalmuo);
            Console.WriteLine(Atimtis(10, 5));

            // Rekursinis metodas
            DalybaIsTrijuKolBusNulis(100);
        }

        private static void DalybaIsTrijuKolBusNulis(float skaicius)
        {
            float rezultatas = (float)skaicius / 3;
            Console.WriteLine(rezultatas);

            if (Math.Round(rezultatas, 6) != 0)
            {
                DalybaIsTrijuKolBusNulis(rezultatas);
            }
        }

        private static int Atimtis(int skaicius1, int skaicius2)
        {
            return skaicius1 - skaicius2;
        }

        private static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        private static void Pasisveikinimas()
        {
            Console.WriteLine("Labas, pasauli!");
        }

        private static void PasisveikinimasNaudojantVarda(string vardas)
        {
            Console.WriteLine($"Labas, {vardas}");
        }

        private static void Suma(int skaicius1, int skaicius2)
        {
            Console.WriteLine(skaicius1 + skaicius2);
        }
    }
}
