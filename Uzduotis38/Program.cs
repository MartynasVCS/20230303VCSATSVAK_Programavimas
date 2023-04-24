using System;

namespace Uzduotis38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sukurkite bazinę klasę Gyvunas 
             * su protected kintamaisiais 
             * ir paveldinčia klase Gyvate. 
             * 
             * Paveldinčioje klasėje turi būti metodas, 
             * kuris išveda visus klasės kintamuosius į ekraną.
             * 
             * Bazinės klasės konstruktorių panaudokite paveldinčioje klasėje.
             * 
             * Išveskite paveldinčios klasės kintamuosius į ekraną.
             */

            Gyvate zaltys = new Gyvate("Žaltys", 15, false);
            zaltys.Informacija();
        }
    }

    internal class Gyvunas
    {
        protected string pavadinimas { get; set; }
        protected int amzius { get; set; }

        protected Gyvunas(string pavadinimas, int amzius)
        {
            this.pavadinimas = pavadinimas;
            this.amzius = amzius;
        }

        public virtual void Informacija()
        {
            Console.WriteLine("Informacija apie gyvūną: ");
            Console.WriteLine($"   Pavadinimas: {pavadinimas}");
            Console.WriteLine($"   Amžius: {amzius}");
        }
    }

    internal class Gyvate : Gyvunas
    {
        internal bool arNuodinga { get; set; }

        internal Gyvate(string pavadinimas, int amzius, bool arNuodinga) : base(pavadinimas, amzius)
        {
            this.arNuodinga = arNuodinga;
        }

        public override void Informacija()
        {
            base.Informacija();
            Console.WriteLine($"   Ar nuodinga: {arNuodinga}");
            Console.WriteLine();
        }
    }
}
