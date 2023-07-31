using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class Ugovor
    {
        public virtual int ID { get; set; }
        public virtual int BrojUgovora { get; set; }
        public virtual Klijent Klijent { get; set; }
        public virtual IList<Usluga> ObuhvaceneUsluge { get; set; }
    }
}
