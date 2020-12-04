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
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    teljestura.Add(
                        new TuraSzakasz
                        {
                            Kiindulopont=e[0],
                            Vegpont=e[1],
                            SzakaszHossza=Convert.ToDouble(e[2]),
                            OsszEmelkedes=Convert.ToInt32(e[3]),
                            OsszLejtes=Convert.ToInt32(e[4]),
                            Pecsetelohely=e[5]
                        }
                        );
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Feladat 3: Szakaszok száma:{teljestura.Count} db.");


            Console.ReadKey();
        }
    }
}
