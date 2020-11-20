using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Hegycsucs> hegycsucsok = new List<Hegycsucs>();

            try
            {
                var sorok = File.ReadAllLines("hegyekMo.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    var e = sorok[i].Split(';');
                    hegycsucsok.Add(
                        new Hegycsucs
                        {
                            HegycsucsNeve = e[0],
                            Hegyseg = e[1],
                            Magassag = Convert.ToInt32(e[2])
                        }
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Feladat 3.{hegycsucsok.Count} hegy található.");

            var atlagmagassag = hegycsucsok.Average(x=>x.Magassag);
            Console.WriteLine($"A hegycsúcsok átlagos magassága:{atlagmagassag:0.00}");

            var legmagasabb = hegycsucsok.Find(x=>x.Magassag==hegycsucsok.Max(y=>y.Magassag));
            Console.WriteLine($"Név:{legmagasabb.HegycsucsNeve}," +
                $"Hegység:{legmagasabb.Hegyseg},"+
                $"Magasság:{legmagasabb.Magassag}");

            Console.Write("Kérek egy magasság értéket:");
            var bemagassag = Convert.ToInt32(Console.ReadLine());

            var vanemagasabb = hegycsucsok.Find(x=>x.Hegyseg=="Börzsöny" && x.Magassag>bemagassag);

            if (vanemagasabb==null)
            {
                Console.WriteLine($"Nincs {bemagassag}-nál magasabb hegycsúcs a Börzsönyben");
            } else
            {
                Console.WriteLine($"Van {bemagassag}-nál magasabb hegycsúcs a Börzsönyben");
            }

            var vane_magasabb = hegycsucsok.FindAll(x=>x.Hegyseg=="Börzsöny" && x.Magassag>bemagassag);

            if (vane_magasabb.Count==0)
            {
                Console.WriteLine($"Nincs {bemagassag}-nál magasabb hegycsúcs a Börzsönyben");
            } else
            {
                Console.WriteLine($"Van {bemagassag}-nál magasabb hegycsúcs a Börzsönyben");
            }

            var magas3000 = hegycsucsok.FindAll(x=>x.Magassag*3.28>3000).Count;

            Console.WriteLine($"3000 lábnál magasabb hegycsúcsok száma:{magas3000}");

            var stat = hegycsucsok.ToLookup(x=>x.Hegyseg);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key}-{i.Count()} db {i.Max(x=>x.Magassag)}");
            }

            var bukkvidek = hegycsucsok.FindAll(x=>x.Hegyseg=="Bükk-vidék");

            try
            {
                FileStream fajl = new FileStream("bukk-videk.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(fajl, Encoding.Default);

                writer.WriteLine("Hegycsúcs neve;Magasság láb");

                foreach (var i in bukkvidek)
                {
                    writer.WriteLine($"{i.HegycsucsNeve};{i.Magassag*3.28:0.0}");
                }

                writer.Close();
                Console.WriteLine("Kiírás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }


            Console.ReadKey();
        }
    }
}
