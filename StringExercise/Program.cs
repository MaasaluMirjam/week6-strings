using System;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";

            //programm kuavb sõna esimest ja viimast tähte

            //kuvame esimest tähte
            Console.WriteLine(helloWorld[0]);
            //kuvame viimast tähte
            Console.WriteLine(helloWorld[helloWorld.Length - 1]);
        }
    }
}
