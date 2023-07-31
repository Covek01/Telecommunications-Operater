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
    public partial class DodajPaketeKanalima : Form
    {
        public List<UslugaPaketKanalId> kanali { get; set; }
        public List<UslugaPaketKanalId> selectedKanali { get; set; }

        public DodajPaketeKanalima()
        {
            InitializeComponent();
            kanali = new List<UslugaPaketKanalId>();
            selectedKanali =new List<UslugaPaketKanalId>();
        }

        private void DodajPaketeKanalima_Load(object sender, EventArgs e)
        {
            this.kanali = DTOManager.VratiSveKanaleSaPaketom();

            RefreshData();
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            SelectCheck();
            if (selectedKanali.Count == 0)
            {
                DialogResult=DialogResult.Cancel;
            }
        }

        private void RefreshData()
        {
            listView1.Items.Clear();
            foreach(var k in this.kanali)
            {
                listView1.Items.Add(new ListViewItem(new string[]
                {
                    k.kanalId.ToString(),
                    k.KanalIme,
                    k.PaketIme

                }));
            }
        }

        private void SelectCheck()
        {
            this.selectedKanali.Clear();
            foreach(ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    this.selectedKanali.Add(kanali[item.Index]);
                }
            }
        }
    }
}
