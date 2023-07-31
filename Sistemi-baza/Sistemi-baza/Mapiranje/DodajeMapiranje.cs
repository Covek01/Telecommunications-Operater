using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class DodajeMapiranje:ClassMap<Dodaje>
    {
        public DodajeMapiranje()
        {
            Table("TELEVIZIJA_PAKET_KANALA");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            References(x => x.Televizija).Column("TELEVIZIJA_ID").LazyLoad();

            References(x => x.PaketKanala).Column("PAKET_KANALA_ID").LazyLoad();
        
        }
    }
}
