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

        //konstruktor metódus, az osztály példányosításakor
        //automatikusan lefut
        public Ember(string benev,int bemagassag,int besuly,int beszulev)
        {
            nev = benev;
            magassag = bemagassag;
            suly = besuly;
            szulev = beszulev;
        }


        //metódusok (függvények)
        public void Koszon(string koszones)
        {
            Console.WriteLine($"{koszones}, {nev} vagyok.");
        }

        public void SetNev(string ujnev)
        {
            nev = ujnev;
        }

        public int GetMagassag()
        {
            return magassag;
        }

    }
}
