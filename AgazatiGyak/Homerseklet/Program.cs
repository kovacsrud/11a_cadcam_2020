using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homerseklet
{
    class Program
    {
        public static double Celsius2Fahrenheit(double celsius)
        {
            var fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            Console.Write("Add meg a hőmérsékletet:");
            var homerseklet = Convert.ToDouble(Console.ReadLine());

            while (homerseklet!=-111)
            {
                //Itt használjuk a függvényt
                Console.WriteLine($"{homerseklet} celsius az {Celsius2Fahrenheit(homerseklet)}");
                Console.Write("Add meg a hőmérsékletet:");
                homerseklet = Convert.ToDouble(Console.ReadLine());
            }


            Console.ReadKey();
        }


    }
}
