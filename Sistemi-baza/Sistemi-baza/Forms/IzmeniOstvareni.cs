using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telekomunikacija.Forms
{
    public partial class IzmeniOstvareni : Form
    {
        public IzmeniOstvareni(int d, double c,int p)
        {
            InitializeComponent();
            this.danPlac = d;
            this.cenaMB=c;
            this.potroseno =p;
        }
        public int danPlac { get; set; }
        public double cenaMB { get; set; }
        public int potroseno { get; set; }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonZapamti_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.danPlac =Int32.Parse( textBoxDanPlac.Text);
            this.cenaMB = Int32.Parse(textBoxCena.Text);
            this.potroseno = Int32.Parse(textBox2.Text);
        }
    }
}
