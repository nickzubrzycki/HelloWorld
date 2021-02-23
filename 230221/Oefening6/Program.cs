using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            int prijsvolwassene, prijstiener, prijskind, aantalvolwassenen, aantaltieners, aantalkinderen;
            prijsvolwassene = 35;
            prijstiener = 25;
            prijskind = 20;

            Console.WriteLine("Welkom in Kenland! Het tofste pretpark van de Benelux!");
            Console.Write("Aantal volwassenen: ");
            aantalvolwassenen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal tieners: ");
            aantaltieners = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal kinderen: ");
            aantalkinderen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"Prijs volwassenen: {prijsvolwassene} euro");
            Console.WriteLine($"Prijs tieners: {prijstiener} euro");
            Console.WriteLine($"Prijs kinderen: {prijskind} euro");

            Console.WriteLine();

            Console.WriteLine($"Totaal: {(aantalvolwassenen * prijsvolwassene) + (aantaltieners * prijstiener) + (aantalkinderen * prijskind)} euro");

            Console.ReadLine();
        }
    }
}
