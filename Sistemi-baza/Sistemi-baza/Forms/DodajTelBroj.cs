﻿using System;
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
    public partial class DodajTelBroj : Form
    {
        private int id;
        public DodajTelBroj(int id)
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
                if(DTOManager.DodajTelBroj(this.id,this.textBox1.Text))
                this.Close();
            }
            else
            {
                MessageBox.Show("Pogrešan format broja");
            }
        }

        private bool Validate(string broj)
        {
            bool valid = true;
            string pom = broj.Substring(0, 3) + broj.Substring(4, broj.Length - 4);
            if (broj[3] != '/') return false;
            foreach (char c in pom)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return valid;
        }
    }
}
