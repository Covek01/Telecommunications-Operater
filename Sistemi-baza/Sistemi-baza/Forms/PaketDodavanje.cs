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
    public partial class PaketDodavanje : Form
    {
        public PaketDodavanje()
        {
            InitializeComponent();
        }

        private void btnDodajPaket_Click(object sender, EventArgs e)
        {
            if(txtImePaketa.Text == String.Empty)
            {
                MessageBox.Show("UNESI IME PAKETA!");
                return;
            }
            DTOManager.DodajPaketKanala(txtImePaketa.Text);

            new PaketiForm().ShowDialog();
        }
    }
}
