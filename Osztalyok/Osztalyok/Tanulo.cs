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
        private int magassag;
        public int Magassag {

            get { return magassag; }

            set
            {
                if(value>=100 && value<= 220)
                {
                    magassag = value;
                } else
                {
                    magassag = 165;
                }
            }

        }
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
