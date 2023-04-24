using System;

namespace Uzduotis37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sukurti klasę Salis su kintamaisiais: 
             *      Pavadinimas, 
             *      Prezidentas, 
             *      Plotas,  
             *      GyventojuSkaicius, 
             *      VidutinisAtlyginimas 
             *          ir masyvu Augimas, kur saugosime 5  metų rodmenis, 
             *          kiek gyventojų gimė kasmet.
             *          
             * Sukurti 4 skirtingus konstruktorius.
             * 
             * Klasės viduje sukurti metodą, 
             * kad išvestų visą informaciją apie šalį.
             * 
             * Susikurti 4 objektus, 
             * jiems priskirti reikšmes su skirtingais konstruktoriais 
             * ir naudojant sukurtą metodą išvesti kiekvienos šalies informaciją.
             * 
             * Klasės viduje sukurti void tipo metodą, 
             * kuris pagal duotą reikšmę iš consolės
             * (masyvo indeksą / elemento vietą masyve), 
             * išvestų į ekraną masyvo elemento reikšmę 
             * ir jei reikšmė didesnė už sekančią reikšmę (n + 1) - išvesti ir tą reikšmę.
             */

            Salis lietuva = new Salis();
            lietuva.Informacija();

            Salis latvija = new Salis("Latvija");
            latvija.Informacija();

            Salis estija = new Salis("Estija", 45.339);
            estija.Informacija();

            int[] augimas = { 5000, 4850, 4550, 5250, 5600 };
            Salis lenkija = new Salis(
                "Lenkija",
                new Zmogus("Martyn", "Pavardevič"),
                500.000,
                38000000,
                2500,
                augimas);
            lenkija.Informacija();
            lenkija.AugimoNtojiReiksme();
        }
    }

    internal class Zmogus
    {
        internal string vardas { get; set; }
        internal string pavarde { get; set; }

        internal Zmogus(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
        }
    }

    internal class Salis
    {
        string pavadinimas { get; }
        Zmogus prezidentas { get; set; }
        double plotas { get; set; }
        int gyventojuSkaicius { get; set; }
        int vidutinisAtlyginimas { get; set; }
        int[] augimas { get; set; }

        internal Salis()
        {

        }

        internal Salis(string pavadinimas)
        {
            this.pavadinimas = pavadinimas;
        }

        internal Salis(string pavadinimas, double plotas)
        {
            this.pavadinimas = pavadinimas;
            this.plotas = plotas;
        }

        internal Salis(string pavadinimas,
              Zmogus prezidentas,
              double plotas,
              int gyventojuSkaicius,
              int vidutinisAtlyginimas,
              int[] augimas)
        {
            this.pavadinimas = pavadinimas;
            this.prezidentas = prezidentas;
            this.plotas = plotas;
            this.gyventojuSkaicius = gyventojuSkaicius;
            this.vidutinisAtlyginimas = vidutinisAtlyginimas;
            this.augimas = augimas;
        }

        internal void AugimoNtojiReiksme()
        {
            Console.Write("Įveskite augimo masyvo reikšmės numerį: ");
            int n = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Augimo reikšmė(s): ");
            Console.Write($"{augimas[n]} ");

            if (n != augimas.Length - 1 && augimas[n] > augimas[n + 1])
            {
                Console.Write($"{augimas[n + 1]}");
            }
            Console.WriteLine();
        }

        internal void Informacija()
        {
            Console.WriteLine("Informacija apie šalį:");
            if (pavadinimas != null)
            {
                Console.WriteLine($"   Pavadinimas: {pavadinimas}");
            }
            if (plotas != 0.0)
            {
                Console.WriteLine($"   Plotas: {plotas}");
            }
            if (gyventojuSkaicius != 0)
            {
                Console.WriteLine($"   Gyventojų skaičius: {gyventojuSkaicius}");
            }
            if (vidutinisAtlyginimas != 0)
            {
                Console.WriteLine($"   Vidutinis atlyginimas: {vidutinisAtlyginimas}");
            }
            if (prezidentas != null && prezidentas.vardas != "" && prezidentas.pavarde != "")
            {
                Console.WriteLine($"   Prezidentas: {prezidentas.vardas} {prezidentas.pavarde}");
            }
            if (augimas != null)
            {
                Console.Write($"   Augimas: ");
                foreach (int skaicius in augimas)
                {
                    Console.Write($"{skaicius} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}