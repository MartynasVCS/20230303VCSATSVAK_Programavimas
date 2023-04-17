using System;

namespace Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite vartotojui įvesti teigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti mažėjimo tvarka 
             * iki kol jis pasieks 0. 
             * Pvz.: 5 4 3 2 1. 
             * Kiekvieną kartą išvesti skirtingose eilutėse.
             */

            Console.Write("Įveskite teigiamą sveikąjį skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);

            while (skaicius > 0)
            {
                Console.WriteLine(skaicius--);
            }
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui įvesti neigiamą skaičių. 
             * Ciklo pagalba šį skaičių išvesti didėjimo tvarka 
             * iki kol jis pasieks 0, 
             * taip pat išvesti 0. 
             * Pvz.: -4 -3 -2 -1 0.
             * Kiekvieną kartą išvesti toje pačioje eilutėje, 
             * skaičius atskiriant tarpais.
             */

            Console.Write("Įveskite neigiamą sveikąjį skaičių: ");
            ivedimas = Console.ReadLine();
            skaicius = Convert.ToInt32(ivedimas);

            while (skaicius <= 0)
            {
                Console.Write($"{skaicius++} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            /*
             * 3 PUNKTAS
             * Padarykite skaičiuotuvą. 
             * Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius. 
             * Iš šių skaičių turi būti grąžinami visi 
             * sudėties, skirtumo, sandaugos ir dalmens atsakymai, 
             * išvedant kartu ir atliekamus veiksmus. 
             * Pvz.:
             * 5 + 4 = 9
             * 5 - 4 = 1
             * …
             * Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.
             */

            bool arTesti = true;
            while (arTesti)
            {
                Console.Write("Įveskite pirmą sveikąjį skaičių: ");
                ivedimas = Console.ReadLine();
                int skaicius1 = Convert.ToInt32(ivedimas);

                Console.Write("Įveskite antrą sveikąjį skaičių: ");
                ivedimas = Console.ReadLine();
                int skaicius2 = Convert.ToInt32(ivedimas);

                Console.WriteLine($"{skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
                Console.WriteLine($"{skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
                Console.WriteLine($"{skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
                Console.WriteLine($"{skaicius1} / {skaicius2} = {(double)skaicius1 / skaicius2}");
                Console.WriteLine();

                Console.Write("Ar norite įvesti kitus du skaičius? (taip/ne): ");
                ivedimas = Console.ReadLine();

                switch (ivedimas)
                {
                    case "taip":
                        Console.WriteLine("Tęskime!");
                        break;
                    case "ne":
                        arTesti = false;
                        Console.WriteLine("Viso gero.");
                        break;
                    default:
                        arTesti = false;
                        Console.WriteLine("Įvedėte nežinomą reikšmę, darbas nutraukiamas");
                        break;
                }
            }
        }
    }
}
