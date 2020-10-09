﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ubul = new Ember("Ubul",178,78,1999);
            

            ubul.Koszon("Mizu");
            ubul.SetNev("Gerzson");
            ubul.Koszon("Hello");
            Console.WriteLine(ubul.GetMagassag());

            Ember zeno = new Ember("Zénó",169,81,2005);

            zeno.Koszon("Csumi");

            Tanulo tanulo = new Tanulo("Zoltán", "12/X", 189, 76);
            Console.WriteLine(tanulo.Nev);
            tanulo.Magassag = -179;
            Console.WriteLine(tanulo.Magassag);

            Tanulo tanulo2 = new Tanulo("Ödön", "11/q", 230, 79);

            Console.WriteLine(tanulo2.Magassag);

            Console.ReadKey();
        }
    }
}
