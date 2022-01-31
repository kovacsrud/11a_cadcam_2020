using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Munkavallalo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();

            //3 dolgozó bekérése - for

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Név:");
                var nev = Console.ReadLine();

                Console.Write("Munkakör:");
                var munkakor = Console.ReadLine();

                Console.Write("Születési év:");
                var szulev = Convert.ToInt32(Console.ReadLine());

                //Példány létrehozása
                Dolgozo dolgozo = new Dolgozo
                {
                    Nev = nev,
                    Munkakor = munkakor,
                    Szuletesiev = szulev
                };
                //példány hozzáadása a ciklushoz
                dolgozok.Add(dolgozo);
            }

            foreach (var i in dolgozok)
            {
                Console.WriteLine($"{i.Nev},{i.Munkakor},{i.Szuletesiev},{i.Eletkor()}");
            }

            var datum = DateTime.Now;
            
            Console.WriteLine(datum.Year);

            Console.ReadKey();
        }
    }
}
