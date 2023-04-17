using System;

namespace Uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Parašyti For ciklą, kuris suskaičiuotų, 
             * kiek skaičių intervale [0 – 1000) dalinasi iš 16.
             */
            int skaitiklis = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 16 == 0)
                {
                    skaitiklis++;
                }
            }

            Console.WriteLine($"Intervale [0 - 1000) iš 16 besidalinančių skaičių kiekis - {skaitiklis}");
            Console.WriteLine();

            /*
             * Liepkite vartotojui įvesti teigiamą skaičių. 
             * While ciklo viduje skaičių kelkite vis
             * didesniu laipsniu ir jį išveskite į ekraną, 
             * kol skaičius netaps didesnis už 1500.
             */

            Console.Write("Įveskite teigiamą sveiką skaičių: ");
            string ivedimas = Console.ReadLine();
            double skaicius = Convert.ToDouble(ivedimas);

            double rezultatas = skaicius;
            int laipsnis = 1;

            while (rezultatas <= 1500)
            {
                rezultatas = Math.Pow(skaicius, laipsnis++);
                if (rezultatas <= 1500)
                {
                    Console.WriteLine(rezultatas);
                }
            }
        }
    }
}
