using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class TelefonskiBroj
    {
        public virtual int ID { get;  set; }
        public virtual String Broj { get; set; }
        public virtual int PrethodniMesec { get; set; }
        public virtual Telefonija Telefonija  { get; set;}

    }
}
