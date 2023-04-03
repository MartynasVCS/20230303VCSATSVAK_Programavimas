using System;

namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Išveskite į ekraną dviejų skaičių 
             * sumą, skirtumą, sandaugą ir dalmenį,
             * kiekvieną kartą nurodant atliekamą veiksmą 
             * ir šių skaičių reikšmes. 
             * Pvz.: 
             * 4 + 5 = 9
             * 4 - 5 = -1
             * …
             */

            int pirmas = 4;
            int antras = 9;

            Console.WriteLine($"Veiksmai su skaiciais '{pirmas}' ir '{antras}':");
            Console.WriteLine($"Suma: {pirmas} + {antras} = {pirmas + antras}");
            Console.WriteLine($"Skirtumas: {pirmas} - {antras} = {pirmas - antras}");
            Console.WriteLine($"Sandauga: {pirmas} * {antras} = {pirmas * antras}");
            Console.WriteLine($"Dalyba: {pirmas} / {antras} = {(double)pirmas / antras}");
            Console.WriteLine();

            /*
             * Išveskite į ekraną pasirinktą skaičių, 
             * jo kvadratą ir jį pakeltą trečiuoju laipsniu.
             */

            int skaicius = 5;
            Console.WriteLine($"Veiksmai su skaiciumi '{skaicius}':");

            // Kelimas kvadratu
            Console.WriteLine($"Skaicius kvadratu: {skaicius}^2 = {skaicius * skaicius}");
            //Console.WriteLine(Math.Pow(skaicius, 2));

            // Kelimas kubu
            Console.WriteLine($"Skaicius kvadratu: {skaicius}^3 = {skaicius * skaicius * skaicius}");
            //Console.WriteLine(Math.Pow(skaicius, 3));
            Console.WriteLine();

            /*
             * Išveskite į ekraną trijų skaičių sandaugą.
             */

            int skaicius1 = 5;
            int skaicius2 = 6;
            int skaicius3 = 7;

            Console.WriteLine($"Skaiciu '{skaicius1}', '{skaicius2}' ir '{skaicius3}' sandauga:");
            Console.WriteLine($"{skaicius1} * {skaicius2} * {skaicius3} = {skaicius1 * skaicius2 * skaicius3}");
            Console.WriteLine();
        }
    }
}
