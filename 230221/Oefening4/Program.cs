using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Achternaam: ");
            string achternaam = Console.ReadLine();
            Console.Write("Adres: ");
            string adres = Console.ReadLine();
            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();
            Console.Write("Hobby's: ");
            string hobbys = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Dag {voornaam} {achternaam}! jij woont op {adres}, {postcode}. Jouw hobby's zijn {hobbys}");

            Console.ReadLine();

        }
    }
}
