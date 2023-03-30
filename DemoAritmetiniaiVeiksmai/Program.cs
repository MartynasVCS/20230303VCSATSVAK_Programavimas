using System;

namespace DemoAritmetiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int sudetis = 2 + 3;
            Console.WriteLine(sudetis);
            Console.WriteLine(7 - 2);
            Console.WriteLine();

            Console.WriteLine(5 + 5 * 2);
            Console.WriteLine((5 + 5) * 2);
            Console.WriteLine();

            // Sveikųjų skaičių dalyba
            Console.WriteLine(8 / 4);
            Console.WriteLine(7 / 4); // Sveikoji dalis
            Console.WriteLine(7 % 4); // Liekana
            Console.WriteLine();

            // Realiųjų skaičių dalyba
            Console.WriteLine(7 / 3.0);
            Console.WriteLine(7 / 3.0f);

            // Casting 
            int dalinys = 7;
            int daliklis = 3;
            Console.WriteLine(dalinys / (double)daliklis);
            Console.WriteLine((double)dalinys / daliklis);

            // Console.WriteLine(1 / 0); // Šitas neveikia
            Console.WriteLine(1 / 0.0);
            Console.WriteLine();

            // Kintamojo reikšmės keitimas
            int skaicius = 5;
            Console.WriteLine(skaicius);
            skaicius = skaicius * 2;
            Console.WriteLine(skaicius);
            skaicius *= 2;
            Console.WriteLine(skaicius);
            Console.WriteLine();

            // Didinimas / mažinimas vienetu
            int indeksas = 5;
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas++);
            Console.WriteLine(indeksas);
            Console.WriteLine();

            indeksas = 5;
            Console.WriteLine(++indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(++indeksas);
            Console.WriteLine(indeksas);
            Console.WriteLine();

            // Sudėtingesni aritmetiniai veiksmai
            Console.WriteLine(5 * 5);
            Console.WriteLine(5 * 5 * 5);
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Pow(5, 3));
            Console.WriteLine(Math.Sqrt(25)); // Kvadratinė šaknis
            Console.WriteLine(Math.Pow(25, 0.5)); // Kvadratinė šaknis
            Console.WriteLine(Math.Pow(125, 1 / 3.0)); // Kubinė šaknis
        }
    }
}