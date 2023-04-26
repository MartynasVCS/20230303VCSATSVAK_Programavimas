using System;
using System.Collections.Generic;

namespace DemoSarasaiKonsultacija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> medziai = new List<string>();

            medziai.Add("klevas");
            medziai.Add("ąžuolas");
            medziai.Add("beržas");

            List<string> vardai = new List<string>() { "Martynas", "Aušra" };

            Console.WriteLine(medziai[0]);
            Console.WriteLine(medziai[1]);
            Console.WriteLine(medziai[2]);
            Console.WriteLine();

            for (int i = 0; i < medziai.Count;  i++)
            {
                Console.WriteLine(medziai[i]);
            }
            Console.WriteLine();

            foreach (string zodis in medziai)
            {
                Console.WriteLine(zodis);
            }
            Console.WriteLine();

            Spausdinimas(medziai);
            Spausdinimas(vardai);
        }

        static void Spausdinimas(List<string> zodziai)
        {
            foreach (string zodis in zodziai)
            {
                Console.WriteLine(zodis);
            }
            Console.WriteLine();
        }
    }
}
