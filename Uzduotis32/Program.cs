using System;

namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Paprašyti įvesti vartotojo vardą.
            
             * Sukurti string tipo metodą 
             * kuris gražina frazę pvz „Sveiki, Mantas“.
             
             * Išvesti šią frazę į konsolę.
             */

            Console.Write("Įveskite savo vardą: ");
            string vardas = Console.ReadLine();

            Console.WriteLine(Pasisveikinimas(vardas));
        }

        private static string Pasisveikinimas(string vardas)
        {
            return $"Sveiki, {vardas}";
        }
    }
}
