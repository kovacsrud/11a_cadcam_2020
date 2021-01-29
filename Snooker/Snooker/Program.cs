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


            Console.ReadKey();
        }
    }
}
