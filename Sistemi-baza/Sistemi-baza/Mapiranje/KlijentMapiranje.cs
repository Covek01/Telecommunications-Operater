using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;
using FluentNHibernate.Mapping;
using FluentNHibernate.Conventions.Helpers;

namespace Telekomunikacija.Mapiranje
{
    class KlijentMapiranje : ClassMap<Klijent>
    {

        public KlijentMapiranje() 
        {
            Table("KLIJENT");

            DiscriminateSubClassesOnColumn("Tip_klijenta");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.BrojZgrade, "BROJ");
            //Map(x => x.Tip_klijenta, "Tip_klijenta");

            HasMany(x => x.PotpisaniUgovori).KeyColumn("KLIJENT_ID").LazyLoad().Cascade.All().Inverse();
            References(x => x.PovezanNaCvor).Column("KOMUNIKACIONI_CVOR_ID");
            HasMany(x => x.BrojeviTelefona).KeyColumn("KLIJENT_ID").LazyLoad().Cascade.All().Inverse();
        }

    }

    class FizickoLiceMapiranje : SubclassMap<FizickoLice>
    {
        public FizickoLiceMapiranje()
        {
            DiscriminatorValue("Fizicko");

            Map(x => x.JMBG, "JMBG");

        }
    }

    class PravnoLiceMapiranje : SubclassMap<PravnoLice>
    {
        public PravnoLiceMapiranje()
        {
            DiscriminatorValue("Pravno");

            Map(x => x.ImeKontakta, "IME_KONTAKTA");
            Map(x => x.PIB, "PIB");
            Map(x => x.MaticniBroj, "MATICNI_BROJ");

            HasMany(x => x.BrojeviFaks).KeyColumn("PRAVNO_LICE_ID").LazyLoad().Cascade.All().Inverse();
        }
    }

}
