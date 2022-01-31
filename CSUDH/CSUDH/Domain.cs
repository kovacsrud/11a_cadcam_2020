using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSUDH
{
    public class Domain
    {
        public string DomainName { get; set; }
        public string IPAddress { get; set; }

        public Domain(string sor)
        {
            var e = sor.Split(';');
            DomainName = e[0];
            IPAddress = e[1];
        }

        public string GetDomain(int szint)
        {
            var szintek = DomainName.Split('.');
            Array.Reverse(szintek);

            if (szint>szintek.Length)
            {
                return "nincs";
            } else
            {
                return szintek[szint - 1];
            }

            
        }

    }
}
