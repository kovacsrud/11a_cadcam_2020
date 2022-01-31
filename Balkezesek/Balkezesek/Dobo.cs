using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    public class Dobo
    {
        public string Nev { get; set; }
        public int ElsoEv { get; set; }
        public int ElsoHonap { get; set; }
        public int ElsoNap { get; set; }
        public int UtolsoEv { get; set; }
        public int UtolsoHonap { get; set; }
        public int UtolsoNap { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Dobo(string sor)
        {
            var e = sor.Split(';');
            Nev = e[0];
            var elso = e[1].Split('-');
            ElsoEv = Convert.ToInt32(elso[0]);
            ElsoHonap= Convert.ToInt32(elso[1]);
            ElsoNap= Convert.ToInt32(elso[2]);
            var utolso = e[2].Split('-');
            UtolsoEv = Convert.ToInt32(utolso[0]);
            UtolsoHonap= Convert.ToInt32(utolso[1]);
            UtolsoNap= Convert.ToInt32(utolso[2]);
            Suly = Convert.ToInt32(e[3]);
            Magassag= Convert.ToInt32(e[4]);
        }

    }
}
