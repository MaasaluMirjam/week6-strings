using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi
                 
            Console.WriteLine("Sisesta oma eesnimi");
            string userfirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userlastName = Console.ReadLine();

            if (userfirstName.Length > userlastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi.");
            }
            else if (userfirstName.Length < userlastName.Length)
            {
                Console.WriteLine("Sinu perekonnańimi on lühem kui eesnimi.");                 
            }
            else
            {
                Console.WriteLine("Sama pikad.");
            }
        }              
    }
}
