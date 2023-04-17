using System;
using System.Collections.Generic;

namespace DemoSarasai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Masyvai
            int[] skaiciuMasyvas = { 1, 2, 3 };
            int[] skaiciusMasyvasTuscias = new int[3];

            // Sarasai
            List<int> skaiciusSarasas = new List<int>() { 1, 2, 3};
            List<int> skaiciusSarasasTuscias = new List<int>();

            // Spausdinimas
            Console.WriteLine(skaiciusSarasas[0]);
            Console.WriteLine();

            foreach (int skaicius in skaiciusSarasas)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();

            // Reikšmių perrašymas
            skaiciusSarasas[0] = 999;
            Console.WriteLine(skaiciusSarasas[0]);
            Console.WriteLine();

            // Reikšmių pridėjimas
            skaiciusSarasas.Add(5);
            skaiciusSarasas.Add(99);
            skaiciusSarasas.Add(1000);
            skaiciusSarasas.Add(55);
            skaiciusSarasas.Add(11);
            foreach (int skaicius in skaiciusSarasas)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();

            // Reikšmių spausdinimas pagal indeksą
            Console.WriteLine(skaiciusSarasas[7]);
            Console.WriteLine();

            // Reikšmių ištrynimas
            skaiciusSarasas.RemoveAt(5);
            foreach (int skaicius in skaiciusSarasas)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();
        }
    }
}
