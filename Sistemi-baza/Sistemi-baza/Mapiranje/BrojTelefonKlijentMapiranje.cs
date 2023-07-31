using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class BrojTelefonKlijentMapiranje:ClassMap<BrojTelefonKlijent>
    {
        public BrojTelefonKlijentMapiranje()
        {
            Table("BROJ_TELEFON_KLIJENT");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojTelefona).Column("BROJ_TELEFONA");

            References(x => x.Klijent).Column("KLIJENT_ID").LazyLoad();

        }
    }
}
