using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class PaketKanala
    {
        public virtual int  ID { get; set; }
        public virtual String Ime { get; set; }
        public virtual IList<Dodaje> Televizija { get; set; }
        public virtual IList<Kanali> Kanali {  get; set; }

    }
}
