using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prijs van een drankje: ");
            double prijs = Convert.ToDouble(Console.ReadLine());
            Console.Write("Aantal drankjes: ");
            int aantal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prijs zonder btw: {prijs * aantal} euro");
            Console.WriteLine($"Prijs met 21% btw: {(prijs * aantal * 1.21).ToString("0.00")} euro");
            
            Console.ReadLine();
        }
    }
}
