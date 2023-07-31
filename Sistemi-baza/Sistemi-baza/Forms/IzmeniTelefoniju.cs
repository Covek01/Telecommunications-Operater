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
    public partial class IzmeniTelefoniju : Form
    {
        public IzmeniTelefoniju(int prethodniM, string broj)
        {
            InitializeComponent();
            this.prethodniMesec = 0;
            this.prethodniMesec = prethodniM;
            this.broj=broj;
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

        private void IzmeniTelefoniju_Load(object sender, EventArgs e)
        {
            textBoxOperater.Text = this.broj.Substring(0, 3);
            textBoxBroj.Text=this.broj.Substring(4,this.broj.Length-4);
            textBoxPrMes.Text=this.prethodniMesec.ToString();
        }
    }
}
