using System;

namespace StringReveresed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm kuvab kasutajanime tagurpidi

            Console.WriteLine("Sisesta oma eesnimi");
            string userfirstName = Console.ReadLine();

            for (int i = userfirstName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userfirstName[i]);
            }
        }

    }
}
