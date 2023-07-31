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
    public partial class DodajTelefoniju : Form
    {
        public DodajTelefoniju()
        {
            InitializeComponent();
            this.prethodniMesec = 0;
        }
        public string broj { get; set; }
        public int prethodniMesec { get; set; }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateNumber())
            {
                MessageBox.Show("Broj već postoji");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.broj = textBoxOperater.Text + "/" + textBoxBroj.Text;
                this.prethodniMesec=Int32.Parse(textBoxPrMes.Text);
                this.Close();
            }
        }
        private bool ValidateNumber()
        {
            if(textBoxOperater.Text.Length != 3|| !textBoxOperater.Text.All(Char.IsDigit)) 
            {
                return false;
            }
            if (!textBoxBroj.Text.All(Char.IsDigit))
                return false;
            if (!DTOManager.JedinstvenBroj(textBoxOperater.Text + "/" + textBoxBroj.Text))
                return false;

            return true;
        }

        private void labelBroj_Click(object sender, EventArgs e)
        {

        }

        private void labelPrethodniMesec_Click(object sender, EventArgs e)
        {

        }

        private void labelPrve3_Click(object sender, EventArgs e)
        {

        }
    }
}
