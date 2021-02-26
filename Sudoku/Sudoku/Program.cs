using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Feladvany> feladvanyok = new List<Feladvany>();
            Random rand = new Random();

            try
            {
                var sorok = File.ReadAllLines("feladvanyok.txt",Encoding.Default);
                for (int i = 0; i < sorok.Length; i++)
                {
                    feladvanyok.Add(new Feladvany(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                                
            }

            Console.WriteLine(feladvanyok.Count);

            Console.Write("Kérem a feladvány méretét [4..9]:");
            int meret = Convert.ToInt32(Console.ReadLine());
            while (meret<4 || meret>9)
            {
                Console.Write("Rossz! Kérem a feladvány méretét [4..9]:");
                meret = Convert.ToInt32(Console.ReadLine());
            }

            var feladvanydb = feladvanyok.FindAll(x=>x.Meret==meret);

            Console.WriteLine($"{meret}x{meret} méretű feladványból {feladvanydb.Count} db található a fájlban.");

            var veletlenelem = feladvanydb.ElementAt(rand.Next(0,feladvanydb.Count));

            Console.WriteLine(veletlenelem.Kezdo);

            Console.ReadKey();
        }
    }
}
