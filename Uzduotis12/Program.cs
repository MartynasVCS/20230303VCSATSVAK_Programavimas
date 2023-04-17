using System;

namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite įvesti tris skirtingus skaičius. 
             * Suraskite, kuris iš šių skaičių yra didžiausias. 
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

            Console.WriteLine("Įvesti skaičiai: '{0}', '{1}' ir '{2}'", skaicius1, skaicius2, skaicius3);
            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("Pirmas skaičius ({0}) yra didžiausias", skaicius1);
            }
            else if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("Antras skaičius ({0}) yra didžiausias", skaicius2);
            }
            else if (skaicius3 > skaicius1 && skaicius3 > skaicius2)
            {
                Console.WriteLine("Trečias skaičius ({0}) yra didžiausias", skaicius3);
            }
            else
            {
                Console.WriteLine("Kažkoks nenumatytas atvejis...");
            }
            Console.WriteLine();

            /* 2 PUNKTAS
             * Liepkite įvesti egzamino rezultatą. 
             * Atlikite šiuos patikrinimus:
             * ar gautas rezultatas yra [8-10];
             * ar gautas rezultatas yra [5-8);
             * ar gautas rezultatas yra < 5.
             */

            Console.WriteLine("Įveskite egzamino rezultatą");
            ivedimas = Console.ReadLine();
            int rezultatas = Convert.ToInt32(ivedimas);

            if (rezultatas >= 8 && rezultatas <= 10)
            {
                Console.WriteLine("Puikiai!");
            }
            else if (rezultatas >= 5 && rezultatas < 8)
            {
                Console.WriteLine("Patenkinamai");
            }
            else if (rezultatas < 5 && rezultatas >= 0)
            {
                Console.WriteLine("Neišlaikyta");
            }
            else
            {
                Console.WriteLine("Netinkamai įvestas rezultatas");
            }
            Console.WriteLine();

            /*
             * 3 PUNKTAS
             * Liepkite įvesti du skaičius. 
             * Patikrinkite (naudojant 4 atskirus if’us):
             *      ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;
             *      ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;
             *      ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;
             *      ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100.
             */

            Console.WriteLine("Įveskite pirmą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite antrą sveikąjį skaičių:");
            ivedimas = Console.ReadLine();
            skaicius2 = Convert.ToInt32(ivedimas);

            if (skaicius1 > skaicius2 || skaicius1 == 0)
            {
                Console.WriteLine("Pirma sąlyga tenkinama");
            }

            if (skaicius2 > skaicius1 || skaicius2 == 5)
            {
                Console.WriteLine("Antra sąlyga tenkinama");
            }

            if (skaicius1 > skaicius2 && skaicius1 == 20)
            {
                Console.WriteLine("Trečia sąlyga tenkinama");
            }

            if (skaicius2 > skaicius1 && skaicius2 < 100)
            {
                Console.WriteLine("Ketvirta sąlyga tenkinama");
            }
        }
    }
}
