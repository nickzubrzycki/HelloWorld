using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Voornaam: ");
            string Voornaam;
            Voornaam = Console.ReadLine();
            Console.Write("Naam: ");
            string Naam;
            Naam = Console.ReadLine();
            Console.Write("Straat: ");
            string Straat;
            Straat = Console.ReadLine();
            Console.Write("Nummer: ");
            string Nummer;
            Nummer = Console.ReadLine();
            Console.Write("Postcode: ");
            string Postcode;
            Postcode = Console.ReadLine();
            Console.Write("Stad: ");
            string Stad;
            Stad = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Naam: " + Voornaam + " " + Naam);
            Console.WriteLine("Adres: " + Straat + " " + Nummer + ", " + Postcode + " " + Stad);
            Console.ReadLine();




        }
    }
}
