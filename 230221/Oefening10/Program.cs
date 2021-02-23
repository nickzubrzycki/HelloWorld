using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            double plus, min, maal, delen, rest;
            plus = getal1 + getal2;
            min = getal1 - getal2;
            maal = getal1 * getal2;
            delen = getal1 / getal2;
            rest = getal1 % getal2;

            Console.WriteLine($"{getal1} + {getal2} = {plus}");
            Console.WriteLine($"{getal1} - {getal2} = {min}");
            Console.WriteLine($"{getal1} * {getal2} = {maal}");
            Console.WriteLine($"{getal1} / {getal2} = {delen.ToString("0.#0")}");
            Console.WriteLine($"{getal1} / {getal2} = {Convert.ToInt32(delen)}, rest {rest}");

            Console.ReadLine();



        }
    }
}
