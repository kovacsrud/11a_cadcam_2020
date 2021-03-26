using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSUDH
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domain> domains = new List<Domain>();
            try
            {
                var sorok = File.ReadAllLines("csudh.txt",Encoding.Default);
                for (int i = 1; i < sorok.Length; i++)
                {
                    domains.Add(new Domain(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"3.feladat: Domainek száma:{domains.Count}");

            var elsoDomain = domains.First();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}.szint:{elsoDomain.GetDomain(i+1)}");
            }

            //foreach (var j in domains)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine($"{i + 1}.szint:{j.GetDomain(i + 1)}");
            //    }
            //    Console.WriteLine("------------------------------");
            //}

            try
            {
                FileStream fajl = new FileStream("table.html", FileMode.Create);
                StreamWriter sw = new StreamWriter(fajl, Encoding.Default);

                string htmlFajl = "<HTML><HEAD><TITLE>Domain lista</TITLE></HEAD>\n";
                htmlFajl += "<BODY>\n";
                htmlFajl += "<TABLE>\n";
                htmlFajl += "<TR>\n";
                htmlFajl += $"<TD>Sorszám</TD>";
                htmlFajl += $"<TD>Host domainneve</TD>";
                htmlFajl += $"<TD>Host IP címe </TD>";
                for (int i = 0; i < 5; i++)
                {
                    htmlFajl += $"<TD>{i+1}.szint</TD>";
                }
                htmlFajl += "</TR>\n";
                int sorszam = 1;

                foreach (var j in domains)
                {
                    htmlFajl += "<TR>\n";
                    htmlFajl += $"<TD>{sorszam}</TD>";
                    htmlFajl += $"<TD>{j.DomainName}</TD>";
                    htmlFajl += $"<TD>{j.IPAddress}</TD>";
                    for (int i = 0; i < 5; i++)
                    {
                        htmlFajl += $"<TD>{j.GetDomain(i+1)}</TD>";
                    }
                    htmlFajl += "</TR>\n";
                    sorszam++;

                }

                htmlFajl += "</TABLE>\n";
                htmlFajl += "</BODY></HTML>";

                sw.Write(htmlFajl);

                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}
