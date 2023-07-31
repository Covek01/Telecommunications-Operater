using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telekomunikacija.Entiteti
{
    public class Klijent
    {
        public virtual int ID { get; protected set; }
        public virtual String Ime { get; set; }
        public virtual String Grad { get; set; }
        public virtual String Ulica { get; set; }
        public virtual int BrojZgrade { get; set; }
        public virtual String Tip_klijenta { get; set; }
        public virtual IList<Ugovor> PotpisaniUgovori { get; set; }
        public virtual KomunikacioniCvor PovezanNaCvor { get; set; }
        public virtual IList<BrojTelefonKlijent> BrojeviTelefona { get; set; }
    }

    public class FizickoLice:Klijent
    { 
        public virtual String JMBG { get; set; }

    }

    public class PravnoLice : Klijent
    {
        public virtual String ImeKontakta { get; set; }
        public virtual String MaticniBroj { get; set; }
        public virtual String PIB { get; set; }
        public virtual IList<PravnoLiceFaksevi> BrojeviFaks { get;set; }


    }




}
