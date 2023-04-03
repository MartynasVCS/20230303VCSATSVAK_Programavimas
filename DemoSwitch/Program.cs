using System;

namespace DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Lietuviškų raidžių įvedimas per console
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Įveskite gyvūno pavadinimą: ");
            string ivedimas = Console.ReadLine();
            Console.WriteLine(ivedimas);

            switch (ivedimas)
            {
                case "katė":
                    Console.WriteLine("Gyvūnas yra katė");
                    break;
                case "pelė":
                    Console.WriteLine("Gyvūnas yra pelė");
                    break;
                case "šuo":
                    Console.WriteLine("Gyvūnas yra šuo");
                    break;
                default:
                    Console.WriteLine("Gyvūnas kažkoks neaiškus");
                    break;
            }
        }
    }
}
