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
    public partial class DodajFaksBroj : Form
    {
        private int id;
        public DodajFaksBroj(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            if (Validate(textBox1.Text))
            {
                if(DTOManager.DodajFaksBroj(this.id, this.textBox1.Text)) 
                this.Close();
            }
            else
            {
                MessageBox.Show("Pogrešan format broja");
            }
        }

        private bool Validate(string br)
        {
            bool valid = true;
            string brToCheck = br.Substring(1, br.Length - 1);
            foreach (char c in brToCheck)
            {
                if (!Char.IsDigit(c)) valid = false; break;
            }
            return valid;
        }
    }
}
