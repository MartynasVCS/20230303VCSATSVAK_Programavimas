using System;

namespace DemoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int skaicius = 5;
            int i = 0;

            // For atitikmuo užrašytas kaip while ciklas
            while (i < 11)
            {
                Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
                i++;
            }
            Console.WriteLine();

            i = 0;
            while (true)
            {
                Console.WriteLine("Kas čia vyksta?!?");
                i++;

                if (i > 10)
                {
                    break;
                }
            }
            Console.WriteLine();

            // Įvedimas su duomenų tipo apsauga
            int ivedimas = int.MinValue;
            while (ivedimas == int.MinValue)
            {
                Console.Write("Įveskite skaičių: ");

                try
                {
                    ivedimas = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Įvedėte ne skaičių, bandykite dar kartą.");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Įvedėte per didelį skaičių, bandykite dar kartą.");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            Console.WriteLine($"Įvestas skaičius: {ivedimas}");
        }
    }
}
