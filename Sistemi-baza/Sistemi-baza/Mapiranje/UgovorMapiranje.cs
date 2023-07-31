using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Telekomunikacija.Mapiranje
{
    class UgovorMapiranje:ClassMap<Ugovor>
    {

        public UgovorMapiranje() 
        {
            Table("UGOVOR");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojUgovora).Column("BROJ_UGOVORA");

            References(x => x.Klijent).Column("KLIJENT_ID").LazyLoad();

            HasMany(x => x.ObuhvaceneUsluge)
                .KeyColumn("UGOVOR_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();


        }




    }
}
