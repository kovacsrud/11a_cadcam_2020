using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraBalaton
{
    public class Versenyzo
    {
        public string VersenyzoNev { get; set; }
        public int Rajtszam { get; set; }
        public string Kategoria { get; set; }
        public string Versenyido { get; set; }
        public int Tavszazalek { get; set; }

        public Versenyzo(string sor)
        {
            var e = sor.Split(';');
            VersenyzoNev = e[0];
            Rajtszam = Convert.ToInt32(e[1]);
            Kategoria = e[2];
            Versenyido = e[3];
            Tavszazalek = Convert.ToInt32(e[4]);

        }

        public double IdoOraban()
        {
            var e = Versenyido.Split(':');
            int ora = Convert.ToInt32(e[0]);
            int perc = Convert.ToInt32(e[1]);
            int masodperc = Convert.ToInt32(e[2]);

            var osszora = ((ora * 3600) + (perc * 60) + masodperc)/3600;
            return osszora;
        }
    }
}
