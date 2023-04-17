using System;

namespace Uzduotis18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Pradiniai duomenys
            int darboValandosPerDiena = 8;

            // Įvedimas
            Console.WriteLine("Įveskite kiek kepalų vienas darbuotojas gali iškepti per vieną valandą:");
            string ivedimas = Console.ReadLine();
            double kepalaiPerValandaDarbuotojo = Convert.ToDouble(ivedimas);

            Console.WriteLine("Įveskite kiek darbuotojų yra kepykloje");
            ivedimas = Console.ReadLine();
            int darbuotojuSkaicius = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite vieno kepalo savikainą:");
            ivedimas = Console.ReadLine();
            double kepaloSavikaina = Convert.ToDouble(ivedimas);

            Console.WriteLine("Įveskite vieno kepalo pardavimo kainą:");
            ivedimas = Console.ReadLine();
            double kepaloKaina = Convert.ToDouble(ivedimas);

            Console.WriteLine("Įveskite dienos užsakymų skaičių:");
            ivedimas = Console.ReadLine();
            int uzsakymai = Convert.ToInt32(ivedimas);

            // Skaičiavimai
            double kepalaiPerDiena = kepalaiPerValandaDarbuotojo * darboValandosPerDiena * darbuotojuSkaicius;
            double pajegumuIrPoreikioSkirtumas = kepalaiPerDiena - uzsakymai;

            // Paskaičiuojamas įmanomas patenkinti poreikis
            double imanomasPatenkintiPoreikis;
            if (pajegumuIrPoreikioSkirtumas < 0) imanomasPatenkintiPoreikis = kepalaiPerDiena;
            else imanomasPatenkintiPoreikis = uzsakymai;

            double kepaloPelnas = kepaloKaina - kepaloSavikaina;
            double bendrasPelnas = kepaloPelnas * imanomasPatenkintiPoreikis;

            // Išvedimas
            Console.WriteLine();
            Console.WriteLine("Kepyklos pajėgumai:");
            Console.WriteLine($"   Darbuotojų skaičius - {darbuotojuSkaicius}");
            Console.WriteLine($"   Darbo valandos      - {darboValandosPerDiena}");
            Console.WriteLine($"   Kepėjų greitis      - {kepalaiPerValandaDarbuotojo} (kepalų per valandą)");
            Console.WriteLine($"   Kepalai per dieną   - {kepalaiPerDiena}");
            Console.WriteLine();

            Console.WriteLine("Poreikio patenkinimas:");
            Console.WriteLine($"   Įmanoma pagaminti kepalų per dieną  - {kepalaiPerDiena}");
            Console.WriteLine($"   Kepalų užsakymų skaičius per dieną  - {uzsakymai}");
            if (pajegumuIrPoreikioSkirtumas < 0)
            {
                Console.Write($"   Trūkumas poreikiui patenkinti       - ");
            }
            else
            {
                Console.Write($"   Neišpildomi pajėgumai               - ");
            }
            Console.WriteLine(Math.Abs(pajegumuIrPoreikioSkirtumas));
            Console.WriteLine();

            Console.WriteLine("Pelningumas:");
            Console.WriteLine($"   Kepalų užsakymų skaičius per dieną  - {uzsakymai}");
            Console.WriteLine($"   Įmanomas patenkinti poreikis        - {imanomasPatenkintiPoreikis}");
            Console.WriteLine($"   Kepalo savikaina                    - {kepaloSavikaina}");
            Console.WriteLine($"   Kepalo pardavimo kaina              - {kepaloKaina}");
            Console.WriteLine($"   Vieno kepalo pelnas                 - {kepaloPelnas}");
            Console.WriteLine($"   Bendras pelnas                      - {bendrasPelnas}");
            Console.WriteLine();
        }
    }
}
