using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.DTO
{
    #region Ugovor
    public class UgovorPregled
    {
        public int Id { get; set; }
        public int BrojUgovora { get; set; }

        public UgovorPregled(Ugovor u) 
        {
            this.Id = u.ID;
            this.BrojUgovora=u.BrojUgovora;
        }
        public UgovorPregled()
        {
            
        }
    }

    public class UgovorBasic : UgovorPregled
    {
        public virtual KlijentBasic Klijent { get; set; }
        public virtual List<UslugaBasic> ObuhvaceneUsluge { get; set; }

        public UgovorBasic(Ugovor u) : base(u)
        {
            this.Klijent = new KlijentBasic(u.Klijent);
            this.ObuhvaceneUsluge = new List<UslugaBasic>(u.ObuhvaceneUsluge.Count);
            for(int i=0;i<u.ObuhvaceneUsluge.Count;i++)
            {
                this.ObuhvaceneUsluge[i] = new UslugaBasic(u.ObuhvaceneUsluge[i]);
            }
        }
        public UgovorBasic():base()
        {
            
        }
    }
    public class UgovorSaUslugama
    {
        public UgovorPregled ugovor { get; set; }
        public List<string> usluge { get; set; }
    }

    #endregion Ugovor
    #region Klijent

    public class KlijentPregled
    {
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Grad { get; set; }
        public string Ulica { get; set; }
        public int BrojZgrade { get; set; }
        public string Tip { get; set; }

        public KlijentPregled(Klijent k)
        {
            this.Id = k.ID;
            this.Ime = k.Ime;
            this.Grad = k.Grad;
            this.Ulica = k.Ulica;
            this.BrojZgrade = k.BrojZgrade;
            this.Tip = k.Tip_klijenta;
        }

        public KlijentPregled()
        {
            
        }
    }

    public class KlijentBasic : KlijentPregled
    {
        public virtual IList<UgovorBasic> PotpisaniUgovori { get; set; }
        public virtual KomunikacioniCvorBasic PovezanNaCvor { get; set; }
        public virtual IList<BrojTelefonKlijentBasic> BrojeviTelefona { get; set; }

        public KlijentBasic(Klijent k) : base(k)
        {
            this.PotpisaniUgovori= new List<UgovorBasic>(k.PotpisaniUgovori.Count);
            for (int i = 0; i < k.PotpisaniUgovori.Count;i++)
                this.PotpisaniUgovori[i] = new UgovorBasic(k.PotpisaniUgovori[i]);

            this.PovezanNaCvor = new KomunikacioniCvorBasic(k.PovezanNaCvor);

            this.BrojeviTelefona = new List<BrojTelefonKlijentBasic>(k.BrojeviTelefona.Count);
            for (int i = 0; i < k.BrojeviTelefona.Count; i++)
                this.BrojeviTelefona[i] = new BrojTelefonKlijentBasic(k.BrojeviTelefona[i]);
        }


        public KlijentBasic():base()
        {
            
        }
    }

    public class BrojTelefonKlijentPregled
    {
        public int Id { get; set; }
        public string BrojTelefona { get; set; }

        public BrojTelefonKlijentPregled(BrojTelefonKlijent b)
        {
            this.Id = b.ID;
            this.BrojTelefona= b.BrojTelefona;
        }

        public BrojTelefonKlijentPregled()
        {
            
        }
    }
    public class BrojTelefonKlijentBasic : BrojTelefonKlijentPregled
    {
        public virtual KlijentBasic Klijent { get; set; }

        public BrojTelefonKlijentBasic(BrojTelefonKlijent b) : base(b)
        {
            this.Klijent = new KlijentBasic(b.Klijent);
        }

        public BrojTelefonKlijentBasic():base()
        {
            
        }
    }
    #endregion Klijent
    #region FizickoLice

    public class FizickoLicePregled : KlijentPregled
    {
        public string JMBG { get; set; }

        public FizickoLicePregled(FizickoLice f) : base(f)
        {
            this.JMBG = f.JMBG;
        }
        public FizickoLicePregled()
        {
            
        }
    }

    public class FizickoLiceBasic : FizickoLicePregled
    {
        public virtual IList<UgovorBasic> PotpisaniUgovori { get; set; }
        public virtual KomunikacioniCvorBasic PovezanNaCvor { get; set; }
        public virtual IList<BrojTelefonKlijentBasic> BrojeviTelefona { get; set; }
    
        public FizickoLiceBasic(FizickoLice f) : base(f)
        {
            this.PotpisaniUgovori= new List<UgovorBasic>(f.PotpisaniUgovori.Count);
            for (int i = 0; i < f.PotpisaniUgovori.Count; i++)
                this.PotpisaniUgovori[i] = new UgovorBasic(f.PotpisaniUgovori[i]);

            this.PovezanNaCvor = new KomunikacioniCvorBasic(f.PovezanNaCvor);

            this.BrojeviTelefona = new List<BrojTelefonKlijentBasic>(f.BrojeviTelefona.Count);
            for (int i = 0; i < f.BrojeviTelefona.Count; i++)
                this.BrojeviTelefona[i] = new BrojTelefonKlijentBasic(f.BrojeviTelefona[i]);
        }

        public FizickoLiceBasic():base()
        {
            
        }
    }



    #endregion FizickiLice

    #region PravnoLice

    public class PravnoLicePregled : KlijentPregled
    {
        public string ImeKontakta { get; set; }
        public string MaticniBroj { get; set; }
        public string PIB { get; set; }



        public PravnoLicePregled(PravnoLice l):base(l)
        {
                this.ImeKontakta= l.ImeKontakta;
            this.MaticniBroj = l.MaticniBroj;
            this.PIB = l.PIB;
        }

        public PravnoLicePregled()
        {
            
        }
    }

    public class PravnoLiceBasic : PravnoLicePregled
    {
        public virtual IList<PravnoLiceFakseviBasic> BrojeviFaks { get; set; }
        public virtual IList<UgovorBasic> PotpisaniUgovori { get; set; }
        public virtual KomunikacioniCvorBasic PovezanNaCvor { get; set; }
        public virtual IList<BrojTelefonKlijentBasic> BrojeviTelefona { get; set; }


        public PravnoLiceBasic(PravnoLice p) : base(p)
        {
            this.BrojeviFaks = new List<PravnoLiceFakseviBasic>(p.BrojeviFaks.Count);
            for (int i = 0; i < p.BrojeviFaks.Count; i++)
                this.BrojeviFaks[i] = new PravnoLiceFakseviBasic(p.BrojeviFaks[i]);

            this.PotpisaniUgovori = new List<UgovorBasic>(p.PotpisaniUgovori.Count);
            for (int i = 0; i < p.PotpisaniUgovori.Count; i++)
                this.PotpisaniUgovori[i] = new UgovorBasic(p.PotpisaniUgovori[i]);

            this.PovezanNaCvor = new KomunikacioniCvorBasic(p.PovezanNaCvor);

            this.BrojeviTelefona = new List<BrojTelefonKlijentBasic>(p.BrojeviTelefona.Count);
            for (int i = 0; i < p.BrojeviTelefona.Count; i++)
                this.BrojeviTelefona[i] = new BrojTelefonKlijentBasic(p.BrojeviTelefona[i]);
        }

        public PravnoLiceBasic():base()
        {

        }
    }

    public class PravnoLiceFakseviPregled
    {
        public int Id { get; set; }
        public string BrojeviFaksa { get; set; }

        public PravnoLiceFakseviPregled(PravnoLiceFaksevi p)
        {
            this.Id = p.ID;
            this.BrojeviFaksa = p.BrojeviFaksa;
        }
        public PravnoLiceFakseviPregled()
        {
            
        }

    }
    public class PravnoLiceFakseviBasic : PravnoLiceFakseviPregled
    {
        public virtual PravnoLiceBasic PravnoLice { get; set; }

        public PravnoLiceFakseviBasic(PravnoLiceFaksevi p) : base(p)
        {
            this.PravnoLice = new PravnoLiceBasic(p.PravnoLice);
        }

        public PravnoLiceFakseviBasic():base()
        {
            
        }
    }


    #endregion PravnoLice

    #region Usluga
    public class UslugaPregled
    {
        public int Id { get; set; }
        public string Tip_usluge { get; set; }

        public UslugaPregled(Usluga u)
        {
            this.Id = u.ID;
            this.Tip_usluge = u.Tip_usluge;
        }
        public UslugaPregled()
        {

        }

    }

    public class UslugaBasic : UslugaPregled
    {
        public virtual UgovorBasic Ugovor { get; set; }

        public UslugaBasic(Usluga u) : base(u)
        {
            this.Ugovor = new UgovorBasic(u.Ugovor);
        }
        public UslugaBasic():base()
        {
            
        }
    }

    #endregion Usluga

    #region Internet

    public class InternetPregled : UslugaPregled
    {
        public string TipPlacanja { get; set; }
        public string TipPostpaid { get; set; }

        public InternetPregled(Internet n) : base(n)
        {
            this.TipPlacanja=n.TipPlacanja;
            this.TipPostpaid = n.TipPostpaid;
        }

        public InternetPregled():base()
        {
            
        }

    }
    public class InternetBasic : InternetPregled
    {
       
       
        public InternetBasic(Internet n) : base(n)
        {
            
        }

        public InternetBasic():base()
        {
            
        }
    }

    public class PrepaidPregled : InternetPregled
    {
        public string TipPlacanja { get; set; }
        public DateTime DatumUplate { get; set; }
        public int Stanje { get; set; }

        public PrepaidPregled(Internet u) : base(u)
        {
            this.TipPlacanja = "Prepaid";
            this.DatumUplate = (DateTime)u.DatumUplate;
            this.Stanje = (int)u.Stanje;
        }


        public PrepaidPregled():base()
        {

        }
    }

    public class PrepaidBasic : PrepaidPregled
    {
        public string TipPlacanja { get; set; }
        public DateTime DatumUplate { get; set; }
        public int Stanje { get; set; }

        public PrepaidBasic(Internet n) : base(n)
        {
            this.TipPlacanja = "Prepaid";
            this.DatumUplate= (DateTime)n.DatumUplate;
            this.Stanje= (int)n.Stanje;
        }

        public PrepaidBasic():base()
        {
            
        }
    }
    public class PostpaidPregled : InternetPregled
    {
        public string TipPlacanja { get; set; }
        public int DanPlacanja { get; set; }
        public string TipPostpaid { get; set; }

        public PostpaidPregled(Internet n) : base(n)
        {
            this.TipPlacanja = "Postpaid";
            this.DanPlacanja = (int)n.DanPlacanja;
            this.TipPostpaid = n.TipPostpaid;
        }

        public PostpaidPregled():base()
        {
            
        }
    }
    public class PostpaidBasic : PostpaidPregled
    {
        public string TipPlacanja { get; set; }
        public int DanPlacanja { get; set; }
        public string TipPostpaid { get; set; }

        public PostpaidBasic(Internet n) : base(n)
        {
            this.TipPlacanja = "Postpaid";
            this.DanPlacanja = (int)n.DanPlacanja;
            this.TipPostpaid = n.TipPostpaid;
        }

        public PostpaidBasic():base()
        {
            
        }
    }
    public class OstvareniProtokPregled:PostpaidPregled
    {
        public int Potroseno { get; set; }
        public double CenaMB { get; set; }

        public OstvareniProtokPregled(Internet n) : base(n)
        {
            this.Potroseno = (int)n.Potroseno;
            this.CenaMB = (double)n.CenaMB;
        }

        public OstvareniProtokPregled():base()
        {
            
        }
    }

    public class OstvareniProtokBasic : OstvareniProtokPregled
    {
        public int Potroseno { get; set; }
        public double CenaMB { get; set; }

        public OstvareniProtokBasic(Internet n) : base(n)
        {
            this.Potroseno = (int)n.Potroseno;
            this.CenaMB = (double)n.CenaMB;
        }


        public OstvareniProtokBasic():base()
        {
            
        }
    }

    public class FlatRatePregled : PostpaidPregled
    {
        public int MesecnaCena { get; set; }
        public string StatickaAdresa1 { get; set; }
        public string StatickaAdresa2 { get; set; }

        public FlatRatePregled(Internet n) : base(n)
        {
            this.MesecnaCena = (int)n.MesecnaCena;
            this.StatickaAdresa1=n.StatickaAdresa1;
            this.StatickaAdresa2=n.StatickaAdresa2;
        }

        public FlatRatePregled():base()
        {
            
        }
    }

    public class FlatRateBasic : FlatRatePregled
    {
        public int MesecnaCena { get; set; }
        public string StatickaAdresa1 { get; set; }
        public string StatickaAdresa2 { get; set; }

        public FlatRateBasic(Internet n) : base(n)
        {
            this.MesecnaCena = (int)n.MesecnaCena;
            this.StatickaAdresa1 = n.StatickaAdresa1;
            this.StatickaAdresa2 = n.StatickaAdresa2;
        }

        public FlatRateBasic():base()
        {
            
        }
    }

    public class PrepaidUgovor
    {
        public int uslugaId { get; set; }
        public PrepaidPregled prepaid { get; set; }
        public int ugovorId { get; set; }
    }

    public class FlatRateUgovor
    {
        public int uslugaId { get; set; }

        public FlatRatePregled flatrate { get; set; }
        public int ugovorId { get; set; }
    }
    public class OstvareniProtokUgovor
    {
        public int uslugaId { get; set; }

        public OstvareniProtokPregled ostvareniProtok { get; set; }
        public int ugovorId { get; set; }
    }

    #endregion Internet

    #region Telefonija



    public class TelefonijaPregled : UslugaPregled
    {
        public TelefonijaPregled(Telefonija u) : base(u)
        {

        }

        public TelefonijaPregled():base()
        {
            
        }
    }



    public class TelefonijaBasic : TelefonijaPregled
    {
        public virtual IList<TelefonskiBrojBasic> TelefonskiBrojevi { get; set; }
        
        public TelefonijaBasic(Telefonija u) : base(u)
        {
            this.TelefonskiBrojevi = new List<TelefonskiBrojBasic>(u.TelefonskiBrojevi.Count);
            for (int i = 0; i < u.TelefonskiBrojevi.Count; i++)
                this.TelefonskiBrojevi[i] = new TelefonskiBrojBasic(u.TelefonskiBrojevi[i]);
        }

        public TelefonijaBasic():base()
        {

        }
    }

    public class UslugaTelefonskiBroj
    {
        public int UslugaId { get; set; }
        public int brojUgovora { get; set; }
        public string broj { get; set; }
        public int minutiPrethodniMesec { get; set; }
    }
    #endregion Telefonija



    #region Televizija



    public class TelevizijaPregled : UslugaPregled
    {
        public TelevizijaPregled(Televizija t) : base(t)
        {

        }
        public TelevizijaPregled():base()
        {
            
        }

    }
    public class TelevizijaBasic : TelevizijaPregled
    {
        public virtual IList<DodajeBasic> PaketiKanala { get; set; }

        public TelevizijaBasic(Televizija t) : base(t)
        {
            this.PaketiKanala = new List<DodajeBasic>(t.PaketiKanala.Count);
            for (int i = 0; i < t.PaketiKanala.Count; i++)
                this.PaketiKanala[i] = new DodajeBasic(t.PaketiKanala[i]); 
        }

        public TelevizijaBasic():base()
        {
            
        }
    }

    public class UslugaPaketKanal
    {
        public int UslugaId { get; set; }
        public int brojUgovora { get; set; }

        public string PaketIme { get; set; }
        public string KanalIme { get; set; }
    }
    public class UslugaPaketKanalId
    {
        public int kanalId { get; set; }
        public int UslugaId { get; set; }
        public int brojUgovora { get; set; }

        public string PaketIme { get; set; }
        public string KanalIme { get; set; }
    }
    #endregion Televizija

    #region Uredjaj

    public class UredjajPregled
    {
        public virtual int Id { get; set; }
        public virtual string SerijskiBroj { get; set; }
        public virtual string NazivProizvodjaca { get; set; }
        public virtual DateTime? UpotrebaOd { get; set; }
        public virtual DateTime ZadnjiServis { get; set; }
        public virtual string RazlogServisa { get; set; }
        public virtual string Tip_uredjaja { get; set; }

        public UredjajPregled(Uredjaj u)
        {
            this.Id = u.ID;
            this.SerijskiBroj = u.SerijskiBroj;
            this.NazivProizvodjaca = u.NazivProizvodjaca;
            this.UpotrebaOd = u.UpotrebaOd;
            this.ZadnjiServis = u.ZadnjiServis;
            this.RazlogServisa = u.RazlogServisa;
            this.Tip_uredjaja = u.Tip_uredjaja;
        }

        public UredjajPregled():base()
        {
            
        }
    }

    public class UredjajBasic : UredjajPregled
    {
        public UredjajBasic(Uredjaj u) : base(u)
        {

        }

        public UredjajBasic():base()
        {
            
        }

    }



    #endregion Uredjaj
    #region KomunikacioniCvor

    public class KomunikacioniCvorPregled : UredjajPregled
    {
        public virtual string Opis { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int BrojZgrade { get; set; }
        public virtual string TipVeze { get; set; }
        
        public KomunikacioniCvorPregled(KomunikacioniCvor k) : base(k)
        {
            this.Opis = k.Opis;
            this.Grad = k.Grad;
            this.Ulica = k.Ulica;
            this.BrojZgrade = k.BrojZgrade;
            this.TipVeze = k.TipVeze;
        }

        public KomunikacioniCvorPregled():base()
        {

        }
    }

    public class KomunikacioniCvorBasic : KomunikacioniCvorPregled
    {
        public virtual GlavnaStanicaBasic Stanica { get; set; }
        public virtual IList<KlijentBasic> KlijentiPovezani { get; set; }

        public KomunikacioniCvorBasic(KomunikacioniCvor k) : base(k)
        {
            this.Stanica = new GlavnaStanicaBasic(k.Stanica);

            this.KlijentiPovezani = new List<KlijentBasic>(k.KlijentiPovezani.Count);
            for (int i = 0; i < k.KlijentiPovezani.Count; i++)
                this.KlijentiPovezani[i] = new KlijentBasic(k.KlijentiPovezani[i]);
        }

        public KomunikacioniCvorBasic():base()
        {

        }
    }


    #endregion KomunikacioniCvor

    #region RegionalniHub

    public class RegionalniHubPregled : GlavnaStanicaPregled
    {
        public virtual string NazivRegiona { get; set; }

        public RegionalniHubPregled(GlavnaStanica g) : base(g)
        {
            this.NazivRegiona = g.NazivRegiona;
        }

        public RegionalniHubPregled():base()
        {
            
        }
    }

    public class RegionalniHubBasic : RegionalniHubPregled
    {
        public virtual IList<KomunikacioniCvorBasic> KomunikacioniCvorovi { get; set; }
    
        public RegionalniHubBasic(GlavnaStanica g) : base(g)
        {
            this.KomunikacioniCvorovi = new List<KomunikacioniCvorBasic>(g.KomunikacioniCvorovi.Count);
            for (int i = 0; i < g.KomunikacioniCvorovi.Count; i++)
                this.KomunikacioniCvorovi[i] = new KomunikacioniCvorBasic(g.KomunikacioniCvorovi[i]);
        }
        public RegionalniHubBasic():base()
        {
            
        }

    }
    #endregion RegionalniHub

    #region GlavnaStanica

    public class GlavnaStanicaPregled : UredjajPregled
    {
        public virtual char RegionalniHubFlag { get; set; }

        public GlavnaStanicaPregled(GlavnaStanica g) : base(g)
        {
            this.RegionalniHubFlag = g.RegionalniHubFlag;
        }

        public GlavnaStanicaPregled():base()
        {
            
        }
    }

    public class GlavnaStanicaBasic : GlavnaStanicaPregled
    {
        public virtual IList<KomunikacioniCvorBasic> KomunikacioniCvorovi { get; set; }
    
        public GlavnaStanicaBasic(GlavnaStanica g) : base(g)
        {
            this.KomunikacioniCvorovi = new List<KomunikacioniCvorBasic>(g.KomunikacioniCvorovi.Count);
            for(int i = 0; i < g.KomunikacioniCvorovi.Count; i++)
            {
                this.KomunikacioniCvorovi[i] = new KomunikacioniCvorBasic(g.KomunikacioniCvorovi[i]);
            }
        }
        public GlavnaStanicaBasic():base()
        {
            
        }
    }

    #endregion GlavnaStanica

    #region PaketiKanala

    public class PaketKanalaPregled
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }

        public PaketKanalaPregled(PaketKanala p)
        {
            this.Id = p.ID;
            this.Ime = p.Ime;
        }

        public PaketKanalaPregled()
        {
            
        }
    }

    public class PaketKanalaBasic : PaketKanalaPregled
    {
        public virtual IList<DodajeBasic> Televizija { get; set; }
        public virtual IList<KanaliBasic> Kanali { get; set; }

        public PaketKanalaBasic(PaketKanala p) : base(p)
        {
            this.Televizija = new List<DodajeBasic>(p.Televizija.Count);
            for (int i = 0; i < p.Televizija.Count; i++)
                this.Televizija[i] = new DodajeBasic(p.Televizija[i]);
            
            this.Kanali=new List<KanaliBasic>(p.Kanali.Count);
            for (int i = 0; i < p.Kanali.Count; i++)
                this.Kanali[i] = new KanaliBasic(p.Kanali[i]);
        }
        public PaketKanalaBasic():base()
        {
            
        }
    }

    public class KanaliPregled
    {
        public int Id { get; set; }
        public string ImeKanala { get; set; }

        public KanaliPregled(Kanali k)
        {
            this.Id = k.ID;
            this.ImeKanala = k.ImeKanala;
        }

        public KanaliPregled()
        {
            
        }
    }
    public class KanaliBasic:KanaliPregled
    {
        public virtual PaketKanalaBasic PaketaKanala { get; set; }

        public KanaliBasic(Kanali k) : base(k)
        {
            this.PaketaKanala = new PaketKanalaBasic(k.PaketaKanala);
        }

        public KanaliBasic():base()
        {
            
        }

    }

    public class DodajePregled
    {
        public int Id { get; set; }

        public DodajePregled(Dodaje d)
        {
            this.Id = d.ID;
        }
        public DodajePregled()
        {
            
        }
    }
    public class DodajeBasic : DodajePregled
    {
        public virtual TelevizijaBasic Televizija { get; set; }
        public virtual PaketKanalaBasic PaketKanala { get; set; }

        public DodajeBasic(Dodaje d) : base(d)
        {
            this.Televizija = new TelevizijaBasic(d.Televizija);
            this.PaketKanala = new PaketKanalaBasic(d.PaketKanala);
        }
        public DodajeBasic():base()
        {

        }
    }


    #endregion PaketiKanala

    #region TelefonskiBroj

    public class TelefonskiBrojPregled
    {
        public virtual int Id { get; set; }
        public virtual string Broj { get; set; }
        public virtual int PrethodniMesec { get; set; }

        public TelefonskiBrojPregled(TelefonskiBroj t)
        {
            this.Id = t.ID;
            this.Broj = t.Broj;
            this.PrethodniMesec = t.PrethodniMesec;
        }
        public TelefonskiBrojPregled()
        {
            
        }
    }

    public class TelefonskiBrojBasic : TelefonskiBrojPregled
    {
        public virtual TelefonijaBasic Telefonija { get; set; }

        public TelefonskiBrojBasic(TelefonskiBroj t) : base(t)
        {
            this.Telefonija = new TelefonijaBasic(t.Telefonija);
        }

        public TelefonskiBrojBasic():base()
        {
            
        }
    }


    #endregion TelefonskiBroj
}
