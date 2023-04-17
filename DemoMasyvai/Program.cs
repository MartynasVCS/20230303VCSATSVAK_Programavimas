using System;

namespace DemoMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Masyvas iš konkrečių reikšmių
            int[] skaiciuMasyvas = { 1, 9, 5, 7, 7 };

            // Konkretaus dydžio masyvas
            int[] skaiciuMasyvasTuscias = new int[5];
            string[] zodziuMasyvasTuscias = new string[5];

            // Masyvo reikšmių spausdinimas po vieną          
            Console.WriteLine(skaiciuMasyvas[4]);
            Console.WriteLine(skaiciuMasyvas[2]);
            Console.WriteLine(skaiciuMasyvas); // Atspausdint kintamojo tipą
            Console.WriteLine();

            // Masyvo reikšmių spausdinimas ciklu          
            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.WriteLine(skaiciuMasyvas[i]);
            }
            Console.WriteLine();

            foreach (int skaicius in skaiciuMasyvas)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();

            //Masyvo reikšmių perrašymas
            //for (int i = 0; i < skaiciuMasyvas.Length; i++)
            //{
            //    skaiciuMasyvas[i] = i;
            //}

            // Su foreach galime tik nuskaityti reikšmes
            foreach (int skaicius in skaiciuMasyvas)
            {
                //skaicius = 5; // Negalimas veiksmas
            }

            // Paskutinis elementas
            Console.WriteLine(skaiciuMasyvas[skaiciuMasyvas.Length - 1]);
            Console.WriteLine();

            // Algoritmas - sumos paieška
            int suma = 0;
            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                suma += skaiciuMasyvas[i];
            }
            Console.WriteLine($"Suma: {suma}");

            // Algoritmas - min/max (adaptuotas...)
            int max = int.MinValue;
            foreach (int skaicius in skaiciuMasyvas)
            {
                if (skaicius > max)
                {
                    max = skaicius;
                }
            }
            if (max != int.MinValue)
            {
                Console.WriteLine($"Max: {max}");
            }
        }
    }
}
