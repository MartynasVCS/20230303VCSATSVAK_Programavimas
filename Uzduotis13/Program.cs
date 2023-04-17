using System;

namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite vartotojui įvesti tris skaičius. 
             * Su switch patikrinkite pirmąjį skaičių:
             *      ar jis lygus 1: išveskite visų trijų skaičių sumą;
             *      ar jis lygus 2: išveskite pirmo ir trečio skaičių skirtumą;
             *      ar jis lygus 3: išveskite antro ir trečio skaičių sandaugą.
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
            switch (skaicius1)
            {
                case 1:
                    Console.WriteLine("Pirmas skaičius yra lygus 1");
                    Console.WriteLine("Visų skaičių suma: '{0}'", skaicius1 + skaicius2 + skaicius3);
                    break;
                case 2:
                    Console.WriteLine("Pirmas skaičius yra lygus 2");
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: '{0}'", skaicius1 - skaicius2);
                    break;
                case 3:
                    Console.WriteLine("Pirmas skaičius yra lygus 3");
                    Console.WriteLine("Antro ir trečio skaičių sandauga: '{0}'", skaicius2 * skaicius3);
                    break;
            }
            Console.WriteLine();

            // 1 punkto užduotis perdaryta panaudojant masyvą įvedimui
            int[] skaiciai = new int[3];
            string[] isvedimai = { "pirmą", "antrą", "trečią" };

            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine($"Įveskite {isvedimai[i]} sveikąjį skaičių:");
                string ivedimas_cikle = Console.ReadLine();
                skaiciai[i] = Convert.ToInt32(ivedimas_cikle);
            }

            Console.WriteLine("Įvesti skaičiai: '{0}', '{1}' ir '{2}'", skaiciai[0], skaiciai[1], skaiciai[2]);
            switch (skaiciai[0])
            {
                case 1:
                    Console.WriteLine("Pirmas skaičius yra lygus 1");
                    Console.WriteLine("Visų skaičių suma: '{0}'", skaiciai[0] + skaiciai[1] + skaiciai[2]);
                    break;
                case 2:
                    Console.WriteLine("Pirmas skaičius yra lygus 2");
                    Console.WriteLine("Pirmo ir trečio skaičių skirtumas: '{0}'", skaiciai[0] - skaiciai[1]);
                    break;
                case 3:
                    Console.WriteLine("Pirmas skaičius yra lygus 3");
                    Console.WriteLine("Antro ir trečio skaičių sandauga: '{0}'", skaiciai[1] * skaiciai[2]);
                    break;
            }
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui įvesti gyvūno rūšį. 
             * Su switch patikrinkite:
             *      ar įvestas gyvūnas yra šuo;
             *      ar įvestas gyvūnas yra katė;
             *      ar įvestas gyvūnas yra žiurkėnas.
             */

            Console.WriteLine("Įveskite gyvūno pavadinimą:");
            string gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("Gyvūno rūšis yra šuo");
                    break;
                case "kate":
                    Console.WriteLine("Gyvūno rūšis yra katė");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Gyvūno rūšis yra žiūrkėnas");
                    break;
            }
        }
    }
}
