using System;

namespace DemoIfSalyga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Programos pradžia");

            bool arTreciadienis = false;

            if (arTreciadienis) // arTreciadienis == true
            {
                Console.WriteLine("Šiandien trečiadienis");
            }

            int skaicius = 8;

            if (skaicius > 15)
            {
                Console.WriteLine("Skaičius didesnis už 10");
            } 
            else if (skaicius > 10) 
            {
                Console.WriteLine("Skaičius didesnis už 15");
            }
            else if (skaicius < 7)
            {
                Console.WriteLine("Skaičius mažesnis už 7");
            }
            else
            {
                Console.WriteLine("Sveiki gyvi");
            }

            // Klasikinis if (siūlau taip ir rašyti)
            if (skaicius > 6)
            {
                Console.WriteLine("Skaičius yra didesnis už 6");
            }


            if (skaicius > 6)
                Console.WriteLine("Skaičius yra didesnis už 6");


            Console.WriteLine("Programos pabaiga");
        }
    }
}
