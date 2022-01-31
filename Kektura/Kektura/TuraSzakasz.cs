using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kektura
{
    public class TuraSzakasz
    {
        public string Kiindulopont { get; set; }
        public string Vegpont { get; set; }
        public double SzakaszHossza { get; set; }
        public int OsszEmelkedes { get; set; }
        public int OsszLejtes { get; set; }
        public string Pecsetelohely  { get; set; }
        public int VegpontMagassag { get; set; }

        public bool HianyosNev()
        {
            if (Pecsetelohely=="i" && Vegpont.Contains("pecsetelohely"))
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
