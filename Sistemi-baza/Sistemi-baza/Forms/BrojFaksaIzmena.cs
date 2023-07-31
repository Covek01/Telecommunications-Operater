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
    public partial class BrojFaksaIzmena : Form
    {
        private string broj;
        private int id;
        public BrojFaksaIzmena(string broj, int id)
        {
            InitializeComponent();
            this.broj = broj;
            this.id = id;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (textBoxFaks.Text.Length == 13 && textBoxFaks.Text[0] == 'F'&&Validate(this.broj))
            {
                if(DTOManager.IzmeniFaksBroj(this.id, this.broj, textBoxFaks.Text))
                this.Close();
            }
            else
            {
                MessageBox.Show("Los format unešenog broja");
            }

      
        }
        private bool Validate(string br)
        {
            bool valid = true;
            string brToCheck=br.Substring(1,br.Length - 1);
            foreach(char c in brToCheck)
            {
                if (!Char.IsDigit(c))valid = false; break;
            }
            return valid;
        }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrojFaksaIzmena_Load(object sender, EventArgs e)
        {
            labelStariBrojFaksValue.Text=this.broj;
        }
    }
}
