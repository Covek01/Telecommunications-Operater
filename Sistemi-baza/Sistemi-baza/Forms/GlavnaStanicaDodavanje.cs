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
    public partial class GlavnaStanicaDodavanje : Form
    {
        public GlavnaStanicaDodavanje()
        {
            InitializeComponent();
        }

        private void btnDodajCvor_Click(object sender, EventArgs e)
        {
            string serBroj = txtBroj.Text;

            if (serBroj[0] != 'S')
            {
                MessageBox.Show("LOS SERIJSKI BROJ!");
                return;
            }

            string nazivProizvodjaca = txtNazivProizvodjaca.Text;
            DateTime upotrebaOd = dateUpotrebaOd.Value.Date;
            DateTime zadnjiServis = dateZadnjiServis.Value.Date;
            string razlogServisa = txtRazlogServisa.Text;

            //regFlag = 'N', naziv - NULL

            GlavnaStanicaBasic stanica = new GlavnaStanicaBasic();
            stanica.SerijskiBroj = serBroj;
            stanica.NazivProizvodjaca = nazivProizvodjaca;
            stanica.UpotrebaOd = upotrebaOd;
            stanica.ZadnjiServis = zadnjiServis;
            stanica.RazlogServisa = razlogServisa;
            stanica.RegionalniHubFlag = 'N';

            if (upotrebaOd > DateTime.Now)
            {
                MessageBox.Show("VREME NIJE NEGATIVNO! Datum pocetne upotrebe glavne stanice");
                return;
            }
            if (zadnjiServis > DateTime.Now)
            {
                MessageBox.Show("VREME NIJE NEGATIVNO! Ne mozete predvideti kvar u buducnosti");
                return;
            }

            DTOManager.DodajGlavnuStanicu(stanica);

        }
    }
}
