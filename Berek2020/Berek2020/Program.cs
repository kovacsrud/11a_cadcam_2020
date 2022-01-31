using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();
            try
            {
                var sorok = File.ReadAllLines("berek2020.txt", Encoding.UTF8);
                for (int i = 1; i < sorok.Length; i++)
                {
                    dolgozok.Add(new Dolgozo(sorok[i]));

                }
                Console.WriteLine("Kész");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat: Dolgozók száma:{dolgozok.Count} fő");


            var atlagber = dolgozok.Average(x=>x.Ber);
            Console.WriteLine($"4.feladat:Bérek átlaga:{atlagber/1000:0.0} eFt");

            var reszlegNev = "";
            Console.Write("5.feladat: Kérem egy részleg nevét:");
            reszlegNev = Console.ReadLine();

            var reszlegAdatok = dolgozok.FindAll(x => x.Reszleg.ToLower() == reszlegNev.ToLower());

            if (reszlegAdatok.Count > 0)
            {
                var legtobbetKereso = reszlegAdatok.Find(x=>x.Ber==reszlegAdatok.Max(y=>y.Ber));
                Console.WriteLine($@"6.feladat: A legtöbbet kereső a megadott részlegen:
                Név:{legtobbetKereso.Nev}
                Neme:{legtobbetKereso.Neme}
                Belépés éve:{legtobbetKereso.Belepes}
                Bér:{legtobbetKereso.Ber} Forint");

            } else
            {
                Console.WriteLine("Nincs ilyen részleg!");
            }

            var statisztika = dolgozok.ToLookup(x=>x.Reszleg).OrderBy(x=>x.Key);

            foreach (var i in statisztika)
            {
                Console.WriteLine($"{i.Key},{i.Count()} fő");
            }

            

            Console.ReadKey();
        }
    }
}
