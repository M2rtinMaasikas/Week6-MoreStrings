using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasitades tema initsiaale
            //initsiaalid lõpevad punktiga
            //--> Harry Potter -->H. P.

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName[0]}. {lastName[0]}.");


        }
    }
}
