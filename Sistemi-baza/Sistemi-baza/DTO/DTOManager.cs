using NHibernate;
using NHibernate.Stat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telekomunikacija.Entiteti;
using System.Windows.Forms;
using Telekomunikacija.Mapiranje;
using Antlr.Runtime.Tree;
using Telekomunikacija.Forms;
using NHibernate.Util;
using System.Runtime.ExceptionServices;
using NHibernate.Linq.Functions;
using System.Security.Cryptography.X509Certificates;

namespace Telekomunikacija.DTO
{
    public class DTOManager
    {

        #region Klijent
        public static List<KlijentPregled> VratiSveKlijente()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var fizicka = s.Query<FizickoLice>().ToList();
                var pravna = s.Query<PravnoLice>().ToList();

                s.Close();
                List<KlijentPregled> klijentiPreg = new List<KlijentPregled>();
                foreach (var klijent in fizicka)
                {
                    KlijentPregled kp = new KlijentPregled();
                    kp.Id = klijent.ID;
                    kp.Ime = klijent.Ime;
                    kp.Grad = klijent.Grad;
                    kp.Ulica = klijent.Ulica;
                    kp.BrojZgrade = klijent.BrojZgrade;
                    kp.Tip = "Fizicko";
                    klijentiPreg.Add(kp);
                }
                foreach (var klijent in pravna)
                {
                    KlijentPregled kp = new KlijentPregled();
                    kp.Id = klijent.ID;
                    kp.Ime = klijent.Ime;
                    kp.Grad = klijent.Grad;
                    kp.Ulica = klijent.Ulica;
                    kp.BrojZgrade = klijent.BrojZgrade;
                    kp.Tip = "Pravno";
                    klijentiPreg.Add(kp);
                }
                return klijentiPreg;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new List<KlijentPregled>();
        }
        public static List<FizickoLicePregled> VratiSvaFizickaLica()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var flica = s.Query<FizickoLice>().ToList();

                s.Close();
                List<FizickoLicePregled> flPreg = new List<FizickoLicePregled>();
                foreach (var fl in flica)
                {
                    FizickoLicePregled f = new FizickoLicePregled();
                    f.Id = fl.ID;
                    f.Ime = fl.Ime;
                    f.Grad = fl.Grad;
                    f.Ulica = fl.Ulica;
                    f.BrojZgrade = fl.BrojZgrade;
                    f.JMBG = fl.JMBG;
                    f.Tip = "Fizicko";
                    flPreg.Add(f);
                }
                return flPreg;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new List<FizickoLicePregled>();
        }

        public static List<PravnoLicePregled> VratiSvaPravnaLica()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var plica = s.Query<PravnoLice>().ToList();

                s.Close();
                List<PravnoLicePregled> plPreg = new List<PravnoLicePregled>();
                foreach (var pl in plica)
                {
                    PravnoLicePregled p = new PravnoLicePregled();
                    p.Id = pl.ID;
                    p.Ime = pl.Ime;
                    p.Grad = pl.Grad;
                    p.Ulica = pl.Ulica;
                    p.BrojZgrade = pl.BrojZgrade;
                    p.ImeKontakta = pl.ImeKontakta;
                    p.MaticniBroj = pl.MaticniBroj;
                    p.PIB = pl.PIB;
                    p.Tip = "Pravno";
                    plPreg.Add(p);
                }
                return plPreg;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new List<PravnoLicePregled>();
        }


        public static bool ObrisiKlijenta(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Klijent k = s.Load<Klijent>(id);

                s.Delete(k);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        public static bool ObrisiKlijente(List<int> ids)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                foreach (int id in ids)
                {
                    Klijent k = s.Load<Klijent>(id);
                    s.Delete(k);
                }
                t.Commit();
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        public static bool IzmeniPravnoLicePregled(PravnoLicePregled korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var pravnoLice = s.Load<PravnoLice>(korisnik.Id);
                pravnoLice.Ime = korisnik.Ime;
                pravnoLice.Grad = korisnik.Grad;
                pravnoLice.Ulica = korisnik.Ulica;
                pravnoLice.BrojZgrade = korisnik.BrojZgrade;
                pravnoLice.ImeKontakta = korisnik.ImeKontakta;
                pravnoLice.MaticniBroj = korisnik.MaticniBroj;
                pravnoLice.PIB = korisnik.PIB;

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return true;
        }


        public static bool IzmeniFizickoLicePregled(FizickoLicePregled korisnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var fizickoLice = s.Load<FizickoLice>(korisnik.Id);
                fizickoLice.Ime = korisnik.Ime;
                fizickoLice.Grad = korisnik.Grad;
                fizickoLice.Ulica = korisnik.Ulica;
                fizickoLice.BrojZgrade = korisnik.BrojZgrade;
                fizickoLice.Tip_klijenta = "Fizicko";
                fizickoLice.JMBG = korisnik.JMBG;

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return true;
        }


        public static PravnoLicePregled VratiPravnoLice(int id)
        {
            PravnoLicePregled licePregled = new PravnoLicePregled();
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLice plice = s.Load<PravnoLice>(id);
                licePregled   = new PravnoLicePregled(plice);
                s.Close();
              //  liceBasic.PovezanNaCvor=new KomunikacioniCvorBasic(cvor);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return licePregled;
        }

        public static void DodajFizickoLice(FizickoLiceBasic lice)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice f = new FizickoLice();

                f.Ime = lice.Ime;
                f.Grad = lice.Grad;
                f.Ulica = lice.Ulica;
                f.BrojZgrade = lice.BrojZgrade;
                f.JMBG = lice.JMBG;
                f.PovezanNaCvor = s.Load<Entiteti.KomunikacioniCvor>(lice.PovezanNaCvor.Id);
                //f.PotpisaniUgovori = new List<Ugovor>();

                /* BrojTelefonKlijent brTel = new BrojTelefonKlijent();
                 brTel.BrojTelefona = lice.BrojeviTelefona[0].BrojTelefona;

                 f.BrojeviTelefona = new List<BrojTelefonKlijent>();
                 f.BrojeviTelefona.Add(brTel);
 */
                
                s.Save(f);
                s.Flush();

                s.Close();

                MessageBox.Show("Uspesno dodato fizicko lice");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static void DodajPravnoLice(PravnoLiceBasic lice)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLice f = new PravnoLice();

                f.Ime = lice.Ime;
                f.Grad = lice.Grad;
                f.Ulica = lice.Ulica;
                f.BrojZgrade = lice.BrojZgrade;
                f.PIB = lice.PIB;
                f.ImeKontakta = lice.ImeKontakta;
                f.MaticniBroj = lice.MaticniBroj;
                f.PovezanNaCvor = s.Load<Entiteti.KomunikacioniCvor>(lice.PovezanNaCvor.Id);
                

                s.Save(f);
                s.Flush();

                s.Close();

                MessageBox.Show("Uspesno dodato pravno lice");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        public static FizickoLicePregled VratiFizickoLice(int id)
        {
            FizickoLicePregled licePregled = new FizickoLicePregled();
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice plice = s.Load<FizickoLice>(id);
                licePregled = new FizickoLicePregled(plice);
                s.Close();
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return licePregled;
        }

        public static void PromeniCvorKlijentu(int klijentId,int cvorId)
        {
            try
            {
                ISession s=DataLayer.GetSession();
                Klijent k=s.Load<Klijent>(klijentId);
                KomunikacioniCvor c=s.Load<KomunikacioniCvor>(cvorId);

                k.PovezanNaCvor = c;
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DodajKlijenta(KlijentBasic klijent)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Klijent k = new Klijent();

                k.Ime = klijent.Ime;
                k.Grad = klijent.Grad;
                k.Ulica = klijent.Ulica;
                k.BrojZgrade = klijent.BrojZgrade;
                k.Tip_klijenta = klijent.Tip;
                k.PovezanNaCvor = session.Load<KomunikacioniCvor>(klijent.PovezanNaCvor.Id);


                session.Save(k);
                session.Flush();

                session.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static Klijent VratiKlijenta(int id)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                IQuery q = session.CreateQuery("from KLIJENT as k where k.ID = :id");
                q.SetInt32("id", id);

                Klijent k = q.UniqueResult<Klijent>();

                return k;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static void IzmeniKlijenta(int id, KlijentBasic klijent)
        {
            try
            {
                ISession session = DataLayer.GetSession();

                Klijent k = session.Load<Klijent>(id);

                k.Ime = klijent.Ime;
                k.Grad = klijent.Grad;
                k.Ulica = klijent.Ulica;
                k.BrojZgrade = klijent.BrojZgrade;
                k.Tip_klijenta = klijent.Tip;

                session.Flush();

                session.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }

        public static List<Klijent> VratiSveKlijente2()
        {
            List<Klijent> k = new List<Klijent>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Klijent as k");

                k = s.Query<Klijent>().ToList();

               // klijenti = q.List<Klijent>();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return k;
        }



        #endregion Klijent

        #region Usluga

        public static List<UslugaPregled> VratiSveUsluge()
        {
            List<Usluga> usluge = new List<Usluga>();
            try
            {
                ISession s = DataLayer.GetSession();

                usluge = s.Query<Usluga>().ToList();

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<UslugaPregled> returnUsluge = new List<UslugaPregled>();

            foreach(Usluga u in usluge)
            {
                UslugaPregled obj = new UslugaPregled();
                
                obj.Id = u.ID;
                obj.Tip_usluge = u.Tip_usluge;  
                
                returnUsluge.Add(obj);
            }

            return returnUsluge;
        }

        public static List<UslugaPaketKanal> VratiSveKanaleKorisnika (int id) 
        {
            List<UslugaPaketKanal> kanaliKorisnika=new List<UslugaPaketKanal> ();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Televizija> tel = s.Query<Televizija>()
                    .Where(t=>t.Ugovor!=null&&t.Ugovor.Klijent!=null)
                    .Where(t => t.Ugovor.Klijent.ID == id)
                    .ToList();

                foreach (var t in tel)
                {
                    foreach (var p in t.PaketiKanala)
                    {
                       var paketiKan= s.Query<PaketKanala>().
                            Where(pk=>pk.ID==p.PaketKanala.ID)
                            .ToList();
                        foreach (var k in paketiKan)
                        {
                            foreach (var kanali in k.Kanali)
                            {
                                kanaliKorisnika.Add(new UslugaPaketKanal
                                {
                                    UslugaId = t.ID,
                                    brojUgovora = t.Ugovor.BrojUgovora,
                                    PaketIme = k.Ime,
                                    KanalIme = kanali.ImeKanala
                                });

                            }
                        }
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kanaliKorisnika;
        }

        public static List<UslugaTelefonskiBroj> VratiSveIznajmljeneTelefoneKorisnika(int korisnikId)
        {
            List<UslugaTelefonskiBroj> iznajmljeniBrojevi=new List<UslugaTelefonskiBroj>();
            try
            {
                ISession s=DataLayer.GetSession();
                List<Telefonija> tel=s.Query<Telefonija>()
                    .Where(t=>t.Ugovor!=null&&t.Ugovor.Klijent!=null)
                    .Where(t=>t.Ugovor.Klijent.ID==korisnikId)
                    .ToList();

                foreach(var t in tel)
                {
                    foreach(var b in t.TelefonskiBrojevi)
                    {
                        iznajmljeniBrojevi.Add(new UslugaTelefonskiBroj
                        {
                            UslugaId = t.ID,
                            brojUgovora = t.Ugovor.BrojUgovora,
                            broj = b.Broj,
                            minutiPrethodniMesec = b.PrethodniMesec
                        });
                    }
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return iznajmljeniBrojevi;
        }


        public static List<PrepaidUgovor> VratiSvePrepaidKorisnika(int korisnikId)
        {
            List<PrepaidUgovor> prepaid = new List<PrepaidUgovor>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Internet> internet = s.Query<Internet>()
                     .Where(n => n.Ugovor != null && n.Ugovor.Klijent != null && n.TipPlacanja != null)
                    .Where(n => n.Ugovor.Klijent.ID == korisnikId && n.TipPlacanja =="Prepaid")
                    .ToList();

                foreach(var n in internet)
                {
                    prepaid.Add(new PrepaidUgovor{
                        uslugaId=n.ID,
                        prepaid = new PrepaidPregled(n),
                        ugovorId=n.Ugovor.BrojUgovora
                    });
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return prepaid;
        }

        public static List<FlatRateUgovor> VratiSveFlatRateKorisnika(int korisnikId)
        {
            List<FlatRateUgovor> Flatrate = new List<FlatRateUgovor>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Internet> internet = s.Query<Internet>()
                     .Where(n => n.Ugovor != null && n.Ugovor.Klijent != null && n.TipPlacanja != null && n.TipPostpaid != null)
                    .Where(n => n.Ugovor.Klijent.ID == korisnikId&&n.TipPlacanja=="Postpaid"&&n.TipPostpaid=="Flat")
                    .ToList();

                foreach (var n in internet)
                {
                    Flatrate.Add(new FlatRateUgovor
                    {
                        uslugaId = n.ID,
                        flatrate = new FlatRatePregled(n),
                        ugovorId = n.Ugovor.BrojUgovora
                    });
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Flatrate;
        }

        public static List<OstvareniProtokUgovor> VratiSveOstvareniProtokKorisnika(int korisnikId)
        {
            List<OstvareniProtokUgovor> OstvareniProtok = new List<OstvareniProtokUgovor>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Internet> internet = s.Query<Internet>()
                    .Where(n=>n.Ugovor!=null&&n.Ugovor.Klijent!=null&&n.TipPlacanja!=null&&n.TipPostpaid!=null)
                    .Where(n => n.Ugovor.Klijent.ID == korisnikId && n.TipPlacanja == "Postpaid" && n.TipPostpaid == "Ostvareni")
                    .ToList();

                foreach (var n in internet)
                {
                    OstvareniProtok.Add(new OstvareniProtokUgovor
                    {
                        uslugaId = n.ID,
                        ostvareniProtok = new OstvareniProtokPregled(n),
                        ugovorId = n.Ugovor.BrojUgovora
                    });
                }

                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return OstvareniProtok;
        }
        public static List<UslugaPaketKanalId> VratiSveKanaleSaPaketom()
        {
            List<UslugaPaketKanalId> kanaliSaPaketom=new List<UslugaPaketKanalId>();
            try
            {
                ISession s = DataLayer.GetSession();
                var kanali = s.Query<Kanali>();

                foreach(var kanal in kanali)
                {
                    kanaliSaPaketom.Add(new UslugaPaketKanalId()
                    {
                        kanalId= kanal.ID,
                        KanalIme=kanal.ImeKanala,
                        PaketIme=kanal.PaketaKanala.Ime,
                        brojUgovora=-1,
                        UslugaId=-1
                    });
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kanaliSaPaketom;
        }


        public static List<UslugaPaketKanalId> VratiSveKanaleIzPaketaSaKanalom(int kanalId)
        {
            List<UslugaPaketKanalId> kanaliIzPaketa = new List<UslugaPaketKanalId>();
            try
            {
                ISession s = DataLayer.GetSession();
                var kanal=s.Query<Kanali>()
                    .Where(k=>k.ID==kanalId).First();
                var paket = s.Query<PaketKanala>()
                    .Where(p => p.Kanali.Contains(kanal))
                    .First();

                foreach(var k in paket.Kanali)
                {
                    kanaliIzPaketa.Add(new UslugaPaketKanalId()
                    {
                        brojUgovora=-1,
                        kanalId=k.ID,
                        PaketIme=paket.Ime,
                        KanalIme=k.ImeKanala,
                        UslugaId=-1
                    });
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kanaliIzPaketa;
        }
        #endregion Usluga

        #region Uredjaj
        public static List<KomunikacioniCvorPregled> VratiSveNepuneKomCvorove()
        {
            List<KomunikacioniCvorPregled> c = new List<KomunikacioniCvorPregled>();

            try
            {
                ISession s=DataLayer.GetSession();

                List<KomunikacioniCvor> cvorovi = s.Query<KomunikacioniCvor>()
                    .Where(k => k.KlijentiPovezani.Count() < 100).ToList();

                foreach(var cvor in cvorovi)
                {
                    c.Add(new KomunikacioniCvorPregled(cvor));
                }
                s.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return c;
        }

        public static int VratiIdKomCvora(int idKorisnika)
        {
            int idCvora=-1;
            try
            {
                ISession s = DataLayer.GetSession();
                Klijent klijent = s.Query<Klijent>()
                    .Where(k => k.ID == idKorisnika).First();

                idCvora = klijent.PovezanNaCvor.ID;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idCvora;
        }

        public static List<UredjajPregled> VratiSveUredjaje()
        {
            List<Uredjaj> uredjaji = new List<Uredjaj>();

            try
            {
                ISession s = DataLayer.GetSession();

                uredjaji = s.Query<Uredjaj>().ToList();
                //uredjaji = s.CreateQuery("FROM Uredjaj").List<Uredjaj>();

                s.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }



            List<UredjajPregled> pregled = new List<UredjajPregled>();
            foreach (Uredjaj u in uredjaji)
            {
                UredjajPregled uredjaj = new UredjajPregled();
                uredjaj.Id = u.ID;
                uredjaj.SerijskiBroj = u.SerijskiBroj;
                uredjaj.NazivProizvodjaca = u.NazivProizvodjaca;
                uredjaj.UpotrebaOd = u.UpotrebaOd;
                uredjaj.ZadnjiServis = u.ZadnjiServis;
                uredjaj.RazlogServisa = u.RazlogServisa;
                string tip;
                if (object.ReferenceEquals(u.GetType(), (new KomunikacioniCvor()).GetType()))
                {
                    tip = "Komunikacioni cvor";
                }
                else if (object.ReferenceEquals(u.GetType(), (new GlavnaStanica()).GetType())
                    && ((GlavnaStanica)u).RegionalniHubFlag == 'N')
                {
                    tip = "Glavna stanica";
                }
                else
                {
                    tip = "Regionalni hub";
                }

                uredjaj.Tip_uredjaja = tip;
                pregled.Add(uredjaj);
            }

            return pregled;
        }

        public static List<KomunikacioniCvorPregled> VratiSveCvorove()
        {
            List<KomunikacioniCvor> cvorovi = new List<KomunikacioniCvor>();

            try
            {
                ISession s = DataLayer.GetSession();

                cvorovi = s.Query<KomunikacioniCvor>().ToList();

                s.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }


            List<KomunikacioniCvorPregled> pregled = new List<KomunikacioniCvorPregled>();
            foreach (KomunikacioniCvor c in cvorovi)
            {
                KomunikacioniCvorPregled cvor = new KomunikacioniCvorPregled();

                cvor.Id = c.ID;
                cvor.SerijskiBroj = c.SerijskiBroj;
                cvor.NazivProizvodjaca = c.NazivProizvodjaca;
                cvor.UpotrebaOd = c.UpotrebaOd;
                cvor.ZadnjiServis = c.ZadnjiServis;
                cvor.RazlogServisa = c.RazlogServisa;

                pregled.Add(cvor);
            }

            return pregled;
        }

        public static List<KomunikacioniCvorPregled> VratiSveKomunikacioneCvorove()
        {
            List<KomunikacioniCvor> cvorovi = new List<KomunikacioniCvor>();
            List<KomunikacioniCvorPregled> cvoroviReturn = new List<KomunikacioniCvorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                cvorovi = s.Query<KomunikacioniCvor>().ToList();

                foreach(KomunikacioniCvor cvor in cvorovi)
                {
                    cvoroviReturn.Add(new KomunikacioniCvorPregled(cvor));
                }
            }
            catch(Exception ex) { MessageBox.Show("Lose povlacenje iz baze"); }

            return cvoroviReturn;
        }

        public static int VratiIdUredjaja(string serijskiBroj)
        {
            int id = -1;
            try
            {
                ISession s = DataLayer.GetSession();

                id = s.Query<Uredjaj>()
                            .Where(x => x.SerijskiBroj == serijskiBroj)
                            .Select(x => x.ID).First<int>();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            return id;
        }


        public static Uredjaj VratiUredjaj(int id)
        {
            Uredjaj uredjaj = null;
            try
            {
                ISession s = DataLayer.GetSession();

                uredjaj = s.Load<Uredjaj>(id);

                s.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            return uredjaj;
        }

        public static KomunikacioniCvorBasic VratiKomunikacioniCvorBasic(int id)
        {
            KomunikacioniCvor uredjajReturn = null;
            Uredjaj uredjajProxy;
            KomunikacioniCvorBasic komBasic = null;
            try
            {
                ISession s = DataLayer.GetSession();

                uredjajReturn = s.Load<KomunikacioniCvor>(id);


                KomunikacioniCvor uredjaj = uredjajReturn;

                komBasic = new KomunikacioniCvorBasic();
                komBasic.Id = id;
                komBasic.SerijskiBroj = uredjaj.SerijskiBroj;
                komBasic.NazivProizvodjaca = uredjaj.NazivProizvodjaca;
                komBasic.UpotrebaOd = uredjaj.UpotrebaOd;
                komBasic.ZadnjiServis = uredjaj.ZadnjiServis;
                komBasic.RazlogServisa = uredjaj.RazlogServisa;
                komBasic.Opis = uredjaj.Opis;
                komBasic.Grad = uredjaj.Grad;
                komBasic.Ulica = uredjaj.Ulica;
                komBasic.BrojZgrade = uredjaj.BrojZgrade;
              
                s.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            if (uredjajReturn == null)
            {
                MessageBox.Show("Lose izabran cvor");
                return null;
            }



            return komBasic;
        }

        public static List<RegionalniHubPregled> VratiGlavneStaniceSaRegionima()
        {
            List<GlavnaStanica> stanice = null;

            try
            {
                ISession s = DataLayer.GetSession();

                stanice = s.Query<GlavnaStanica>()
                            .ToList();
            }
            catch (Exception e) { MessageBox.Show("Greska pri prikupljanju podataka iz baze"); }


            List<RegionalniHubPregled> stanicePregled = new List<RegionalniHubPregled>();
            foreach (GlavnaStanica stanica in stanice)
            {
                stanicePregled.Add(new RegionalniHubPregled(stanica));
            }


            return stanicePregled;
        }

        public static void IzmeniStatusGlavneStanice(int id, RegionalniHubPregled pregled)
        {
            GlavnaStanica cvor;
            try
            {
                ISession s = DataLayer.GetSession();

                cvor = s.Load<GlavnaStanica>(id);

                cvor.SerijskiBroj = pregled.SerijskiBroj;
                cvor.NazivProizvodjaca = pregled.NazivProizvodjaca;
                cvor.UpotrebaOd = pregled.UpotrebaOd;
                cvor.ZadnjiServis = pregled.ZadnjiServis;
                cvor.RazlogServisa = pregled.RazlogServisa;
                cvor.RegionalniHubFlag = pregled.RegionalniHubFlag;
                cvor.NazivRegiona = pregled.NazivRegiona;

                s.Flush();
                s.Close();
            }
            catch(Exception e) { MessageBox.Show("Losa komunikacija s bazom"); }
        }

        public static bool PostojiGlavnaStanicaZaDatiRegion(string region)
        {
            bool flag = true;
            try
            {
                ISession s = DataLayer.GetSession();

                flag = s.Query<GlavnaStanica>()
                                    .Where(x => x.NazivRegiona == region)
                                    .Any();

            }
            catch(Exception e) { MessageBox.Show("Losa komunikacija s bazom"); }

            return flag;
        }

        public static void DodajGlavnuStanicu(GlavnaStanicaBasic stanica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                GlavnaStanica insert = new GlavnaStanica();
                insert.SerijskiBroj = stanica.SerijskiBroj;
                insert.NazivProizvodjaca = stanica.NazivProizvodjaca;
                insert.UpotrebaOd = stanica.UpotrebaOd;
                insert.ZadnjiServis = stanica.ZadnjiServis;
                insert.RazlogServisa = stanica.RazlogServisa;
                insert.RegionalniHubFlag = stanica.RegionalniHubFlag;

                s.Save(insert);
                s.Flush();
            }
            catch(Exception e) { MessageBox.Show("GRESKA U INSERTU U BAZI"); };

            MessageBox.Show("Dodata je glavna stanica");
        }



        public static KomunikacioniCvorPregled VratiKomunikacioniCvor(int id)
        {
            KomunikacioniCvor cvor = null;
            KomunikacioniCvorPregled pregled = null;
            try
            {
                ISession s = DataLayer.GetSession();

                cvor = s.Load<KomunikacioniCvor>(id);

                pregled = new KomunikacioniCvorPregled(cvor);


            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            return pregled;
        }

        public static List<GlavnaStanicaPregled> VratiSveGlavneStanice()
        {
            List<GlavnaStanica> stanice = null;

            try
            {
                ISession s = DataLayer.GetSession();

                stanice = s.Query<GlavnaStanica>()
                            .ToList();
            }
            catch (Exception e) { MessageBox.Show("Greska pri prikupljanju podataka iz baze"); }


            List<GlavnaStanicaPregled> stanicePregled = new List<GlavnaStanicaPregled>();
            foreach(GlavnaStanica stanica in stanice)
            {
                stanicePregled.Add(new GlavnaStanicaPregled(stanica));
            }
            

            return stanicePregled;
        }

        public static void IzmeniStatusKomunikacionogCvora(int id, KomunikacioniCvorPregled pregled)
        {
            KomunikacioniCvor cvor;
            try
            {
                ISession s = DataLayer.GetSession();

                cvor = s.Load<KomunikacioniCvor>(id);

                cvor.SerijskiBroj = pregled.SerijskiBroj;
                cvor.NazivProizvodjaca = pregled.NazivProizvodjaca;
                cvor.UpotrebaOd = pregled.UpotrebaOd;
                cvor.ZadnjiServis = pregled.ZadnjiServis;
                cvor.RazlogServisa = pregled.RazlogServisa;
                cvor.Opis = pregled.Opis;
                cvor.Grad = pregled.Grad;
                cvor.Ulica = pregled.Ulica;
                cvor.BrojZgrade = pregled.BrojZgrade;
                cvor.TipVeze = pregled.TipVeze;

                s.Flush();
                s.Close();
            }
            catch(Exception e) { MessageBox.Show("LOSA KOMUNIKACIJA S BAZOM"); }

            MessageBox.Show("Uspesno izmenjen objekat");
        }

        public static void DodajKomunikacioniCvor(int id, KomunikacioniCvorBasic pregled)
        {
            KomunikacioniCvor noviCvor = new KomunikacioniCvor();
            noviCvor.SerijskiBroj = pregled.SerijskiBroj;
            noviCvor.NazivProizvodjaca = pregled.NazivProizvodjaca;
            noviCvor.UpotrebaOd = pregled.UpotrebaOd;
            noviCvor.ZadnjiServis = pregled.ZadnjiServis;
            noviCvor.RazlogServisa = pregled.RazlogServisa;
            noviCvor.Opis = pregled.Opis;
            noviCvor.Grad = pregled.Grad;
            noviCvor.Ulica = pregled.Ulica;
            noviCvor.BrojZgrade = pregled.BrojZgrade;
            noviCvor.TipVeze = pregled.TipVeze;

            try
            {
                ISession s = DataLayer.GetSession();

                noviCvor.Stanica = s.Load<GlavnaStanica>(pregled.Stanica.Id);

                s.Save(noviCvor);
                s.Flush();
                s.Close();
            }
            catch(Exception ex) { MessageBox.Show("Losa komunikacija s bazom"); }

            MessageBox.Show("Uspesno dodat cvor");
        }

        public static void DodajKomunikacioniCvor(int id, KomunikacioniCvorPregled pregled)
        {
            KomunikacioniCvor noviCvor = new KomunikacioniCvor();
            

            try
            {
                ISession s = DataLayer.GetSession();

                noviCvor.SerijskiBroj = pregled.SerijskiBroj;
                noviCvor.NazivProizvodjaca = pregled.NazivProizvodjaca;
                noviCvor.UpotrebaOd = pregled.UpotrebaOd;
                noviCvor.ZadnjiServis = pregled.ZadnjiServis;
                noviCvor.RazlogServisa = pregled.RazlogServisa;
                noviCvor.Opis = pregled.Opis;
                noviCvor.Grad = pregled.Grad;
                noviCvor.Ulica = pregled.Ulica;
                noviCvor.BrojZgrade = pregled.BrojZgrade;
                noviCvor.TipVeze = pregled.TipVeze;

                s.Save(noviCvor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex) { MessageBox.Show("Losa komunikacija s bazom"); }
        }

        public static bool PostojiUredjajSaDatimSerijskimBrojem(string serijskiBroj)
        {
            bool flag = true;
            try
            {
                ISession s = DataLayer.GetSession();

                flag = s.Query<Uredjaj>()
                       .Where(x => x.SerijskiBroj == serijskiBroj)
                       .Any();
            }
            catch(Exception e) { MessageBox.Show("Losa komunikacija s bazom"); }
            return flag;
        }

        public static GlavnaStanicaBasic VratiGlavnuStanicu(int id)
        {
            GlavnaStanica uredjaj = null;
            GlavnaStanicaBasic uredjajReturn = null;
            try
            {
                ISession s = DataLayer.GetSession();

                uredjaj = s.Load<GlavnaStanica>(id);
                //uredjajReturn = new GlavnaStanicaBasic(uredjaj); 

                uredjajReturn = new GlavnaStanicaBasic();
                uredjajReturn.Id = uredjaj.ID;
                uredjajReturn.SerijskiBroj = uredjaj.SerijskiBroj;
                uredjajReturn.NazivProizvodjaca = uredjaj.NazivProizvodjaca;
                uredjajReturn.UpotrebaOd = uredjaj.UpotrebaOd;
                uredjajReturn.ZadnjiServis = uredjaj.ZadnjiServis;
                uredjajReturn.RazlogServisa = uredjaj.RazlogServisa;
                uredjajReturn.RegionalniHubFlag = uredjaj.RegionalniHubFlag;
                //uredjajReturn.NazivRegiona = uredjaj.NazivRegiona;
                s.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }

            

            return uredjajReturn;
        }

        public static void ObrisiUredjaj(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete($"FROM Uredjaj U WHERE U.ID={id}");


                s.Flush();
                s.Close();
            }
            catch(Exception e) { MessageBox.Show("GRESKA U BAZI!"); }
        }

        #endregion Uredjaj

        #region Ugovor
        public static IList<Ugovor> VratiUgvore()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                var ugovori = s.Query<Ugovor>().ToList();

                s.Close();

                return ugovori;

                //ISQLQuery q = s.CreateSQLQuery("SELECT * FROM UGOVOR ");
                //q.AddEntity(typeof(Ugovor));

                //IList<Ugovor> ugovori=q.List<Ugovor>();
                //return ugovori;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return new List<Ugovor>();
        }

        public static List<UgovorSaUslugama> VratiUgovoreSaUslugama(int klijnetId)
        {
            List<UgovorSaUslugama> spisak = new List<UgovorSaUslugama>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Ugovor> ugovoriKorisnik = s.Query<Ugovor>()
                    .Where(u => u.Klijent.ID == klijnetId)
                    .ToList();

                foreach(var u in ugovoriKorisnik)
                {
                    List<string> uslugeIzUgovora = new List<string>();
                    int numPrepaid = s.Query<Internet>()
                        .Where(n =>n.Ugovor.ID==u.ID &&n.TipPlacanja == "Prepaid")
                        .Count();
                    for(int i = 0; i < numPrepaid; i++)
                    {
                        uslugeIzUgovora.Add("Prepaid");
                    }

                    int numOstvareni = s.Query<Internet>()
                       .Where(n => n.Ugovor.ID == u.ID && n.TipPlacanja == "Postpaid"&&n.TipPostpaid=="Ostvareni")
                       .Count();
                    for (int i = 0; i < numOstvareni; i++)
                    {
                        uslugeIzUgovora.Add("Ostvareni protok");
                    }

                    int numFlat = s.Query<Internet>()
                       .Where(n => n.Ugovor.ID == u.ID && n.TipPlacanja == "Postpaid" && n.TipPostpaid == "Flat")
                       .Count();
                    for (int i = 0; i < numFlat; i++)
                    {
                        uslugeIzUgovora.Add("Flat rate");
                    }

                    int numTelevizija = s.Query<Televizija>()
                      .Where(n => n.Ugovor.ID == u.ID )
                      .Count();
                    for (int i = 0; i < numTelevizija; i++)
                    {
                        uslugeIzUgovora.Add("Televizija");
                    }

                    int numTelefonija = s.Query<Telefonija>()
                     .Where(n => n.Ugovor.ID == u.ID)
                     .Count();
                    for (int i = 0; i < numTelefonija; i++)
                    {
                        uslugeIzUgovora.Add("Telefonija");
                    }
                    spisak.Add(new UgovorSaUslugama()
                    {
                        ugovor=new UgovorPregled(u),
                        usluge=uslugeIzUgovora
                    });
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return spisak;
        }
        public static void ObrisiUgovor(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var ugovor = s.Query<Ugovor>()
                    .Where(u => u.ID == id)
                    .First();
                s.Delete(ugovor);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DodajUgovorSaUslugama(int korisnikId,List<UslugaTelefonskiBroj> telefonija, List<UslugaPaketKanalId> televizija,List<OstvareniProtokUgovor> ostvareni,
            List<FlatRateUgovor> flatRate, List<PrepaidUgovor> prepaid)
        {
            try
            {
                int brojUgovora = 1;
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();

                var klijent = s.Query<Klijent>()
                    .Where(k => k.ID == korisnikId)
                    .First();

                bool valid = false;
                do
                {
                   
                    var ugovor = s.Query<Ugovor>().Where(ug => ug.BrojUgovora == brojUgovora).FirstOrDefault();
                    if (ugovor == null) valid = true;
                    else brojUgovora++;
                } while (!valid);

                Ugovor u = new Ugovor();
                u.Klijent = klijent;
                u.BrojUgovora = brojUgovora;
                List<Usluga> Usluge = new List<Usluga>();

                Televizija tel = new Televizija();
                tel.Tip_usluge = "Televizija";
                tel.Ugovor= u;
                List<Dodaje> PaketiKanala=new List<Dodaje>();
                foreach (var kanal in televizija)
                {
                    var Paket = s.Query<Kanali>()
                        .Where(kan => kan.ID == kanal.kanalId && kan.PaketaKanala.Ime == kanal.PaketIme)
                        .Select(kan => kan.PaketaKanala)
                        .First();

                    Dodaje dodaje = new Dodaje();
                    dodaje.Televizija = tel;
                    dodaje.PaketKanala = Paket;
                  //  s.Save(dodaje);
                    if (!PaketiKanala.Any(p=>p.PaketKanala.Ime==dodaje.PaketKanala.Ime))
                    {
                        PaketiKanala.Add(dodaje);
                    }
                }
                tel.PaketiKanala = PaketiKanala;
                Usluge.Add(tel);


                List<Telefonija> telefonijaZaSave = new List<Telefonija>();
                int index = 0;
                while (index < telefonija.Count)
                {

                    Telefonija telef = new Telefonija();
                    telef.TelefonskiBrojevi = new List<TelefonskiBroj>();
                    telef.Ugovor = u;
                    telef.Tip_usluge = "Telefonija";
                    int granica = (index + 4 < telefonija.Count ? index + 4 : telefonija.Count);
                    for (int i = index; i < granica; i++)
                    {
                        telef.TelefonskiBrojevi.Add(new TelefonskiBroj()
                        {
                            Broj = telefonija[i].broj,
                            PrethodniMesec = telefonija[i].minutiPrethodniMesec,
                            Telefonija = telef
                        });
                        index++;
                    }
                    Usluge.Add(telef);
                    //s.Save(telef);
                    telefonijaZaSave.Add(telef);
                }

                List<Internet> internetZaSave = new List<Internet>();
                foreach(var p in prepaid)
                {
                    Internet prep = new Internet();
                    prep.Tip_usluge = "Internet";
                    prep.TipPlacanja = "Prepaid";
                    prep.DatumUplate = p.prepaid.DatumUplate;
                    prep.Stanje = p.prepaid.Stanje;
                    prep.DanPlacanja = null;
                    prep.TipPostpaid = null;
                    prep.Potroseno = null;
                    prep.CenaMB = null;
                    prep.MesecnaCena = null;
                    prep.StatickaAdresa1 = null;
                    prep.StatickaAdresa2 = null;
                    prep.Ugovor = u;

                    Usluge.Add(prep);
                    //s.Save(prep);
                    internetZaSave.Add(prep);
                }

                foreach(var f in flatRate)
                {
                    Internet flat = new Internet();
                    flat.Tip_usluge = "Internet";
                    flat.TipPlacanja = "Postpaid";
                    flat.Stanje = null;
                    flat.DatumUplate = null;
                    flat.DanPlacanja = f.flatrate.DanPlacanja;
                    flat.TipPostpaid = "Flat";
                    flat.Potroseno = null;
                    flat.CenaMB = null;
                    flat.MesecnaCena = f.flatrate.MesecnaCena;
                    flat.StatickaAdresa1 = f.flatrate.StatickaAdresa1;
                    flat.StatickaAdresa2 = f.flatrate.StatickaAdresa2;
                    flat.Ugovor = u;

                    Usluge.Add(flat);
                    //s.Save(flat);
                    internetZaSave.Add(flat);

                }

                foreach (var o in ostvareni)
                {
                    Internet ostvar = new Internet();
                    ostvar.Tip_usluge = "Internet";
                    ostvar.TipPlacanja = "Postpaid";
                    ostvar.Stanje = null;
                    ostvar.DatumUplate = null;
                    ostvar.DanPlacanja = o.ostvareniProtok.DanPlacanja;
                    ostvar.TipPostpaid = "Ostvareni";
                    ostvar.Potroseno = o.ostvareniProtok.Potroseno;
                    ostvar.CenaMB = o.ostvareniProtok.CenaMB;
                    ostvar.MesecnaCena = null;
                    ostvar.StatickaAdresa1 = null;
                    ostvar.StatickaAdresa2 = null;
                    ostvar.Ugovor = u;

                    Usluge.Add(ostvar);
                    // s.Save(ostvar);
                    internetZaSave.Add(ostvar);

                }

                u.ObuhvaceneUsluge = Usluge;
                s.Save(u);

                foreach(var p in PaketiKanala)
                {
                    s.Save(p);
                }
                foreach(var tzs in telefonijaZaSave)
                {
                    s.Save(tzs);
                }
                foreach(var n in internetZaSave)
                {
                    s.Save(n);
                }
                // s.Save(PaketiKanala);
                // s.Save(telefonijaZaSave);
                // s.Save(internetZaSave);
                klijent.PotpisaniUgovori.Add(u);
                s.SaveOrUpdate(klijent);
                t.Commit();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion Ugovor

        #region Kanali

        public static List<PaketKanalaPregled> VratiSvePaketeKanala()
        {
            List<PaketKanalaPregled> paketiKanalaBasic = new List<PaketKanalaPregled>();
            PaketKanala paket;
            IList<PaketKanala> paketiKanala;
            try
            {
                ISession s = DataLayer.GetSession();

                paketiKanala = s.CreateQuery("FROM PaketKanala").List<PaketKanala>();

                //paketiKanala = s.Query < Paket >

                foreach (PaketKanala p in paketiKanala)
                {
                    //PaketKanalaBasic paketKanalaInsert = new PaketKanalaBasic();

                    paketiKanalaBasic.Add(new PaketKanalaPregled(p));

                    //paketKanalaInsert.Id = p.ID;
                    //paketKanalaInsert.Ime = p.Ime;
                    //foreach (Dodaje televizija in p.Televizija)
                    //{
                    //    paketKanalaInsert.Add(new )
                    //}
                    //paketKanalaInsert.Televizija = p.Televizija;
                    //paketKanalaInsert.Kanali = p.Kanali;

                    //paketiKanalaBasic.Add(new PaketKanalaBasic(p));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return paketiKanalaBasic;
        }

        public static List<PaketKanala> VratiSveRealPaketeKanala()
        {
            List<PaketKanala> paketiKanala = null;
            try
            {
                ISession s = DataLayer.GetSession();

                paketiKanala = s.Query<PaketKanala>().ToList<PaketKanala>();

                //paketiKanala = s.Query < Paket >

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return paketiKanala;
        }

        public static PaketKanala VratiPaketKanala(int id)
        {
            PaketKanala paket = null;
            try
            {
                ISession s = DataLayer.GetSession();

                paket = s.Load<PaketKanala>(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return paket;
        }

        public static List<KanaliPregled> VratiSveKanaleZaPaket(PaketKanala paket)
        {
            List<KanaliPregled> kanaliPregled = new List<KanaliPregled>();
            List<Kanali> kanali = new List<Kanali>();

            try
            {
                ISession s = DataLayer.GetSession();

                kanali = s.Query<Kanali>().Where(x => x.PaketaKanala.ID == paket.ID).ToList();

                foreach(Kanali kanal in kanali)
                {
                    kanaliPregled.Add(new KanaliPregled(kanal));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return kanaliPregled;
        }

        public static List<KanaliPregled> VratiSveKanaleZaPaket(int idPaketa)
        {
            List<KanaliPregled> kanaliPregled = new List<KanaliPregled>();
            List<Kanali> kanali = new List<Kanali>();

            try
            {
                ISession s = DataLayer.GetSession();

                kanali = s.Query<Kanali>().Where(x => x.PaketaKanala.ID == idPaketa).ToList();

                foreach (Kanali kanal in kanali)
                {
                    kanaliPregled.Add(new KanaliPregled(kanal));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return kanaliPregled;
        }

        public static void DodajPaketKanala(string imePaketa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PaketKanala paket = new PaketKanala();
                paket.Ime = imePaketa;

                s.Save(paket);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Uspesno dodat paket kanala");
        }

        public static void ObrisiPaketeKanala(List<int> idjeviPaketa)
        {
            List<PaketKanala> paketi = new List<PaketKanala>();
            try
            {
                ISession s = DataLayer.GetSession();


                paketi = s.Query<PaketKanala>().Where(x => idjeviPaketa.Contains(x.ID)).ToList();
                
                foreach(PaketKanala paket in  paketi)
                {
                    s.Delete(paket);  
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DodajKanalZaPaket(string imeKanala, string paket)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kanali kanal = new Kanali();

                kanal.ImeKanala = imeKanala;
                kanal.PaketaKanala = s.Query<PaketKanala>().Where(x => x.Ime == paket).FirstOrDefault<PaketKanala>();

                s.Save(kanal);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Kanal je uspesno dodat");
        }

        public static bool ObrisiKanale(List<int> ids)
        {
            List<Kanali> kanali = new List<Kanali>();
            try
            {
                ISession s = DataLayer.GetSession();

                kanali = s.Query<Kanali>().Where(x => ids.Contains(x.ID)).ToList();

                foreach (Kanali kanal in kanali)
                {
                    s.Delete(kanal);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            MessageBox.Show("Kanali su uspesno obrisani");

            return true;
        }

        #endregion Kanali

        #region TelefonskiBroj

        public static List<string> VratiSveTelBrojeveKlijent(int id)
        {
            List<string> brojeviTel=new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();
                 brojeviTel = s.Query<BrojTelefonKlijent>()
                    .Where(b => b.Klijent.ID == id)
                    .Select(b => b.BrojTelefona)
                    .ToList();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return brojeviTel;
        }


        public static List<string> VratiSveFaksBrojeveKlijent(int id)
        {
            List<string> brojeviFaks = new List<string>();
            try
            {
                ISession s = DataLayer.GetSession();
                brojeviFaks = s.Query<PravnoLiceFaksevi>()
                   .Where(b => b.PravnoLice.ID == id)
                   .Select(b => b.BrojeviFaksa)
                   .ToList();

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return brojeviFaks;
        }

        public static void IzbrisiBrojKorisnika(int idKorisnika, string broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var brojZaBrianje = s.Query<BrojTelefonKlijent>()
                    .Where(b => b.Klijent.ID == idKorisnika && b.BrojTelefona == broj)
                    .First();

                s.Delete(brojZaBrianje);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void IzbrisiFaksPravnogLica(int idPravnogLica, string faks)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var faksZaBrianje = s.Query<PravnoLiceFaksevi>()
                    .Where(b => b.PravnoLice.ID == idPravnogLica && b.BrojeviFaksa == faks)
                    .First();

                s.Delete(faksZaBrianje);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool IzmeniTelBroj(int idKorisnika,string stariBroj ,string noviBroj)
        {
            bool takenCheck = false;
            try
            {
                ISession s = DataLayer.GetSession();
                takenCheck = s.Query<BrojTelefonKlijent>()
                    .Any(b => b.BrojTelefona == noviBroj);
                if (takenCheck)
                    throw new Exception("Broj je već u upotrebi");

                takenCheck=s.Query<TelefonskiBroj>()
                    .Any(t=>t.Broj==noviBroj);
                if (takenCheck)
                    throw new Exception("Broj je već u upotrebi");

                var broj = s.Query<BrojTelefonKlijent>()
                    .Where(b => b.Klijent.ID == idKorisnika && b.BrojTelefona == stariBroj)
                    .First();
                broj.BrojTelefona= noviBroj;
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return !takenCheck;
        }
        public static bool IzmeniFaksBroj(int idKorisnika, string stariBroj, string noviBroj)
        {
            bool takenCheck=false;
            try
            {
                ISession s = DataLayer.GetSession();
                takenCheck = s.Query<PravnoLiceFaksevi>()
                    .Any(b => b.BrojeviFaksa == noviBroj);
                if (takenCheck)
                    throw (new Exception("Broj je već u upotrebi"));

                var broj = s.Query<PravnoLiceFaksevi>()
                    .Where(b => b.PravnoLice.ID == idKorisnika && b.BrojeviFaksa == stariBroj)
                    .First();
                broj.BrojeviFaksa = noviBroj;
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return !takenCheck;
        }

        public static bool DodajTelBroj(int id, string broj)
        {
            bool takenCheck=false;
            try
            {
                ISession s = DataLayer.GetSession();
                takenCheck = s.Query<BrojTelefonKlijent>()
                   .Any(b => b.BrojTelefona == broj);
                if (takenCheck)
                    throw new Exception("Broj je već u upotrebi");

                takenCheck = s.Query<TelefonskiBroj>()
                    .Any(t => t.Broj == broj);
                if (takenCheck)
                    throw new Exception("Broj je već u upotrebi");

                Klijent k = s.Query<Klijent>()
                    .Where(kl => kl.ID == id)
                    .First();
                
                BrojTelefonKlijent btk = new BrojTelefonKlijent();
                btk.Klijent = k;
                btk.BrojTelefona = broj;
                s.Save(btk);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return !takenCheck;
        }

        public static bool DodajFaksBroj(int id, string broj)
        {
            bool takenCheck = false;
            try
            {
                ISession s = DataLayer.GetSession();
                takenCheck = s.Query<PravnoLiceFaksevi>()
                   .Any(b => b.BrojeviFaksa == broj);
                if (takenCheck)
                    throw new Exception("Broj je već u upotrebi");

                PravnoLice k = s.Query<PravnoLice>()
                    .Where(kl => kl.ID == id)
                    .First();

                PravnoLiceFaksevi plf = new PravnoLiceFaksevi();
                plf.PravnoLice = k;
                plf.BrojeviFaksa= broj; 
                s.Save(plf);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return !takenCheck;
        }

        public static bool JedinstvenBroj(string broj)
        {
            string pronadjen = string.Empty;
            try
            {
                ISession s = DataLayer.GetSession();
                pronadjen = s.Query<TelefonskiBroj>()
                    .Where(b => b.Broj == broj)
                    .Select(b=>b.Broj)
                    .FirstOrDefault();
                if (pronadjen != null) return false;

                pronadjen = s.Query<BrojTelefonKlijent>()
                    .Where(b => b.BrojTelefona == broj)
                    .Select(b => b.BrojTelefona)
                    .FirstOrDefault();
                if (pronadjen!=null) return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }
        #endregion TelefonskiBroj

    }
}
