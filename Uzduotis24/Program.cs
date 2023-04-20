using System;

namespace Uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Paklausti vartotojo, 
             * kiek duomenų nori įvesti į masyvą.
             * 
             * Pagal tai sukursime tokio dydžio masyvą
             * 
             * Iš konsolės įvesti duomenis į masyvą (leisti vartotojui įvesti)
             * 
             * Surasti 2 sumas:
             *      Suma1 – kai masyvo elementas yra lyginis skaičius  
             *      Suma2 – kai masyvo indeksas nėra lyginis skaičius
             */

            Console.Write("Kiek skaičių norite įvesti?: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());

            int[] skaiciai = new int[kiekis];

            for (int i = 0; i < kiekis; i++)
            {
                Console.Write($"Įveskite {i + 1} skaičių: ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma1 = 0;
            int suma2 = 0;

            for (int i = 0; i < kiekis; i++)
            {
                if (skaiciai[i] % 2 == 0) suma1 += skaiciai[i];
                if (i % 2 != 0) suma2 += skaiciai[i];
            }

            Console.WriteLine($"Suma1 – kai masyvo elementas yra lyginis skaičius: {suma1}");
            Console.WriteLine($"Suma2 – kai masyvo indeksas nėra lyginis skaičius: {suma2}");
        }
    }
}
