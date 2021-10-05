using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada kasutajal tema eesnime
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Palun sisesta oma eesnimi");
            string firstname = Console.ReadLine();
            
            Console.WriteLine(firstname[0]);

            int firstnamelength = firstname.Length;
            Console.WriteLine($"Teie nimi on {firstnamelength} sümbolit pikk");

            //viimase tähe indeks
            Console.WriteLine(firstname[firstnamelength-1]);
        }
    }
}
