using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class KanaliMapiranje:ClassMap<Kanali>
    {
        public KanaliMapiranje()
        {
            Table("KANALI_PAKET_KANALA");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.ImeKanala).Column("IME_KANALA");

            References(x => x.PaketaKanala).Column("PAKET_KANALA_ID").LazyLoad();
        }
    }
}
