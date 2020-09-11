using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Változók
            //változó:A memória egy része, melyet egy névvel
            //azonosítunk, ebben az adott típusnak megfelelő értéket tudunk tárolni.
            //Típusos nyelveknél a változó típusát is meg kell adni.

            //Számok
            //signed - előjeles
            int a = 25;
            a = 119;
            a = -119;

            Console.WriteLine($"Max:{Int32.MaxValue} Min{Int32.MinValue}");

            uint aa = 35;
                      

            Console.WriteLine($"Max:{UInt32.MaxValue} Min{UInt32.MinValue}");

            Console.ReadKey();
        }
    }
}
