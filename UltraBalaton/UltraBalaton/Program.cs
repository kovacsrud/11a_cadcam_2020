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

            //foreach (var i in versenyzok)
            //{
            //    Console.WriteLine($"{i.VersenyzoNev},{i.IdoOraban():0.00}");
            //}

            var ferfiAtlag = versenyzok.FindAll(x=>x.Kategoria=="Ferfi" && x.Tavszazalek==100).Average(x=>x.IdoOraban());
            Console.WriteLine($"7.feladat Átlagos idő:{ferfiAtlag:0.00} óra.");

            var ferfiak = versenyzok.FindAll(x=>x.Kategoria=="Ferfi" && x.Tavszazalek==100);
            var nok = versenyzok.FindAll(x => x.Kategoria == "Noi" && x.Tavszazalek==100);

            var gyoztesFerfi = ferfiak.Find(x=>x.IdoOraban()==ferfiak.Min(y=>y.IdoOraban()));

            var gyoztesNo = nok.Find(x=>x.IdoOraban()==nok.Min(y=>y.IdoOraban()));

            

            Console.WriteLine($@"8.feladat: A verseny győztesei:
            Nők:{gyoztesNo.VersenyzoNev},({gyoztesNo.Rajtszam}.),{gyoztesNo.Versenyido}
            Férfiak:{gyoztesFerfi.VersenyzoNev},({gyoztesFerfi.Rajtszam}.),{gyoztesFerfi.Versenyido}");
            

            Console.ReadKey();
        }
    }
}
