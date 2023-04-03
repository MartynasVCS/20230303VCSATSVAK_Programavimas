using System;

namespace DemoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 5;
            
            // Standartinis ciklas, vidinis ciklo kintamasis (iteratorius) pavadinimu i, pradedame nuo 0, didiname vienetu
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
            }
            Console.WriteLine();

            // Iteratorius nebūtinai turi būti skaičius...
            for (string i = "a"; i != "aaaaaa"; i += "a")
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // Iteratoriaus keitimas nebūtinai turi būti aprašomas for ciklo aprašyme
            // Atsargiai, kad nesukurtumėte amžino ciklo
            for (int i = 0; i < 10;)
            {
                Console.WriteLine("Kas čia vyksta?!?");
                i++;
            }
            Console.WriteLine();

            for (int i = 0; i < 50; i += 5)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
