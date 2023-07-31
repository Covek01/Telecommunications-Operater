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

namespace Telekomunikacija.Forms
{
    public partial class KomunikacioniCvorDodavanje : Form
    {
        public KomunikacioniCvorDodavanje()
        {
            InitializeComponent();

            txtTipVeze.Items.Add("Bakarni");
            txtTipVeze.Items.Add("Opticki");
            txtTipVeze.Text = txtTipVeze.Items[0].ToString();
        }

        private string parseCvorName(string name)
        {
            int position = name.IndexOf('{');
            return name.Substring(position + 1, name.Length - 2 - position);
        }

     
       
        private void RefreshListView()
        {
            this.listViewUredjaji.Items.Clear();
            List<RegionalniHubPregled> stanice = DTOManager.VratiGlavneStaniceSaRegionima();

            foreach (RegionalniHubPregled stanica in stanice)
            {
                ListViewItem item = new ListViewItem(new string[]
                                {stanica.Id.ToString(), stanica.SerijskiBroj, stanica.NazivProizvodjaca, stanica.UpotrebaOd.ToString(),
                                stanica.ZadnjiServis.ToString(), stanica.RazlogServisa, stanica.RegionalniHubFlag.ToString(),
                                    stanica.NazivRegiona });

                listViewUredjaji.Items.Add(item);
            }


        }

        private void KomunikacioniCvorDodavanje_Load_1(object sender, EventArgs e)
        {
            this.Text = "DODAVANJE CVORA";
            this.RefreshListView();
        }

        private void listViewUredjaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUredjaji.SelectedItems.Count == 1)
            {
                string number = parseCvorName(listViewUredjaji.SelectedItems[0].SubItems[1].ToString());
                //KomunikacioniCvorPregled cvor = DTOManager.VratiKomunikacioniCvor(Int32.Parse(number));

                txtSerijskiBroj.Text = number;


            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int broj;
            KomunikacioniCvorBasic noviCvor = new KomunikacioniCvorBasic();

            noviCvor.SerijskiBroj = txtSerijskiBrojInsert.Text;
            if (txtSerijskiBroj.Text == String.Empty)
            {
                return;
            }
            if (DTOManager.PostojiUredjajSaDatimSerijskimBrojem(noviCvor.SerijskiBroj))
            {
                MessageBox.Show("POSTOJI UREDJAJ SA DATIM SERIJSKIM BROJEM!");
                return;
            }


            noviCvor.NazivProizvodjaca = txtNazivProizvodjaca.Text;
            noviCvor.UpotrebaOd = DateTime.Parse(dateUpotrebaOd.Text);
            noviCvor.ZadnjiServis = DateTime.Parse(dateZadnjiServis.Text);
            noviCvor.RazlogServisa = txtRazlogServisa.Text;
            noviCvor.Opis = txtOpis.Text;
            noviCvor.Grad = txtGrad.Text;
            noviCvor.Ulica = txtUlica.Text;
            if (!Int32.TryParse(txtBrojZgrade.Text, out broj))
            {
                MessageBox.Show("Nije lepo unesen broj zgrade");
                return;
            }
            noviCvor.BrojZgrade = broj;
            noviCvor.TipVeze = txtTipVeze.Text;
            noviCvor.Stanica = new GlavnaStanicaBasic();
            GlavnaStanicaBasic stanica = DTOManager.VratiGlavnuStanicu(DTOManager.VratiIdUredjaja(txtSerijskiBroj.Text));
            noviCvor.Stanica = stanica;

            int idUredjaja = DTOManager.VratiIdUredjaja(txtSerijskiBroj.Text);

            DTOManager.DodajKomunikacioniCvor(idUredjaja,  noviCvor);
        }
    }
}
