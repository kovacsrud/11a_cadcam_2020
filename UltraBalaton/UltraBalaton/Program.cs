using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraBalaton
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            try
            {
                var sorok = File.ReadAllLines("ub2017egyeni.txt", Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    versenyzok.Add(new Versenyzo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"3.feladat Egyéni indulók:{versenyzok.Count} fő.");
            var noi = versenyzok.FindAll(x=>x.Kategoria== "Noi" && x.Tavszazalek==100).Count;

            Console.WriteLine($"4.feladat Célba érkező női sportolók:{noi} fő.");

            Console.Write("Adja meg egy versenyző nevét:");
            var beNev = Console.ReadLine();

            var sportolo = versenyzok.Find(x=>x.VersenyzoNev==beNev);

            if (sportolo!=null)
            {
                Console.WriteLine("Indult egyéniben a versenyző? Igen");
                if (sportolo.Tavszazalek==100)
                {
                    Console.WriteLine("Teljesítette a teljes távot:Igen");
                } else
                {
                    Console.WriteLine("Teljesítette a teljes távot:Nem");
                }
                
            } else
            {
                Console.WriteLine("Indult egyéniben a versenyző? Nem");
            }


            Console.ReadKey();
        }
    }
}
