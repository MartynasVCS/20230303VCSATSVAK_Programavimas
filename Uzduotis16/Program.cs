using System;

namespace Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Raskite visų skaičių nuo 1 iki 100 sumą.
             */

            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }

            Console.WriteLine($"Skaičių nuo 1 iki 100 suma: '{suma}'");
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Raskite visų lyginių skaičių nuo 20 iki 40 sumą.
             */

            suma = 0;

            // Kaip aprašyti for ciklą, kad viduje nereiktų if sąlygos? ;)
            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine($"Lyginių skaičių tarp 20 ir 40 suma: '{suma}'");
            Console.WriteLine();

            /*
             * 3 PUNKTAS
             * Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.
             */

            suma = 0;

            // Kaip aprašyti for ciklą, kad viduje nereiktų if sąlygos? ;)
            for (int i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine($"Nelyginių skaičių tarp 30 ir 60 suma: '{suma}'");
            Console.WriteLine();

            /*
             * 4 PUNKTAS
             * Rasti visų skaičių, 
             * žemesnių už 1000 ir didesnių už 0 
             * bei kurie dalinasi iš 3 arba 5, sumą.
             * Pavyzdys:
             *      Visi skaičiai mažesni už 10 
             *      ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
             *      Šių skaičių suma yra 23.
             *  Turite gauti 233168 atsakymą.
             */

            suma = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine($"Skaičių (0, 1000) kurie dalijasi iš 3 arba 5 suma: '{suma}'");
            Console.WriteLine();
        }
    }
}
