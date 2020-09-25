using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szovegek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Műveletek string-ekkel
            string szoveg = "Valami szöveg";
            string masik = "valami SZöveg";

            Console.WriteLine(szoveg.ToUpper());
            Console.WriteLine(szoveg.ToLower());

            if (szoveg.ToUpper()==masik.ToUpper())
            {
                Console.WriteLine("Megegyeznek");
            } else
            {
                Console.WriteLine("Nem egyeznek meg");
            }

            //Adott szöveggek kezdődik-e?
            Console.WriteLine(szoveg.StartsWith("Val"));
            Console.WriteLine(szoveg.EndsWith("ami"));

            //Tartalmaz e a változó egy szöveget?
            Console.WriteLine(szoveg.Contains("ami"));

            //Szövegrész kiemelése
            string datum = "2020.09.19";
            Console.WriteLine(datum.Substring(5,2));
            Console.WriteLine(datum.Substring(0,4));

            string darabol = "egy;ketto;harom;negy";
            //A darabolás után egy tömbbe kerülnek az elemek
            var elemek = darabol.Split(';');

            for (int i = 0; i < elemek.Length; i++)
            {
                Console.WriteLine(elemek[i]);
            }

            szoveg = "VaLaMi sZöVeG";
            //Alakítsuk át a stringet úgy, hogy ami nagybetűs az 
            //kisbetűs legyen, és fordítva

            var szovegTomb = szoveg.ToCharArray();

            for (int i = 0; i < szovegTomb.Length; i++)
            {
                if (Char.IsUpper(szovegTomb[i]))
                {
                    szovegTomb[i] = Char.ToLower(szovegTomb[i]);
                }
                if (Char.IsLower(szovegTomb[i]))
                {
                    szovegTomb[i] = Char.ToUpper(szovegTomb[i]);
                }
            }

            szoveg = new string(szovegTomb);

            Console.WriteLine(szoveg);




            Console.ReadKey();
        }
    }
}
