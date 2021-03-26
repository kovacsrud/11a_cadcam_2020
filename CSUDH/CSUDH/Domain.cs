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

    }
}
