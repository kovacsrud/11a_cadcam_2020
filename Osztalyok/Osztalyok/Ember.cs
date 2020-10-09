using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    public class Ember
    {
        //adattagok, adatmezők
        private string nev;
        private int magassag;
        private int suly;
        private int szulev;

        //metódusok (függvények)
        public void Koszon(string koszones)
        {
            Console.WriteLine($"{koszones}, {nev} vagyok.");
        }

    }
}
