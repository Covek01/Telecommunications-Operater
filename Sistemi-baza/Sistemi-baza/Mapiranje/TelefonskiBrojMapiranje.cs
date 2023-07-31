using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class TelefonskiBrojMapiranje:ClassMap<TelefonskiBroj>
    {
        public TelefonskiBrojMapiranje()
        {
            Table("TELEFONSKI_BROJ");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Broj).Column("BROJ");
            Map(x => x.PrethodniMesec).Column("PRETHODNI_MESEC");

            References(x => x.Telefonija).Column("TELEFONIJA_ID").LazyLoad();

        }

    }
}
