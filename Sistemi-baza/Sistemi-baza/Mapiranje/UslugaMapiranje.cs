using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Mapiranje
{
    class UslugaMapiranje:ClassMap<Usluga>
    {
        public UslugaMapiranje() 
        {
            Table("USLUGA");

            DiscriminateSubClassesOnColumn("TIP_USLUGE");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            References(x => x.Ugovor).Column("UGOVOR_ID").LazyLoad();

        }
    }

    class InternetUslugaMapiranje:SubclassMap<Internet>
    {
        public InternetUslugaMapiranje()
        {
            DiscriminatorValue("Internet");

            Map(x => x.TipPlacanja).Column("TIP_PLACANJA");
            Map(x => x.TipPostpaid).Column("TIP_POSTPAID");
            Map(x => x.DatumUplate).Column("DATUM_UPLATE");
            Map(x => x.Stanje).Column("STANJE");
            Map(x => x.DanPlacanja).Column("DAN_PLACANJA");
            Map(x => x.Potroseno).Column("POTROSENO");
            Map(x => x.CenaMB).Column("CENA_MB");
            Map(x => x.MesecnaCena).Column("MESECNA_CENA");
            Map(x => x.StatickaAdresa1).Column("STATICKA_ADRESA1");
            Map(x => x.StatickaAdresa2).Column("STATICKA_ADRESA2");

        }
    }

    class TelefonijaUslugaMapiranje:SubclassMap<Telefonija>
    {
        public TelefonijaUslugaMapiranje()
        {
            DiscriminatorValue("Telefonija");

            HasMany(x => x.TelefonskiBrojevi)
                .KeyColumn("TELEFONIJA_ID")
                .LazyLoad()
            
                .Cascade.All()
                .Inverse();
        }
    }

    class TelevizijaUslugaMapiranje:SubclassMap<Televizija>
    {
        public TelevizijaUslugaMapiranje()
        {
            DiscriminatorValue("Televizija");

            HasMany(x => x.PaketiKanala)
                .KeyColumn("TELEVIZIJA_ID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            //HasManyToMany(x => x.PaketiKanala).Table("TELEVIZIJA_PAKET_KANALA")
            //                .ParentKeyColumn("TELEVIZIJA_ID")
            //                .ChildKeyColumn("PAKET_KANALA_ID")
            //                .Inverse()
            //                .Cascade.All();
        }
    }
}
