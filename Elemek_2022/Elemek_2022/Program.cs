using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elemek_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elem> elemek = new List<Elem>();
            try
            {
                var sorok = File.ReadAllLines("felfedezesek.csv", Encoding.UTF8);

                for (int i = 1; i < sorok.Length; i++)
                {
                    elemek.Add(new Elem(sorok[i]));
                }

                Console.WriteLine("Kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
