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
    public partial class KomunikacioniCvorMenjanje : Form
    {
        public KomunikacioniCvorMenjanje()
        {
            InitializeComponent();
        }

        private void listViewUredjaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUredjaji.SelectedItems.Count == 1)
            {
                string number = parseCvorName(listViewUredjaji.SelectedItems[0].SubItems[0].ToString());
                //KomunikacioniCvorPregled cvor = DTOManager.VratiKomunikacioniCvor(Int32.Parse(number));



                string serijskiBroj = parseCvorName(listViewUredjaji.SelectedItems[0]
                                    .SubItems[1].ToString());
                string nazivProizvodjaca = parseCvorName(listViewUredjaji.SelectedItems[0]
                                    .SubItems[2].ToString());
                string upotrebaOd = parseCvorName(listViewUredjaji.SelectedItems[0]
                                    .SubItems[3].ToString());
                string zadnjiServis = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[4].ToString());
                string razlogServisa = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[5].ToString());
                string opis = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[6].ToString());
                string grad = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[7].ToString());
                string ulica = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[8].ToString());
                string brojZgrade = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[9].ToString());
                string tipVeze = parseCvorName(listViewUredjaji.SelectedItems[0]
                                   .SubItems[10].ToString());


                txtSerijskiBroj.Text = serijskiBroj;
                txtNazivProizvodjaca.Text = nazivProizvodjaca;
                dateUpotrebaOd.Text = upotrebaOd;
                dateZadnjiServis.Text = zadnjiServis;
                txtRazlogServisa.Text = razlogServisa;
                txtOpis.Text = opis;
                txtGrad.Text = grad;
                txtUlica.Text = ulica;
                txtBrojZgrade.Text = brojZgrade;
                txtTipVeze.Text = tipVeze;

            }


        }

        private string parseCvorName(string name)
        {
            int position = name.IndexOf('{');
            return name.Substring(position + 1, name.Length - 2 - position);
        }

        private void KomunikacioniCvorMenjanje_Load(object sender, EventArgs e)
        {
            this.Text = "MENJANJE KOMUNIKACIONOG CVORA";
            this.RefreshListView();

            txtTipVeze.Items.Add("Opticki");
            txtTipVeze.Items.Add("Bakarni");
        }

        private void RefreshListView()
        {
            this.listViewUredjaji.Items.Clear();
            List<KomunikacioniCvorPregled> stanice = DTOManager.VratiSveKomunikacioneCvorove();

            foreach (KomunikacioniCvorPregled stanica in stanice)
            {
                ListViewItem item = new ListViewItem(new string[]
                                {stanica.Id.ToString(), stanica.SerijskiBroj, stanica.NazivProizvodjaca, stanica.UpotrebaOd.ToString(),
                                stanica.ZadnjiServis.ToString(), stanica.RazlogServisa, stanica.Opis, stanica.Grad,
                                stanica.Ulica, stanica.BrojZgrade.ToString(), stanica.TipVeze});

                listViewUredjaji.Items.Add(item);
            }


        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            

            if (dateUpotrebaOd.Value > DateTime.Now)
            {
                MessageBox.Show("VREME NIJE NEGATIVNO, poslednja upotreba");
                return;
            }
            if (dateZadnjiServis.Value > DateTime.Now)
            {
                MessageBox.Show("VREME NIJE NEGATIVNO, Zadnji servis");
                return;
            }


            int broj;
            KomunikacioniCvorPregled noviCvor = new KomunikacioniCvorPregled();
            noviCvor.SerijskiBroj = txtSerijskiBroj.Text;
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

            int idUredjaja = DTOManager.VratiIdUredjaja(txtSerijskiBroj.Text);

            DTOManager.IzmeniStatusKomunikacionogCvora(idUredjaja, noviCvor);

            this.RefreshListView();
        }
    }
}
