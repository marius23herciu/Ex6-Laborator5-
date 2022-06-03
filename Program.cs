using System;

namespace Ex6_Laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 6
            //Screiti un program care va numara vocalele dintr-un sir de caractere citit de
            //la tastatura.

            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            int vocale = NumerotareVocale(sir);
            Console.WriteLine($"Sirul introdus are {vocale} vocale.", vocale);
        }
        static int NumerotareVocale(string sir)
        {
            int rezultat = 0;
            string vocale = "aeiou";
            for (int i = 0; i < sir.Length; i++)
            {
                if (vocale.Contains(Char.ToLower(sir[i])))
                {
                    rezultat++;
                }
            }

            return rezultat;
        }
    }
}
