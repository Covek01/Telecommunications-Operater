using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class Usluga
    {
        public virtual int ID { get; protected set; }
        public virtual Ugovor Ugovor { get; set; }
        public virtual String Tip_usluge { get; set; }
    }

    public class Internet:Usluga
    {
        public virtual String TipPlacanja { get; set; }
        public virtual String TipPostpaid { get; set; }
        public virtual DateTime? DatumUplate { get; set; }
        public virtual int? Stanje { get; set; }
        public virtual int? DanPlacanja { get; set; }
        public virtual int? Potroseno { get; set; }
        public virtual double? CenaMB { get; set; }

        public virtual int? MesecnaCena { get; set; }
        public virtual String StatickaAdresa1 { get; set; }
        public virtual String StatickaAdresa2 { get; set; }

    }

    public class Telefonija : Usluga
    {
        public virtual IList<TelefonskiBroj> TelefonskiBrojevi { get; set; }

    }

    public class Televizija : Usluga
    {
        public virtual IList<Dodaje> PaketiKanala { get; set; }
    }


}
