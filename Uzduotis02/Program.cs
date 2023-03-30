using System;

namespace Uzduotis02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Paprastas budas
            string startLine = "---------------------";
            string emptyLine = "|                   |";
            string name = "Martynas";
            Console.WriteLine(startLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine("|    Mano vardas    |");
            Console.WriteLine("|      " + name + "     |");
            Console.WriteLine(emptyLine);
            Console.WriteLine(emptyLine);
            Console.WriteLine(startLine);
            Console.WriteLine();

            // Sudetingesnis budas (naudojami for ciklai)
            int eilutesIlgis = 25;
            string pasisveikinimas = "Sveiki, mano vardas yra";
            string vardas = "Martynas";
            PradziosPabaigosEilute(eilutesIlgis);
            TusciaEilute(eilutesIlgis);
            TusciaEilute(eilutesIlgis);
            EiluteSuTekstu(eilutesIlgis, pasisveikinimas);
            EiluteSuTekstu(eilutesIlgis, vardas);
            TusciaEilute(eilutesIlgis);
            TusciaEilute(eilutesIlgis);
            PradziosPabaigosEilute(eilutesIlgis);
        }

        // Metodas atspausdinantis tuscia eilute pagal uzduota ilgi
        internal static void TusciaEilute(int eilutesIlgis)
        {
            Console.Write("|");
            for (int i = 0; i < eilutesIlgis; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }

        // Metodas atspausdinantis pradzios/pabaigos eilute pagal uzduota ilgi
        internal static void PradziosPabaigosEilute(int eilutesIlgis)
        {
            for (int i = 0; i < eilutesIlgis + 2; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        // Metodas atspausdinantis eilute su tekstu
        internal static void EiluteSuTekstu(int ilgis, string tekstas)
        {
            int abiejuTarpuIlgis = ilgis - tekstas.Length;
            int tarpasKaireje = abiejuTarpuIlgis / 2;
            int tarpasDesineje = abiejuTarpuIlgis / 2 + abiejuTarpuIlgis % 2;

            Console.Write("|");
            for (int i = 0; i < tarpasKaireje; i++)
            {
                Console.Write(" ");
            }

            Console.Write(tekstas);

            for (int i = 0; i < tarpasDesineje; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
    }
}
