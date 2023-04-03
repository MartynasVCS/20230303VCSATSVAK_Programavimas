using System;

namespace Uzduotis8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. 
             * Išveskite šio skaičiaus daugybos lentelę nuo 1 iki 5. Pvz.:
             * 2 * 1 = 2
             * …
             * 2 * 5 = 10
             */

            Console.WriteLine("Įveskite bet kokį sveikąjį skaičių:");

            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);
            int daugiklis = 1;

            Console.WriteLine("Skaičiaus '{0}' daugybos lentelė:", skaicius);
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui įvesti tris skaičius. 
             * Į ekraną išveskite šiuos skaičius ir jų vidurkį. 
             * Pvz.:
             * Įvestų skaičių 4, 5, 8 vidurkis: 5,7.
             */

            Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite trečią sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius3 = Convert.ToInt32(ivedimas);

            double vidurkis = (double)(skaicius1 + skaicius2 + skaicius3) / 3;
            Console.WriteLine($"Įvestų skaičių '{skaicius1}', '{skaicius2}' ir '{skaicius3}' vidurkis: '{vidurkis}'");
            Console.WriteLine();

            /*
             * 3 PUNKTAS
             * Liepkite įvesti tris skaičius. 
             * Išveskite įvestus skaičius, 
             * jų kvadratus, 
             * juos pakeltus trečiuoju laipsniu,
             * taip pat tuos skaičius, padalintus iš dviejų.
             */

            Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            skaicius2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite trečią sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            skaicius3 = Convert.ToInt32(ivedimas);

            // Skaičiuojame kvadratus:
            double sk1kv = Math.Pow(skaicius1, 2);
            double sk2kv = Math.Pow(skaicius2, 2);
            double sk3kv = Math.Pow(skaicius3, 2);

            // Skaičiuojame kubus:
            double sk1kubu = Math.Pow(skaicius1, 3);
            double sk2kubu = Math.Pow(skaicius2, 3);
            double sk3kubu = Math.Pow(skaicius3, 3);

            // Skaičiuojame puses (skaičius padalintas iš 2)
            double sk1puse = (double)skaicius1 / 2;
            double sk2puse = (double)skaicius2 / 2;
            double sk3puse = (double)skaicius3 / 2;

            Console.WriteLine($"Buvo įvesti skaičiai: '{skaicius1}', '{skaicius2}' ir '{skaicius3}'");
            Console.WriteLine($"Skaičių kvadratai: '{sk1kv}', '{sk2kv}' ir '{sk3kv}'");
            Console.WriteLine($"Skaičių kubai: '{sk1kubu}', '{sk2kubu}' ir '{sk3kubu}'");
            Console.WriteLine($"Skaičiai padalinti iš 2: '{sk1puse}', '{sk2puse}' ir '{sk3puse}'");
            Console.WriteLine();
        }
    }
}
