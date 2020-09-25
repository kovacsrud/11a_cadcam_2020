﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Műveletek string-ekkel
            string szoveg = "Valami szöveg";
            string masik = "valami SZöveg";

            Console.WriteLine(szoveg.ToUpper());
            Console.WriteLine(szoveg.ToLower());

            if (szoveg.ToUpper()==masik.ToUpper())
            {
                Console.WriteLine("Megegyeznek");
            } else
            {
                Console.WriteLine("Nem egyeznek meg");
            }

            //Adott szöveggek kezdődik-e?
            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.EndsWith("ami"));

            //Tartalmaz e a változó egy szöveget?
            Console.WriteLine(szoveg.Contains("ami"));

            //Szövegrész kiemelése
            string datum = "2020.09.19";
            Console.WriteLine(datum.Substring(5,2));
            Console.WriteLine(datum.Substring(0,4));




            Console.ReadKey();
        }
    }
}
