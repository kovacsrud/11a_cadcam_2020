using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elem> elemek = new List<Elem>();
            try
            {
                var sorok = File.ReadAllLines("felfedezesek.csv", Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    elemek.Add(new Elem(sorok[i]));
                }

                Console.WriteLine("Kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Feladat 3: Az elemek száma:{elemek.Count}");

            var okori = elemek.FindAll(x => x.Ev == "Ókor").Count;
            Console.WriteLine($"Feladat 4: Ókorban:{okori}");

            string vegyjel = "";
            Console.WriteLine("Adjon meg egy vegyjelet!");
            vegyjel = Console.ReadLine();
            while (vegyjel.Length<1 || vegyjel.Length>2)
            {
                Console.WriteLine("Hibás vegyjel!");
                vegyjel = Console.ReadLine();
            }

            var keresett = elemek.Find(x => x.Vegyjel.ToLower() == vegyjel.ToLower());

            if (keresett == null)
            {
                Console.WriteLine("Nincs ilyen elem");
            } else
            {
                Console.WriteLine($@"
                Az elem vegyjele:{keresett.Vegyjel}
                Az elem neve:{keresett.Nev},
                Rendszáma:{keresett.Rendszam},
                Felfedezés éve:{keresett.Ev},
                Felfedező:{keresett.Felfedezo}
                ");
            }

            var okorutan = elemek.FindAll(x => x.Ev != "Ókor");

            int maxkulonbseg = 0;
            for (int i = 1; i < okorutan.Count; i++)
            {
                if (Convert.ToInt32(okorutan[i].Ev)-Convert.ToInt32(okorutan[i-1].Ev)>maxkulonbseg)
                {
                    maxkulonbseg = Convert.ToInt32(okorutan[i].Ev) - Convert.ToInt32(okorutan[i - 1].Ev);
                }
            }
           

            Console.ReadKey();
        }
    }
}
