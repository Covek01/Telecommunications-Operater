using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class PaketKanalaMapiranje : ClassMap<PaketKanala>
    {
        public PaketKanalaMapiranje()
        {
            Table("PAKET_KANALA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");

            HasMany(x => x.Televizija).KeyColumn("PAKET_KANALA_ID").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Kanali).KeyColumn("PAKET_KANALA_ID").LazyLoad().Cascade.All().Inverse();

            //HasManyToMany(x => x.Televizija).Table("TELEVIZIJA_PAKET_KANALA")
            //                .ParentKeyColumn("PAKET_KANALA_ID")
            //                .ChildKeyColumn("TELEVIZIJA_ID")
            //                .Inverse()
            //                .Cascade.All();
        }
    }
}
