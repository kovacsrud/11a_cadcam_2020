using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember ubul = new Ember();
            

            ubul.Koszon("Mizu");

            Ember zeno = new Ember();

            zeno.Koszon("Csumi");

            Console.ReadKey();
        }
    }
}
