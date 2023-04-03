using System;

namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite vartotojui įvesti savo amžių. 
             * Jei amžius yra 18 arba daugiau, 
             * tuomet į ekraną išveskite, 
             * kad “jūs galite balsuoti”.
             */

            Console.WriteLine("Įveskite savo amžių");
            string ivedimas = Console.ReadLine();
            int amzius = Convert.ToInt32(ivedimas);

            if (amzius >= 18)
            {
                Console.WriteLine("Jūs galite balsuoti.");
            }
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui įvesti bet kokį skaičių. 
             * Parašykite šias atskiras if sąlygas:
             *      Patikrinti, ar skaičius neigiamas, 
             *          jei taip - aprėkti vartotoją :)
             *      Patikrinti, ar skaičius teigiamas, 
             *          jei taip - pasveikinti vartotoją;
             *      Patikrinti, ar skaičius lyginis, 
             *          jei taip - išvesti “taip, skaičius yra lyginis”;
             *      Patikrinti, ar skaičius dalinasi iš 4, 
             *          jei taip - išvesti “taip, dalinasi iš 4”;
             *      Patikrinti, ar skaičius yra didesnis nei 10, 
             *          jei taip - išvesti “taip, skaičius yra didesnis už 10”.

             */

            Console.WriteLine("Įveskite bet kokį skaičių");
            ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);

            Console.WriteLine($"Įvestas skaičius: '{skaicius}'");
            if (skaicius < 0)
            {
                Console.WriteLine("AAAAAA!!!");
            }

            if (skaicius > 0)
            {
                Console.WriteLine("Sveikiname!!!");
            }

            if (skaicius % 2 == 0)
            {
                Console.WriteLine("Skaičius yra lyginis");
            }

            if (skaicius % 4 == 0)
            {
                Console.WriteLine("Skaičius dalinasi iš 4");
            }

            if (skaicius > 10)
            {
                Console.WriteLine("Skaičius yra didesnis už 10");
            }
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti penkis savo pažymius,
             * raskite šių pažymių vidurkį, 
             * patikrinkite, ar vidurkis yra lygus arba didesnis už 5, 
             * jei taip, išveskite “Valio!!!”.
             */

            Console.WriteLine("Įveskite pirmą pažymį:");
            ivedimas = Console.ReadLine();
            int pazymys1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite antrą pažymį:");
            ivedimas = Console.ReadLine();
            int pazymys2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite trečią pažymį:");
            ivedimas = Console.ReadLine();
            int pazymys3 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite ketvirtą pažymį:");
            ivedimas = Console.ReadLine();
            int pazymys4 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite penktą pažymį:");
            ivedimas = Console.ReadLine();
            int pazymys5 = Convert.ToInt32(ivedimas);

            double vidurkis = (double)(pazymys1 + pazymys2 + pazymys3 + pazymys4 + pazymys5) / 5;

            if (vidurkis >= 5)
            {
                Console.WriteLine("Valio!!!");
            }
        }
    }
}
