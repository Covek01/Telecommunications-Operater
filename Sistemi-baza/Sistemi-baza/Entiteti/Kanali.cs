using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class Kanali
    {
        public virtual int ID { get; set; }
        public virtual String ImeKanala { get; set; }
        public virtual PaketKanala PaketaKanala { get; set; }

    }
}
