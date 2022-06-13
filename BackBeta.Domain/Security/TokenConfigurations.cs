using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Domain.Security
{
    public class TokenConfigurations
    {                   // publico
        public string Audience { get; set; }
                   // emissor
        public string Issuer { get; set; }
                 // tempo de validade
        public int Seconds { get; set; }

    }
}
