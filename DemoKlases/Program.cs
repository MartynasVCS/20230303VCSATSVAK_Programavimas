using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoKlases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zmogus zmogusPaulius = new Zmogus("Paulius");
            Zmogus zmogusPetras = new Zmogus("Petras", "Petrauskas", 33);

            Console.WriteLine(zmogusPaulius.vardas);
            Console.WriteLine(zmogusPetras.vardas);
            Console.WriteLine();
            Console.WriteLine(zmogusPaulius.vardas);
            Console.WriteLine(zmogusPetras.vardas);

            // zmogusPaulius.vardas = "Pauliukas"; // neleistinas veiksmas nes vardas neturi set'erio
            // zmogusPaulius.pavarde = "Paulauskas"; // neleistinas veiksmas nes pavardes set'eris yra private
            zmogusPaulius.Prisistatymas();
            zmogusPetras.Prisistatymas();

            zmogusPaulius.Atsisveikinimas(zmogusPetras);
            zmogusPaulius.AtsisveikinimasPagalNuotaika(zmogusPetras);
        }
    }

    internal class Zmogus
    {
        public string vardas { get; }
        public string pavarde { get; private set; }
        public int amzius;
        public List<string> nuotaikos = new List<string>() { "liūdnas", "piktas", "linksmas" };

        public Zmogus()
        {

        }

        public Zmogus(string vardas)
        {
            this.vardas = vardas;
        }

        public Zmogus(string vardas, string pavarde, int amzius)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.amzius = amzius;
        }

        private void KeistiDuomenis()
        {
            // vardas = "Kitas vardas"; // neleistinas veiksmas nes vardas neturi set'erio
            pavarde = "Kita pavarde"; 
        }

        public void Prisistatymas()
        {
            Console.WriteLine($"Labas, mano vardas {vardas}");
        }

        public void Atsisveikinimas()
        {
            Console.WriteLine("Viso gero");
        }

        public void Atsisveikinimas(Zmogus zmogus)
        {
            Console.WriteLine($"Viso gero, {zmogus.vardas}");
        }

        public string GautiAtsistiktineNuotaika()
        {
            Random generatorius = new Random();
            int nuotaikosIndeksas = generatorius.Next(0, nuotaikos.Count);
            return nuotaikos.ElementAt(nuotaikosIndeksas);
        }

        public void AtsisveikinimasPagalNuotaika(Zmogus zmogus)
        {
            string nuotaika = GautiAtsistiktineNuotaika();

            if (nuotaika == nuotaikos.ElementAt(0))
            {
                Console.WriteLine($"Ate {zmogus.vardas}");
            }
            else if (nuotaika == nuotaikos.ElementAt(1))
            {
                Console.WriteLine($"{zmogus.vardas}, eik...");
            }
            else if (nuotaika == nuotaikos.ElementAt(2))
            {
                Console.WriteLine($"Sėkmės {zmogus.vardas}!!!");
            }
            else
            {
                Console.WriteLine($"Ate, {zmogus.vardas}, nežinau kaip jaučiuosi.");
            }
        }
    }
}
