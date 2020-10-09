using System;
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
            Ember ubul = new Ember();
            ubul.nev = "Ubul";
            ubul.magassag = 175;
            ubul.suly = 78;
            ubul.szulev = 1999;

            ubul.Koszon("Mizu");

            Ember zeno = new Ember();
            zeno.nev = "Zénó";
            zeno.magassag = 189;
            zeno.suly = 88;
            zeno.szulev = 2001;
            zeno.Koszon("Csumi");

            Console.ReadKey();
        }
    }
}
