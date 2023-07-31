using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class Uredjaj
    {
        public virtual int ID { get; protected set; }
        public virtual String SerijskiBroj { get; set; }
        public virtual String NazivProizvodjaca { get; set; }
        public virtual DateTime? UpotrebaOd { get; set; }
        public virtual DateTime ZadnjiServis { get; set; }
        public virtual String RazlogServisa { get; set; }
        public virtual String Tip_uredjaja { get; set; }

    }

    public class GlavnaStanica:Uredjaj
    {
        public virtual IList<KomunikacioniCvor> KomunikacioniCvorovi { get; set; }
        public virtual char RegionalniHubFlag { get; set; }
        public virtual String NazivRegiona { get; set; }

    }

    public class KomunikacioniCvor : Uredjaj 
    {
        public virtual String Opis { get; set; }
        public virtual String Grad { get; set; }
        public virtual String Ulica { get; set; }
        public virtual int BrojZgrade { get; set; }
        public virtual String TipVeze { get; set; }
        public virtual GlavnaStanica Stanica { get; set; }
        public virtual IList<Klijent> KlijentiPovezani { get; set; }

    }

}
