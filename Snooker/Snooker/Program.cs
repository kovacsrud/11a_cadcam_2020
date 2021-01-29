using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            try
            {
                var sorok = File.ReadAllLines("snooker.txt",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    versenyzok.Add(new Versenyzo(sorok[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"3.feladat:A világranglistán {versenyzok.Count} versenyző szerepel.");

            var atlagkereset = versenyzok.Average(x => x.Nyeremeny);
            
            Console.WriteLine($"4.feladat: A versenyzők átlagosan {atlagkereset:0.00} fontot kerestek.");

            var kinai = versenyzok.FindAll(x=>x.Orszag=="Kína");
            var kinaimax = kinai.Find(x => x.Nyeremeny == kinai.Max(y => y.Nyeremeny));

            if (kinaimax!=null)
            {
                Console.WriteLine($@"5.feladat: A legjobban kereső kínai versenyző:
                    Helyezés:{kinaimax.Helyezes}
                    Név:{kinaimax.Nev}
                    Ország:{kinaimax.Orszag}
                    Nyeremény összege:{kinaimax.Nyeremeny*380} Ft");
            } else
            {
                Console.WriteLine("Nincs ilyen adat!");
            }

            var norveg = versenyzok.Find(x => x.Orszag == "Norvégia");

            if (norveg!=null)
            {
                Console.WriteLine("Feladat.6: A versenyzők között van norvég versenyző!");
            } else
            {
                Console.WriteLine("Feladat.6: A versenyzők között nincs norvég versenyző!");
            }

            //talán ez még jobb
            if (versenyzok.Any(x=>x.Orszag=="Norvégia"))
            {
                Console.WriteLine("Feladat.6: A versenyzők között van norvég versenyző!");
            } else
            {
                Console.WriteLine("Feladat.6: A versenyzők között nincs norvég versenyző!");
            }

            var statisztika = versenyzok.ToLookup(x=>x.Orszag);

            Console.WriteLine($"Feladat.7: Statisztika");

            foreach (var i in statisztika)
            {
                if (i.Count()>4)
                {
                    Console.WriteLine($"{i.Key},{i.Count()} fő.");
                }
                
            }

            Console.ReadKey();
        }
    }
}
