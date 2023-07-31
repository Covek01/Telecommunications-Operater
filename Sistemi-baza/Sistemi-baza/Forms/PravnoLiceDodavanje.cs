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
    public partial class PravnoLiceDodavanje : Form
    {
        public PravnoLiceDodavanje()
        {
            InitializeComponent();
        }

        private void PravnoLiceDodavanje_Load(object sender, EventArgs e)
        {
            this.Text = "DODAVANJE PRAVNOG LICA";
            this.PopuniPodacimaIzBaze();
        }

        private void PopuniPodacimaIzBaze()
        {
            listViewCvorovi.Items.Clear();
            List<KomunikacioniCvorPregled> listaCvorova = DTOManager.VratiSveCvorove();

            foreach (KomunikacioniCvorPregled cvor in listaCvorova)
            {
                ListViewItem item = new ListViewItem(new string[]
                { cvor.SerijskiBroj, cvor.NazivProizvodjaca});
                listViewCvorovi.Items.Add(item);
            }
            listViewCvorovi.Refresh();
        }

        private string parseCvorName(string name)
        {
            int position = name.IndexOf('{');
            return name.Substring(position + 1, name.Length - 2 - position);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            

            string ime = txtIme.Text;
            string grad = txtGrad.Text;
            string ulica = txtUlica.Text;
            int broj;
            if (!Int32.TryParse(txtBroj.Text, out broj))
            {
                MessageBox.Show("Nije lepo unesen broj zgrade");
                return;
            }
            string maticniBroj = txtMaticniBroj.Text;
            string PIB = txtPIB.Text; 

            if (maticniBroj.Length > 8)
            {
                MessageBox.Show("Predugacak maticni broj");
                return;
            }
            if (PIB.Length > 8)
            {
                MessageBox.Show("Predugacak PIB");
                return;
            }

            Entiteti.Uredjaj cvor;
            if (txtCvor.Text != string.Empty)
            {
                Entiteti.Uredjaj uredjaj = DTOManager.VratiUredjaj(DTOManager.VratiIdUredjaja(txtCvor.Text));
                cvor = uredjaj;
            }
            else
            {
                MessageBox.Show("Nije specificiran uredjaj");
                return;
            }

            PravnoLiceBasic pravnoLice = new PravnoLiceBasic();

            pravnoLice.Ime = ime;
            pravnoLice.Grad = grad;
            pravnoLice.Ulica = ulica;
            pravnoLice.BrojZgrade = broj;
            pravnoLice.MaticniBroj = maticniBroj;
            pravnoLice.ImeKontakta = txtImeKontakta.Text;
            pravnoLice.PIB = PIB;


            pravnoLice.PovezanNaCvor = DTOManager.VratiKomunikacioniCvorBasic(DTOManager.VratiIdUredjaja(txtCvor.Text));
            DTOManager.DodajPravnoLice(pravnoLice);
        }

        private void listViewCvorovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCvorovi.SelectedItems.Count == 1)
            {
                txtCvor.Text = parseCvorName(listViewCvorovi.SelectedItems[0].ToString());
            }
        }
    }
}
