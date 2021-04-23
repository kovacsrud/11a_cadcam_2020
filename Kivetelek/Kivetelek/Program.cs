using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.Write("A:");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.Write("B:");
                var b = Convert.ToInt32(Console.ReadLine());
                var c = a / b;
                Console.WriteLine($"C:{c}");
               
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Számot kell megadni a bevitelnél");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("A megadott érték túl nagy!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Nullával nem lehet osztani");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            

            Console.ReadKey();
        }
    }
}
