using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    public class Dolgozo
    {
        public string Nev { get; set; }
        public string Neme { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Dolgozo(string sor)
        {
            var adatok = sor.Split(';');
            Nev = adatok[0];
            Neme = adatok[1];
            Reszleg = adatok[2];
            Belepes = Convert.ToInt32(adatok[3]);
            Ber = Convert.ToInt32(adatok[4]);
        }
    }
}
