using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikacija.DTO;

namespace Telekomunikacija.Forms
{
    public partial class DodajUgovor : Form
    {
        private int korisnikId;
        private List<UslugaTelefonskiBroj> telefonija;
        private List<UslugaPaketKanalId> televizija;
        private List<PrepaidUgovor> prepaid;
        private List<OstvareniProtokUgovor> ostvareni;
        private List<FlatRateUgovor> flatRate;

        public DodajUgovor(int id)
        {
            InitializeComponent();
            this.korisnikId = id;
            telefonija=new List<UslugaTelefonskiBroj>();
            televizija=new List<UslugaPaketKanalId>();
            prepaid = new List<PrepaidUgovor>();
            ostvareni = new List<OstvareniProtokUgovor>();
            flatRate=new List<FlatRateUgovor>();
        }

        private void DodajUgovor_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajPre_Click(object sender, EventArgs e)
        {
            this.prepaid.Add(new PrepaidUgovor()
            {
                ugovorId = -1,
                prepaid=new PrepaidPregled()
                {
                    DatumUplate=DateTime.Now,
                    Stanje=200,
                    TipPlacanja="Prepaid"
                }
                
            });
            RefreshData();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            int n = -1;
            for(int i = 0; i < this.prepaid.Count; i++)
            {
                if (listViewPre.Items[i].Selected)
                    n = i;
            }
            if (n != -1)
            {
                IzmeniPrepaid f = new IzmeniPrepaid(prepaid[n].prepaid.Stanje, prepaid[n].prepaid.DatumUplate);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    prepaid[n].prepaid.DatumUplate = f.datumUplate;
                    prepaid[n].prepaid.Stanje = f.stanje;
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Označite Prepaid uslugu");
            }
        }


        private void buttonIzbaciPre_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewPre.Items)
            {
                if (item.Selected)
                {
                    this.prepaid.RemoveAt(item.Index);
                    item.Remove();
                   
                }
            }

        }

        private void buttonDodajOst_Click(object sender, EventArgs e)
        {
            this.ostvareni.Add(new OstvareniProtokUgovor()
            {
                ugovorId = -1,
                ostvareniProtok = new OstvareniProtokPregled()
                {
                    CenaMB=1,
                    DanPlacanja=21,
                    Potroseno=0
                }

            }) ;
            RefreshData();
        }

        private void buttonIzmeniOst_Click(object sender, EventArgs e)
        {
            int n = -1;
            for (int i = 0; i < this.ostvareni.Count; i++)
            {
                if (listViewOst.Items[i].Selected)
                    n = i;
            }
            if (n != -1)
            {
                IzmeniOstvareni f = new IzmeniOstvareni(ostvareni[n].ostvareniProtok.DanPlacanja, ostvareni[n].ostvareniProtok.CenaMB,
                    ostvareni[n].ostvareniProtok.Potroseno);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    ostvareni[n].ostvareniProtok.DanPlacanja = f.danPlac;
                    ostvareni[n].ostvareniProtok.CenaMB = f.cenaMB;
                    ostvareni[n].ostvareniProtok.Potroseno = f.potroseno;
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Označite Ostvareni protok uslugu");
            }
        }

        private void buttonIzbacOst_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewOst.Items)
            {
                if (item.Selected)
                {
                    this.ostvareni.RemoveAt(item.Index);
                    item.Remove();
                    

                }
            }
        }

        private void buttonDodajFlat_Click(object sender, EventArgs e)
        {
            this.flatRate.Add(new FlatRateUgovor()
            {
                ugovorId = -1,
                flatrate = new FlatRatePregled()
                {
                    MesecnaCena=1500,
                    StatickaAdresa1=null,
                    StatickaAdresa2=null,
                }

            });
            RefreshData();
        }

        private void buttonIzmeniFlat_Click(object sender, EventArgs e)
        {
            int n = -1;
            for (int i = 0; i < this.flatRate.Count; i++)
            {
                if (listViewFlat.Items[i].Selected)
                    n = i;
            }
            if (n != -1)
            {
                IzmeniFlat f = new IzmeniFlat(flatRate[n].flatrate.MesecnaCena, flatRate[n].flatrate.StatickaAdresa1, flatRate[n].flatrate.StatickaAdresa2);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    flatRate[n].flatrate.MesecnaCena = f.mesecna;
                    flatRate[n].flatrate.StatickaAdresa1 = f.a1;
                    flatRate[n].flatrate.StatickaAdresa2 = f.a2;
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Označite Flat rate uslugu");
            }
        }

        private void buttonIzbaciFlat_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewFlat.Items)
            {
                if (item.Selected)
                {
                    this.flatRate.RemoveAt(item.Index);
                    item.Remove();
                    

                }
            }
        }

        private void buttonDodajTelev_Click(object sender, EventArgs e)
        {
            DodajPaketeKanalima f = new DodajPaketeKanalima();
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<UslugaPaketKanalId> pom = f.selectedKanali;
                foreach (var p in pom)
                {
                    if (!KanalVecDodat(p))
                    {
                        this.televizija.AddRange(DTOManager.VratiSveKanaleIzPaketaSaKanalom(p.kanalId));
                    }
                }
            }
            RefreshData();
        }
        public bool KanalVecDodat(UslugaPaketKanalId kanalPaket)
        {
            foreach(var k in this.televizija)
            {
                if (k.kanalId == kanalPaket.kanalId) return true;
            }
            return false;
        }
      
        private void buttonIzbaciTelev_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewTelev.Items)
            {
                if (item.Selected)
                {
                   // this.televizija.RemoveAt(item.Index);
                    for(int i=0;i<televizija.Count;)
                    {
                        if (televizija[i].PaketIme == item.SubItems[1].Text)
                        {
                            this.televizija.RemoveAt(i);
                            this.listViewTelev.Items.RemoveAt(i);

                        }
                        else
                        {
                            i++;
                        }
                    }
                    //item.Remove();
                    

                }
            }
           // RefreshData();
        }

        private void buttonDodajTelef_Click(object sender, EventArgs e)
        {
            DodajTelefoniju f = new DodajTelefoniju();
            if (f.ShowDialog() == DialogResult.OK)
            {
                UslugaTelefonskiBroj utb = new UslugaTelefonskiBroj()
                {
                    broj = f.broj,
                    minutiPrethodniMesec=f.prethodniMesec,
                    brojUgovora=-1,
                    UslugaId=-1
                };
                telefonija.Add(utb);
            }
            RefreshData();
        }

        private void buttonIzmeniTelef_Click(object sender, EventArgs e)
        {
              int n = -1;
            for (int i = 0; i < this.telefonija.Count; i++)
            {
                if (listViewTelef.Items[i].Selected)
                    n = i;
            }
            if (n != -1)
            {
                IzmeniTelefoniju f = new IzmeniTelefoniju(this.telefonija[n].minutiPrethodniMesec, this.telefonija[n].broj);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    telefonija[n].minutiPrethodniMesec = f.prethodniMesec;
                    telefonija[n].broj = f.broj;
                    telefonija[n].brojUgovora = -1;
                    telefonija[n].UslugaId = -1;
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Označite broj telefona uslugu");
            }
        }

        private void buttonIzbaciTelef_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewTelef.Items)
            {
                if (item.Selected)
                {
                    this.telefonija.RemoveAt(item.Index);
                    item.Remove();
                    

                }
            }
        }

        private void RefreshData()
        {
            listViewTelef.Items.Clear();

            foreach (var f in telefonija)
            {
                listViewTelef.Items.Add(
                   new ListViewItem(new string[]
                   {
                      f.broj
                   }));
            }

            listViewTelev.Items.Clear();

            foreach (var v in televizija)
            {
                listViewTelev.Items.Add(
                    new ListViewItem(new string[]
                    {
                        v.KanalIme,
                        v.PaketIme
                    }));
            }

            listViewPre.Items.Clear();

            foreach (var p in prepaid)
            {
                listViewPre.Items.Add(
                    new ListViewItem(new string[]
                    {
                        p.prepaid.DatumUplate.ToString(),
                        p.prepaid.Stanje.ToString()
                    }));
            }

                listViewOst.Items.Clear();

            foreach(var o in ostvareni)
            {
                listViewOst.Items.Add(
                    new ListViewItem(new string[]
                    {
                        o.ostvareniProtok.DanPlacanja.ToString(),
                        o.ostvareniProtok.Potroseno.ToString(),
                        o.ostvareniProtok.CenaMB.ToString()
                    }));
            }


                listViewFlat.Items.Clear();

            foreach(var f in flatRate)
            {
                listViewFlat.Items.Add(
                    new ListViewItem(new string[]
                    {
                        f.flatrate.MesecnaCena.ToString(),
                        f.flatrate.StatickaAdresa1==null?"/":f.flatrate.StatickaAdresa1,
                        f.flatrate.StatickaAdresa2==null?"/":f.flatrate.StatickaAdresa2
                    }));
            }
        }
        private void SelectCheck()
        {
            
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DTOManager.DodajUgovorSaUslugama(this.korisnikId, this.telefonija, this.televizija, this.ostvareni, this.flatRate, this.prepaid);
            this.Close();
        }
    }
}
