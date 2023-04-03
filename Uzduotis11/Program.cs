using System;

namespace Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite vartotojui įvesti tris skaičius, 
             * parašyti šią patikrinimo sąlygą, naudojant else if dalis:
             *      ar pirmas skaičius didesnis už antrą;
             *      ar antras skaičius didesnis už trečią;
             *      ar trečias skaičius didesnis už pirmą;
             *      ar pirmi du skaičiai lygūs;
             */

            Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite trečią sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius3 = Convert.ToInt32(ivedimas);

            Console.WriteLine($"Įvesti skaičiai: '{skaicius1}', '{skaicius2}' ir '{skaicius3}'");
            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("Pirmas skaičius didesnis už antrą skaičių");
            }
            else if (skaicius2 > skaicius3)
            {
                Console.WriteLine("Antras skaičius didesnis už trečią skaičių");
            }
            else if (skaicius3 > skaicius1)
            {
                Console.WriteLine("Trečias skaičius didesnis už pirmą skaičių");
            }
            else if (skaicius1 == skaicius2)
            {
                Console.WriteLine("Pirmi du skaičiai yra lygūs");
            }
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui įvesti šios dienos oro temperatūrą, 
             * atlikite šiuos patikrinimus:
             * ar temperatūra < 0 - išvesti “žiauriai šalta”;
             * ar temperatūra < 10 - išvesti “labai šalta”;
             * ar temperatūra < 20 - išvesti “šalta”;
             * ar temperatūra < 30 - išvesti “normali temperatūra”;
             * ar temperatūra < 40 - išvesti “karšta”;
             * ar temperatūra >= 40 - išvesti “visiškai degina”;
             */

            Console.WriteLine("Įveskite šios dienos temperatūrą:");
            ivedimas = Console.ReadLine();
            int temperatura = Convert.ToInt32(ivedimas);

            if (temperatura < 0)
            {
                Console.WriteLine("Žiauriai šalta");
            }
            else if (temperatura < 10)
            {
                Console.WriteLine("Labai šalta");
            }
            else if (temperatura < 20)
            {
                Console.WriteLine("Šalta");
            }
            else if (temperatura < 30)
            {
                Console.WriteLine("Normali temperatūra");
            }
            else if (temperatura < 40)
            {
                Console.WriteLine("Karšta");
            }
            else
            {
                Console.WriteLine("Labai karšta");
            }
        }
    }
}
