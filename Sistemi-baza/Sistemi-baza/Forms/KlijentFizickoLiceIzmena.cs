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
    public partial class KlijentFizickoLiceIzmena : Form
    {
        private int id;
        private FizickoLicePregled korisnik = new FizickoLiceBasic();
        private int komCvorId;
        public KlijentFizickoLiceIzmena(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void KlijentFizickoLiceIzmena_Load(object sender, EventArgs e)
        {
            labelIDValue.Text = this.id.ToString();

            korisnik = DTOManager.VratiFizickoLice(this.id);
            textBoxNaziv.Text = korisnik.Ime;
            textBoxGrad.Text = korisnik.Grad;
            textBoxUlica.Text = korisnik.Ulica;
            textBoxBroj.Text = korisnik.BrojZgrade.ToString();
            textJMBG.Text=korisnik.JMBG;
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
            korisnik.JMBG = textJMBG.Text;

            if (!textJMBG.Text.All(char.IsDigit))
            {
                MessageBox.Show("JMBG se sastoji samo od cifara");
            }
            else
            {
                DTOManager.IzmeniFizickoLicePregled(korisnik);
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
    }
}
