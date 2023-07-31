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
    public partial class IzmeniFlat : Form
    {
        public IzmeniFlat(int m, string a1,string a2)
        {
            InitializeComponent();
            this.mesecna = m;
            this.a1=a1;
            this.a2 = a2;
        }
        public int mesecna { get; set; }
        public string a1{ get; set; }
        public string a2 { get; set; }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonZapamti_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.mesecna =Int32.Parse( textBoxMes.Text);
            this.a1 = textBoxA1.Text;
            this.a2 = textBoxA2.Text;
        }
    }
}
