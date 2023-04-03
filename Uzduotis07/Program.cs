using System;

namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
             * 1 PUNKTAS
             * Liepkite vartotojui įvesti savo vardą ir amžių. 
             * Į ekraną išveskite: 
             * “Jūsų vardas {vardas}, o amžius {amžius}.”
             */

            Console.WriteLine("Įveskite savo vardą:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Įveskite savo amžių:");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Jūsų vardas: {vardas}, o amžius: {amzius}");
            Console.WriteLine();

            /*
             * 2 PUNKTAS
             * Liepkite vartotojui įvesti bet kokį simbolį. 
             * Atspausdinkite 3x3 kvadratą iš to simbolio.
             */

            Console.WriteLine("Įveskite bet kokį simbolį:");

            int simbolioASCIIKodas = Console.Read();
            Console.ReadLine(); // eilutė reikalinga, dėl vėlesnio įvedimo. Žiūrėti 2 paskaitą 29 skaidrę
            char simbolisKaipCharacter = Convert.ToChar(simbolioASCIIKodas);
            string simbolisKaipString = Convert.ToString(simbolisKaipCharacter);

            /*
            * Žemiau pateikiami priskyrimai (c ir s)
            * yra daromi tik tam, kad sutrumpinti kintamojo vardą
            * tam, kad vėliau atliekami veiksmai
            * būtų lengviau skaitomi
            */

            char c = simbolisKaipCharacter;
            string s = simbolisKaipString;

            Console.WriteLine("Pirmas variantas atspausdinti kvadratą:");
            Console.WriteLine($"{c}{c}{c}");
            Console.WriteLine($"{c}{c}{c}");
            Console.WriteLine($"{c}{c}{c}");
            Console.WriteLine();

            Console.WriteLine("Antras variantas atspausdinti kvadratą:");
            Console.WriteLine(Convert.ToString(c) + Convert.ToString(c) + Convert.ToString(c));
            Console.WriteLine(Convert.ToString(c) + Convert.ToString(c) + Convert.ToString(c));
            Console.WriteLine(Convert.ToString(c) + Convert.ToString(c) + Convert.ToString(c));
            Console.WriteLine();

            Console.WriteLine("Trečias variantas atspausdinti kvadratą:");
            Console.WriteLine(s + s + s);
            Console.WriteLine(s + s + s);
            Console.WriteLine(s + s + s);
            // Variantų gali būti ir daugiau...

            Console.WriteLine();

            /*
             * 3 PUNKTAS
             * Liepkite vartotojui įvesti bet kokį skaičių. 
             * Išveskite į ekraną šio skaičiaus kvadratą.
             */

            Console.WriteLine("Įveskite bet kokį skaičių:");

            string ivedimas = Console.ReadLine();
            int skaicius = Convert.ToInt32(ivedimas);

            Console.WriteLine($"Įvestas skaičius: '{skaicius}'");
            Console.WriteLine($"Šio skaičiaus kvadratas: '{skaicius * skaicius}'");
            Console.WriteLine($"Kitaip suskaičiuotas kvadratas: '{Math.Pow(skaicius, 2)}'");
            Console.WriteLine();

            /*
             * 4 PUNKTAS
             * Liepkite vartotojui įvesti tris skaičius. 
             * Išveskite visų šių skaičių 
             * sumą, skirtumą, sandaugą ir dalmenį, 
             * nurodant atliekamus veiksmus 
             * ir šių skaičių reikšmes ekrane. 
             * Pvz.:
             * 5 + 3 + 8 = 16
             * 5 - 3 - 8 = -6
             * ...
             */

            Console.WriteLine("Įveskite pirmą skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius1 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite pirmą skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius2 = Convert.ToInt32(ivedimas);

            Console.WriteLine("Įveskite pirmą skaičių:");
            ivedimas = Console.ReadLine();
            int skaicius3 = Convert.ToInt32(ivedimas);

            int suma = skaicius1 + skaicius2 + skaicius3;
            int skirtumas = skaicius1 - skaicius2 - skaicius3;
            int sandauga = skaicius1 * skaicius2 * skaicius3;
            double dalyba = (double)skaicius1 / skaicius2 / skaicius3;
            Console.WriteLine($"Buvo įvesti šie skaičiai: '{skaicius1}', '{skaicius2}' ir '{skaicius3}'");

            Console.WriteLine("Veiksmai su įvestais skaičiais:");
            Console.WriteLine($"{skaicius1} + {skaicius2} + {skaicius3} = {suma}");
            Console.WriteLine($"{skaicius1} - {skaicius2} - {skaicius3} = {skirtumas}");
            Console.WriteLine($"{skaicius1} * {skaicius2} * {skaicius3} = {sandauga}");
            Console.WriteLine($"{skaicius1} / {skaicius2} / {skaicius3} = {dalyba}");
        }
    }
}
