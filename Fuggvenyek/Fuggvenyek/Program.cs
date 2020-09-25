using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {
        static void Kiir()
        {
            Console.WriteLine("Valami, bármi, akármi");
        }

        //paraméteres függvény
        static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        static void Kiir(string szoveg,string szoveg2)
        {
            Console.WriteLine(szoveg+","+szoveg2);
        }

        //visszatérési értékkel rendelkező függvény
        static int Osszead(int a,int b)
        {
            return a + b;
        }

        static double Osszead(double a,double b)
        {
            return a + b;
        }

        //Overloading, túlterhelés : ugyanazzal a névvel
        //több függvényt is csinálhatunk, de visszatérési
        //értékben ill. paraméter listában különbözniük kell




        static void Main(string[] args)
        {
            Kiir();
            Kiir();
            Kiir("Hello");
            Kiir("végre péntek");
            Kiir("Izé", "öööö");
            var a = Osszead(10, 26);
            Console.WriteLine($"A:{a}");
            Console.WriteLine(Osszead(120, 441));
            Console.WriteLine(Osszead(12.56, 445.11788));

            int[] szamok = { 11, 23, 68, 775, 336, 77, 227, 883, 126, 1122, 997 };
            //Készítsen függvényt, amely egy tömb elemeit kiírja a képernyőre!

            TombLista(szamok);

            Console.ReadKey();
        }

        private static void TombLista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
        }
    }
}
