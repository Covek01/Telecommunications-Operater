using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class BrojTelefonKlijent
    {
        public virtual int ID { get;  set; }
        public virtual String BrojTelefona { get; set; }
        public virtual Klijent Klijent { get; set; }

    }
}
