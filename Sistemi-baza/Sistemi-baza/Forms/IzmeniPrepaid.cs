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
    public partial class IzmeniPrepaid : Form
    {
        public IzmeniPrepaid(int s, DateTime d)
        {
            InitializeComponent();
            this.stanje = s;
            this.datumUplate=d;
        }
        public int stanje { get; set; }
        public DateTime datumUplate { get; set; }
        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonZapamti_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.stanje = Int32.Parse(this.textBox1.Text);
            this.datumUplate = DateTime.Parse(dateTimePicker1.Text);
        }
    }
}
