using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikacija.DTO;
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Forms
{
    public partial class PrikazUsluga : Form
    {
        private int korisnikId;
        private List<UslugaTelefonskiBroj> telefonija;
        private List<UslugaPaketKanal> televizija;
        private List<PrepaidUgovor> prepaid;
        private List<OstvareniProtokUgovor> ostvareni;
        private List<FlatRateUgovor> flatRate;
        public PrikazUsluga(int id)
        {
            InitializeComponent();
            this.korisnikId = id;
             this.telefonija = new List<UslugaTelefonskiBroj>();
             this.televizija=new List<UslugaPaketKanal>();
             this.prepaid=new List<PrepaidUgovor>();
             this.ostvareni = new List<OstvareniProtokUgovor>();
             this.flatRate =new List<FlatRateUgovor>();
    }

        private void PrikazUsluga_Load(object sender, EventArgs e)
        {
            int listViewCount = 0;
            int posX = 35;
            int posY = 35;
            this.telefonija = DTOManager.VratiSveIznajmljeneTelefoneKorisnika(this.korisnikId);
            this.televizija = DTOManager.VratiSveKanaleKorisnika(this.korisnikId);
            this.prepaid = DTOManager.VratiSvePrepaidKorisnika(this.korisnikId);
            this.ostvareni = DTOManager.VratiSveOstvareniProtokKorisnika(this.korisnikId);
            this.flatRate = DTOManager.VratiSveFlatRateKorisnika(this.korisnikId);

            if (this.telefonija.Count != 0)
            {
                listViewCount++;
                ListView lvTelefonija=new ListView();
                lvTelefonija.Size = new Size(500, 124);
                lvTelefonija.Location=new Point(posX, posY);
                lvTelefonija.MultiSelect = false;
                lvTelefonija.FullRowSelect = true;
                lvTelefonija.Columns.Add("ID usluge");
                lvTelefonija.Columns.Add("Broj ugovora");
                lvTelefonija.Columns.Add("Telefonski Broj");
                lvTelefonija.Columns.Add("Prethodni mesec minuti");
                lvTelefonija.View = View.Details;
               Controls.Add(lvTelefonija);
                lvTelefonija.Items.Clear();
                lvTelefonija.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach(var t in this.telefonija)
                {
                    lvTelefonija.Items.Add(
                        new ListViewItem(new string[]
                        {
                            t.UslugaId.ToString(),
                            t.brojUgovora.ToString(),
                            t.broj,
                            t.minutiPrethodniMesec.ToString(),
                        }));
                }
                posY += 124 + 20;
            }


            if (this.televizija.Count != 0)
            {
                listViewCount++;
                ListView lvTelevizija = new ListView();
                lvTelevizija.Size = new Size(500, 124);
                lvTelevizija.Location = new Point(posX, posY);
                lvTelevizija.MultiSelect = false;
                lvTelevizija.FullRowSelect = true;
                lvTelevizija.Columns.Add("ID usluge");
                lvTelevizija.Columns.Add("Broj ugovora");
                lvTelevizija.Columns.Add("Ime Paketa");
                lvTelevizija.Columns.Add("Ime Kanala");
                lvTelevizija.View = View.Details;
                Controls.Add(lvTelevizija);
                lvTelevizija.Items.Clear();
                lvTelevizija.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach (var t in this.televizija)
                {
                    lvTelevizija.Items.Add(
                        new ListViewItem(new string[]
                        {
                            t.UslugaId.ToString(),
                            t.brojUgovora.ToString(),
                            t.PaketIme,
                            t.KanalIme.ToString(),
                        }));
                }
                posY += 124 + 20;
            }


            if (this.prepaid.Count != 0)
            {
                listViewCount++;
                ListView lvPrepaid = new ListView();
                lvPrepaid.Size = new Size(500, 124);
                lvPrepaid.Location = new Point(posX, posY);
                lvPrepaid.MultiSelect = false;
                lvPrepaid.FullRowSelect = true;
                lvPrepaid.Columns.Add("ID usluge");
                lvPrepaid.Columns.Add("Broj ugovora");
                lvPrepaid.Columns.Add("Datum poslednje uplate");
                lvPrepaid.Columns.Add("Trenutno stanje");
                lvPrepaid.View = View.Details;
                Controls.Add(lvPrepaid);
                lvPrepaid.Items.Clear();
                lvPrepaid.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach (var t in this.prepaid)
                {
                    lvPrepaid.Items.Add(
                        new ListViewItem(new string[]
                        {
                            t.uslugaId.ToString(),
                            t.ugovorId.ToString(),
                            t.prepaid.DatumUplate.ToString(),
                            t.prepaid.Stanje.ToString(),
                        }));
                }
                posY += 124 + 20;
            }

            if (this.flatRate.Count != 0)
            {
                listViewCount++;
                ListView lvFlat = new ListView();
                lvFlat.Size = new Size(500, 124);
                lvFlat.Location = new Point(posX, posY);
                lvFlat.MultiSelect = false;
                lvFlat.FullRowSelect = true;
                lvFlat.Columns.Add("ID usluge");
                lvFlat.Columns.Add("Broj ugovora");
                lvFlat.Columns.Add("Dan plaćanja");
                lvFlat.Columns.Add("Mesečna cena");
                lvFlat.Columns.Add("Statička adresa 1");
                lvFlat.Columns.Add("Statička adresa 2");
                lvFlat.View = View.Details;
                Controls.Add(lvFlat);
                lvFlat.Items.Clear();
                lvFlat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach (var t in this.flatRate)
                {
                    lvFlat.Items.Add(
                        new ListViewItem(new string[]
                        {
                            t.uslugaId.ToString(),
                            t.ugovorId.ToString(),
                            t.flatrate.DanPlacanja.ToString(),
                            t.flatrate.MesecnaCena.ToString(),
                            t.flatrate.StatickaAdresa1==null?"Ne poseduje":t.flatrate.StatickaAdresa1.ToString(),
                            t.flatrate.StatickaAdresa2==null?"Ne poseduje":t.flatrate.StatickaAdresa2.ToString()
                        }));
                }
                posY += 124 + 20;
            }

            if (this.ostvareni.Count != 0)
            {
                listViewCount++;
                ListView lvOstvareni = new ListView();
                lvOstvareni.Size = new Size(500, 124);
                lvOstvareni.Location = new Point(posX, posY);
                lvOstvareni.MultiSelect = false;
                lvOstvareni.FullRowSelect = true;
                lvOstvareni.Columns.Add("ID usluge");
                lvOstvareni.Columns.Add("Broj ugovora");
                lvOstvareni.Columns.Add("Potrošeno");
                lvOstvareni.Columns.Add("Cena Megabajta");
                lvOstvareni.View = View.Details;
                Controls.Add(lvOstvareni);
                lvOstvareni.Items.Clear();
                lvOstvareni.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach (var t in this.ostvareni)
                {
                    lvOstvareni.Items.Add(
                        new ListViewItem(new string[]
                        {
                            t.uslugaId.ToString(),
                            t.ugovorId.ToString(),
                            t.ostvareniProtok.Potroseno.ToString(),
                            t.ostvareniProtok.CenaMB.ToString()
                        })) ;
                }
                posY += 124 + 20;
            }

            if (listViewCount == 0)
            {
                MessageBox.Show("Ovaj klijent nema nijedu uslugu");
                this.Close();
            }

        }

       
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
