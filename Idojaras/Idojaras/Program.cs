using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        static void Main(string[] args)
        {
            //IdojarasAdat adat = new IdojarasAdat(2000, 12, 22, 11, 12.5, 13.5,14.5);
            //IdojarasAdat adat2 = new IdojarasAdat {
            //    Ev=2000,
            //    Honap=12,
            //    Nap=23,
            //    Ora=22,
            //    Homerseklet=12.6,
            //    Szelsebesseg=33.4,
            //    Paratartalom=0.9

            //};
            List<IdojarasAdat> idojarasadatok = new List<IdojarasAdat>();

            try
            {
                var sorok = File.ReadAllLines("idojaras.csv",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    IdojarasAdat adat = new IdojarasAdat(
                        Convert.ToInt32(e[0]),
                        Convert.ToInt32(e[1]),
                        Convert.ToInt32(e[2]),
                        Convert.ToInt32(e[3]),
                        Convert.ToDouble(e[4]),
                        Convert.ToDouble(e[5]),
                        Convert.ToDouble(e[6])
                        );
                    idojarasadatok.Add(adat);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }

            Console.WriteLine($"Elemek száma:{idojarasadatok.Count}");

            var ev2016 = idojarasadatok.FindAll(x=>x.Ev==2016 && x.Honap==11).Average(x=>x.Homerseklet);

            Console.Write("Adjon meg egy évet:");
            var beev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy hónapot:");
            var behonap= Convert.ToInt32(Console.ReadLine());
            Console.Write("Adjon meg egy napot:");
            var benap = Convert.ToInt32(Console.ReadLine());

            var eredmeny = idojarasadatok.FindAll(x=>x.Ev==beev && x.Honap==behonap && x.Nap==benap);

            foreach (var i in eredmeny)
            {
                Console.WriteLine($"{i.Ev}-{i.Honap}-{i.Nap} {i.Homerseklet}");
            }

            var egynap = idojarasadatok.Find(x => x.Ev == 2005);

            if (egynap==null)
            {
                Console.WriteLine("Nincs ilyen adat!");
            } else
            {
                Console.WriteLine($"{egynap.Ev}-{egynap.Honap}-{egynap.Nap} {egynap.Homerseklet}");
            }

            

            Console.ReadKey();
        }
    }
}
