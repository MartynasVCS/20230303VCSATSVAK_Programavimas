using System;

namespace Uzduotis31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * Parašykite sumos funkciją su 3 parametrais
             * kuris gražina int tipo atsakymą.
             * 
             * Parašykite dalmens funkciją su 2 parametrais
             * kuris gražina double tipo atsakymą.
             * 
             * Išsikvieskite abi funkcijas ir atsakymą išveskite į ekraną.
             */

            int skaicius1 = 5;
            int skaicius2 = 10;
            int skaicius3 = 15;

            int suma = Suma(skaicius1, skaicius2, skaicius3);
            double dalmuo = Dalyba(skaicius1, skaicius2);

            Console.WriteLine($"Skaičiai: '{skaicius1}', '{skaicius2}' ir '{skaicius3}'");
            Console.WriteLine($"Trijų skaičių suma: '{suma}'");
            Console.WriteLine($"Pirmo ir antro skaičių dalyba: '{dalmuo}'");
        }

        private static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        private static int Suma(int skaicius1, int skaicius2, int skaicius3)
        {
            return skaicius1 + skaicius2 + skaicius3;
        }
    }
}
