using System;

namespace Uzduotis6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Išveskite pasirinkto skaičiaus daugybos lentelę.
             * Pvz.: 
             * 5 * 0 = 0
             * 5 * 1 = 5
             * …
             * 5 * 10 = 50
             */

            int skaicius = 5;
            int daugiklis = 0;

            Console.WriteLine($"Skaiciaus '{skaicius}' daugybos lentele:");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();

            /*
             * Susikurkite sveikojo skaičiaus kintamąjį
             * su dviženklio skaičiaus reikšme. 
             * Išveskite į ekraną šio skaičiaus skaitmenų sandaugą.
             */

            int dvizenklisSkaicius = 23;
            int desimtys = dvizenklisSkaicius / 10;
            int vienetai = dvizenklisSkaicius % 10;

            Console.WriteLine($"Dvizenklis skaicius: {dvizenklisSkaicius}");
            Console.WriteLine($"Skaitmenu sandauga: {desimtys} * {vienetai} = {desimtys * vienetai}");
        }
    }
}
