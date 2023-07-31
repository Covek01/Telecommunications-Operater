using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;
using FluentNHibernate.Mapping;

namespace Telekomunikacija.Mapiranje
{
    class UredjajMapiranje:ClassMap<Uredjaj>
    {
        public UredjajMapiranje()
        {
            Table("UREDJAJ");

            DiscriminateSubClassesOnColumn("TIP_UREDJAJA");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.SerijskiBroj).Column("SERIJSKI_BROJ");
            Map(x => x.NazivProizvodjaca).Column("PROIZVODJAC");
            Map(x => x.UpotrebaOd).Column("UPOTREBA_OD");
            Map(x => x.ZadnjiServis).Column("ZADNJI_SERVIS");
            Map(x => x.RazlogServisa).Column("RAZLOG_SERVISA");
        }

    }

    class GlavnaStanicaUredjajMapiranje:SubclassMap<GlavnaStanica>
    {
        public GlavnaStanicaUredjajMapiranje()
        {
            DiscriminatorValue("Glavna_stanica");

            Map(x => x.RegionalniHubFlag).Column("REGIONALNI_FLAG");
            Map(x => x.NazivRegiona).Column("NAZIV_REGIONA");

            HasMany(x => x.KomunikacioniCvorovi)
                .KeyColumn("GLAVNA_STANICA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();


        }
    }


    class KomunikacionuCvorUredjajMapiranje : SubclassMap<KomunikacioniCvor>
    {
        public KomunikacionuCvorUredjajMapiranje()
        {
            DiscriminatorValue("Komunikacioni_cvor");

            Map(x => x.Opis).Column("OPIS");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Ulica).Column("ULICA");
            Map(x => x.BrojZgrade).Column("BROJ");
            Map(x => x.TipVeze).Column("TIP_VEZE");

            References(x => x.Stanica).Column("GLAVNA_STANICA_ID").LazyLoad();

            HasMany(x => x.KlijentiPovezani)
                .KeyColumn("KOMUNIKACIONI_CVOR_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

        }
    }

}
