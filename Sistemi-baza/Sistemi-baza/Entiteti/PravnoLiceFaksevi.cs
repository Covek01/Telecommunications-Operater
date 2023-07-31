using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class PravnoLiceFaksevi
    {
        public virtual int ID { get; set; }
        public virtual PravnoLice PravnoLice { get; set; }
        public virtual String BrojeviFaksa { get; set; }
    }
}
