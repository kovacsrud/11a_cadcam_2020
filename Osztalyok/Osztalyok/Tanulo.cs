using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
     public class Tanulo
    {
       

        public string Nev { get; set; }
        public string Osztalya { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public Tanulo(string nev, string osztalya, int magassag, int suly)
        {
            Nev = nev;
            Osztalya = osztalya;
            Magassag = magassag;
            Suly = suly;
        }
    }
}
