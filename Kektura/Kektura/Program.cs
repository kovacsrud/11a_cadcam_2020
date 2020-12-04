using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kektura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TuraSzakasz> teljestura = new List<TuraSzakasz>();
            try
            {
                var sorok = File.ReadAllLines("kektura.csv", Encoding.Default);
                var kezdomagassag = Convert.ToInt32(sorok[0]);


                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    TuraSzakasz turaszakasz;
                    var aktualisMagassag = kezdomagassag+Convert.ToInt32(e[3]) + Convert.ToInt32(e[4]);
                    if (i==1)
                    {
                        turaszakasz = new TuraSzakasz
                        {
                            Kiindulopont = e[0],
                            Vegpont = e[1],
                            SzakaszHossza = Convert.ToDouble(e[2]),
                            OsszEmelkedes = Convert.ToInt32(e[3]),
                            OsszLejtes = Convert.ToInt32(e[4]),
                            Pecsetelohely = e[5],
                            VegpontMagassag = aktualisMagassag
                        };
                    }
                    else
                    {
                        turaszakasz = new TuraSzakasz
                        {
                            Kiindulopont = e[0],
                            Vegpont = e[1],
                            SzakaszHossza = Convert.ToDouble(e[2]),
                            OsszEmelkedes = Convert.ToInt32(e[3]),
                            OsszLejtes = Convert.ToInt32(e[4]),
                            Pecsetelohely = e[5],
                            VegpontMagassag = aktualisMagassag + Convert.ToInt32(e[3]) + Convert.ToInt32(e[4])
                        };
                    }

                    


                    teljestura.Add(turaszakasz); ;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Feladat 3: Szakaszok száma:{teljestura.Count} db.");

            var turahossz = teljestura.Sum(x => x.SzakaszHossza);

            Console.WriteLine($"Feladat 4: A túra teljes hossza:{turahossz} km.");

            var legrovidebb = teljestura.Min(x => x.SzakaszHossza);

            var minszakasz = teljestura.Find(x => x.SzakaszHossza == legrovidebb);

            var minszakasz2 = teljestura.Find(x=>x.SzakaszHossza==teljestura.Min(y=>y.SzakaszHossza));

            Console.WriteLine($@"Feladat 5: A legrövidebb szakasz adatai:
               Kezdete:{minszakasz.Kiindulopont}
               Vége:{minszakasz.Vegpont}   
               Hossz:{minszakasz.SzakaszHossza} km  
                             ");

            foreach (var i in teljestura)
            {
                if (i.HianyosNev() && i.Pecsetelohely=="i")
                {
                    Console.WriteLine($"{i.Vegpont}");
                } else
                {
                    Console.WriteLine($"Nincs hiányos állomásnév!");
                }
                
            }



            Console.ReadKey();
        }
    }
}
