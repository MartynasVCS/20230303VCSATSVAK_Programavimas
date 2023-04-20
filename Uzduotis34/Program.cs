using System;

namespace Uzduotis34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Įvesti du skaičius iš konsolės
             * 
             * Paklausti vartotojo kokį veiksmą 
             * su tais skaičiais nori atlikti: Daugybą ar  dalybą
             * 
             * Parašyti po atskirą metodą kiekvienam veiksmui 
             * (daugybai naudoti int tipą, o  dalybai double)
             * 
             * Su if patikrinti kokį veiksmą atlikti 
             * ir išsikviesti atitinkamą metodą, 
             * jei tokio  veiksmo nėra – informuoti vartotoją, 
             * jog tokio veiksmo nėra.
             * 
             */

            // Lietuviškų raidžių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Įveskite pirmą sveikąjį skaičių: ");
            string ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.Write("Įveskite antrą sveikąjį skaičių: ");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.Write("Kokį veiksmą norite atlikti? (daugyba / dalyba): ");
            ivedimas = Console.ReadLine();

            if (ivedimas == "daugyba")
            {
                Console.WriteLine($"Sandauga: {Daugyba(skaicius1, skaicius2)}");
            }
            else if (ivedimas == "dalyba")
            {
                Console.WriteLine($"Dalyba: {Dalyba(skaicius1, skaicius2)}");
            }
            else
            {
                Console.WriteLine($"veiksmo '{ivedimas}' nėra!");
            }
        }

        private static double Dalyba(int skaicius1, int skaicius2)
        {
            return (double)skaicius1 / skaicius2;
        }

        private static int Daugyba(int skaicius1, int skaicius2)
        {
            return skaicius1 * skaicius2;
        }
    }
