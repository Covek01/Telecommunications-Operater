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
    public partial class FizickoLiceDodavanje : Form
    {
        public FizickoLiceDodavanje()
        {
            InitializeComponent();
        }

        private void FizickoLiceDodavanje_Load(object sender, EventArgs e)
        {
            this.Text = "DODAVANJE FIZICKOG LICA";
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

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtJMBG.Text.Length != 13)
            {
                MessageBox.Show("LOS JMBG!");
                return;
            }
            int broj;
            string ime = txtIme.Text;
            string grad = txtGrad.Text;
            string ulica = txtUlica.Text;
            if (!Int32.TryParse(txtBroj.Text, out broj))
            {
                MessageBox.Show("Nije lepo unesen broj zgrade");
                return;
            }
            string jmbg = txtJMBG.Text;

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

            FizickoLiceBasic fizLice = new FizickoLiceBasic();

            fizLice.Ime = ime;
            fizLice.Grad = grad;
            fizLice.Ulica = ulica;
            fizLice.BrojZgrade = broj;
            fizLice.JMBG = jmbg;



            fizLice.PovezanNaCvor = DTOManager.VratiKomunikacioniCvorBasic(DTOManager.VratiIdUredjaja(txtCvor.Text));
            DTOManager.DodajFizickoLice(fizLice);

        }


        private string parseCvorName(string name)
        {
            int position = name.IndexOf('{');
            return name.Substring(position + 1, name.Length - 2 - position);
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
