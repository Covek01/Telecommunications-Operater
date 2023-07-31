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
    public partial class UredjajForm : Form
    {
        public int UredjajIdBrisanje { get; set; }

        public UredjajForm()
        {
            InitializeComponent();
            this.UredjajIdBrisanje = -1;
        }

        private void UredjajForma_Load(object sender, EventArgs e)
        {
            comboTipovi.Items.Add("Fizicko");
            comboTipovi.Items.Add("Pravno");
            comboTipovi.Text = comboTipovi.Items[0].ToString();


            this.Text = "UREDJAJI";

            this.OsveziPodatke();
            
        }

        private void OsveziPodatke()
        {
            listViewUredjaji.Items.Clear();
            List<UredjajPregled> uredjaji = DTOManager.VratiSveUredjaje();

            foreach (UredjajPregled u in uredjaji)
            {
                string tip;


                ListViewItem item = new ListViewItem(new string[]{ u.Id.ToString(), u.SerijskiBroj,
                    u.NazivProizvodjaca, u.UpotrebaOd.ToString(), u.ZadnjiServis.ToString(), u.Tip_uredjaja});

                listViewUredjaji.Items.Add(item);
            }
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            if (comboTipovi.Text == "Fizicko")
            {
                new FizickoLiceDodavanje().ShowDialog();
            }
            else
            {
                new PravnoLiceDodavanje().ShowDialog();
            }
        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            new GlavnaStanicaDodavanje() .ShowDialog();
        }

        private void btnObrisiUredjaj_Click(object sender, EventArgs e)
        {
            if (listViewUredjaji.SelectedItems.Count == 0)
            {
                MessageBox.Show("SELEKTUJ UREDJAJ ZA BRISANJE!");
                return;
            }
            DTOManager.ObrisiUredjaj(this.UredjajIdBrisanje);
            MessageBox.Show("Uspesno brisanje uredjaja sa id-jem " + this.UredjajIdBrisanje);
            this.OsveziPodatke();
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
                this.UredjajIdBrisanje = Int32.Parse(parseCvorName(listViewUredjaji.SelectedItems[0].ToString()));
            }
            else if(listViewUredjaji.SelectedItems.Count > 1)
            {
                MessageBox.Show("SELEKTUJTE 1 SAMO UREDJAJ ZA BRISANJE");
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            new KomunikacioniCvorMenjanje() .ShowDialog();
        }

        private void btnDodajCvor_Click(object sender, EventArgs e)
        {
            new KomunikacioniCvorDodavanje().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GlavnaStanicaMenjanje().Show();
        }
    }
}
