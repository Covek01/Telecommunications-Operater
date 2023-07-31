using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class PravnoLiceFakseviMapiranje:ClassMap<PravnoLiceFaksevi>
    {
        public PravnoLiceFakseviMapiranje()
        {
            Table("FAKS_PRAVNO_LICE");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojeviFaksa).Column("BROJ_FAKSA");

            References(x => x.PravnoLice).Column("PRAVNO_LICE_ID").LazyLoad();
        }
    }
}
