using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class Dodaje
    {
        public virtual int ID { get; set; }
        public virtual Televizija Televizija { get; set; }
        public virtual PaketKanala PaketKanala { get; set; }

    }
}
