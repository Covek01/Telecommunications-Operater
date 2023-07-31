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
    public partial class KlijentPravnoLiceIzmena : Form
    {
        private int id;
        private PravnoLicePregled korisnik = new PravnoLiceBasic();
        private int komCvorId;
        public KlijentPravnoLiceIzmena(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void KlijentPravnoLiceIzmena_Load(object sender, EventArgs e)
        {
            labelIDValue.Text = this.id.ToString();

            korisnik = DTOManager.VratiPravnoLice(this.id);
            textBoxNaziv.Text = korisnik.Ime;
            textBoxGrad.Text = korisnik.Grad;
            textBoxUlica.Text = korisnik.Ulica;
            textBoxBroj.Text = korisnik.BrojZgrade.ToString();
            textBoxImeKont.Text = korisnik.ImeKontakta;
            textBoxMatBroj.Text = korisnik.MaticniBroj;
            textBoxPIB.Text = korisnik.PIB;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonZapamti_Click(object sender, EventArgs e)
        {
            korisnik.Ime = textBoxNaziv.Text;
            korisnik.Grad = textBoxGrad.Text;
           korisnik.Ulica=textBoxUlica.Text;
            korisnik.BrojZgrade = Int32.Parse(textBoxBroj.Text);
            korisnik.ImeKontakta = textBoxImeKont.Text;
           korisnik.MaticniBroj=textBoxMatBroj.Text;
            korisnik.PIB = textBoxPIB.Text;

            if (!textBoxMatBroj.Text.All(char.IsDigit))
            {
                MessageBox.Show("Matični broj se sastoji samo od cifara");
            }
            else if (!textBoxPIB.Text.All(char.IsDigit))
            {
                MessageBox.Show("PIB se sastoji samo od cifara");

            }
            else
            {
                DTOManager.IzmeniPravnoLicePregled(korisnik);
                if (this.komCvorId != 0)
                {
                    DTOManager.PromeniCvorKlijentu(korisnik.Id, this.komCvorId);
                }
                
            }

            this.Close();
        }

        private void buttonPromeniKomCvor_Click(object sender, EventArgs e)
        {
            KlijentIzmenaKomCvora f = new KlijentIzmenaKomCvora(this.id);
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.komCvorId = f.cvorIzabran;
                // MessageBox.Show(this.komCvorId.ToString());
            }
            else
            {
                this.komCvorId = -1;
            }
        }

        private void textBoxPIB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMatBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxImeKont_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBroj_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUlica_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGrad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTipValue_Click(object sender, EventArgs e)
        {

        }

        private void labelTip_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void labelNaziv_Click(object sender, EventArgs e)
        {

        }

        private void labelGrad_Click(object sender, EventArgs e)
        {

        }

        private void labelUlica_Click(object sender, EventArgs e)
        {

        }

        private void labelBroj_Click(object sender, EventArgs e)
        {

        }
    }
}
