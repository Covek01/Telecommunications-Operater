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
    public partial class GlavnaStanicaMenjanje : Form
    {
        public GlavnaStanicaMenjanje()
        {
            InitializeComponent();
        }

        private void checkRegionalniHub_CheckedChanged(object sender, EventArgs e)
        {
            txtNazivRegiona.ReadOnly = !txtNazivRegiona.ReadOnly;
        }

        private void setCheckRegionalniHub(bool value)
        {
            checkRegionalniHub.Checked = value;
            if (value == true)
            {
                txtNazivRegiona.ReadOnly = false;
            }
            else
            {
                txtNazivRegiona.ReadOnly = true;
            }
        }

        private void GlavnaStanicaMenjanje_Load(object sender, EventArgs e)
        {
            this.Text = "MENJANJE GLAVNOG UREDJAJA";
            this.RefreshListView();

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

        private string parseCvorName(string name)
        {
            int position = name.IndexOf('{');
            return name.Substring(position + 1, name.Length - 2 - position);
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
                string regionalniHubFlag = parseCvorName(listViewUredjaji.SelectedItems[0]
                                    .SubItems[6].ToString());


                txtSerijskiBroj.Text = serijskiBroj;
                txtNazivProizvodjaca.Text = nazivProizvodjaca;
                dateUpotrebaOd.Text = upotrebaOd;
                dateZadnjiServis.Text = zadnjiServis;
                txtRazlogServisa.Text = razlogServisa;
                
                if (regionalniHubFlag == "Y")
                {
                    this.setCheckRegionalniHub(true);
                    string nazivRegiona = parseCvorName(listViewUredjaji.SelectedItems[0]
                                    .SubItems[7].ToString());
                    txtNazivRegiona.Text = nazivRegiona;
                }
                else
                {
                    this.setCheckRegionalniHub(false);
                    txtNazivRegiona.Text = String.Empty;
                }
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


            RegionalniHubPregled noviCvor = new RegionalniHubPregled();
            noviCvor.SerijskiBroj = txtSerijskiBroj.Text;
            noviCvor.NazivProizvodjaca = txtNazivProizvodjaca.Text;
            noviCvor.UpotrebaOd = DateTime.Parse(dateUpotrebaOd.Text);
            noviCvor.ZadnjiServis = DateTime.Parse(dateZadnjiServis.Text);
            noviCvor.RazlogServisa = txtRazlogServisa.Text;
            if (checkRegionalniHub.Checked == true)
            {
                noviCvor.RegionalniHubFlag = 'Y';
                if (txtNazivRegiona.Text == String.Empty)
                {
                    MessageBox.Show("UNESI IME REGIONA!");
                    return;
                }
                if (DTOManager.PostojiGlavnaStanicaZaDatiRegion(txtNazivRegiona.Text))
                {
                    MessageBox.Show("DATI REGION VEC POSTOJI! Promenite ime regiona");
                    return;
                }
            }
            else
            {
                noviCvor.RegionalniHubFlag = 'N';
            }
            noviCvor.NazivRegiona = txtNazivRegiona.Text; 
            

            int idUredjaja = DTOManager.VratiIdUredjaja(txtSerijskiBroj.Text);

            DTOManager.IzmeniStatusGlavneStanice(idUredjaja, noviCvor);

            MessageBox.Show("Uspesno promenjena glavna stanica");
            this.RefreshListView();
        }
    }
}
