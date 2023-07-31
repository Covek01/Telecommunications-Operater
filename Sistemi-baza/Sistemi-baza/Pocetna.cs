using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telekomunikacija.Entiteti;
using Telekomunikacija.Forms;

namespace Sistemi_baza
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnKlijentForma_Click(object sender, EventArgs e)
        {
            
            new KlijentForm().ShowDialog();
        }

        private void btnUredjajForma_Click(object sender, EventArgs e)
        {
            new UredjajForm().ShowDialog();
        }

        private void btnUslugaForma_Click(object sender, EventArgs e)
        {
            new UgovorForm().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaketi_Click(object sender, EventArgs e)
        {
            new PaketiForm().ShowDialog();
        }
    }
}
