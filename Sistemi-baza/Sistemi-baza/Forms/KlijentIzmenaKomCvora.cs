using NHibernate.Action;
using NHibernate.Mapping.ByCode;
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
    public partial class KlijentIzmenaKomCvora : Form
    {
        private List<KomunikacioniCvorPregled> komCvorovi;
        private int id;
        private KomunikacioniCvorPregled izabranCvor;

        public int cvorIzabran { get;private set; }
        public KlijentIzmenaKomCvora(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            cvorIzabran = -1;
            this.Close();
        }

        private void buttonIzaberi_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
            int numOfSelected = 0;
            foreach(ListViewItem item in lvIzmenaKomCvora.Items)
            {
                if (item.Selected)
                {
                    numOfSelected++;
                    cvorIzabran = Int32.Parse(item.SubItems[0].Text);
                }
            }

            if (numOfSelected != 1)
            {
                MessageBox.Show("Označite jedan komunikacioni čvor");
            }
            else
            {
                this.Close();
            }
        }

        private void KlijentIzmenaKomCvora_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }
        public void RefreshData()
        {
            komCvorovi = DTOManager.VratiSveNepuneKomCvorove();
            foreach (var cvor in komCvorovi)
            {
                lvIzmenaKomCvora.Items.Add(
                    new ListViewItem(new string[]
                    {
                        cvor.Id.ToString(),
                        cvor.Grad,
                        cvor.Ulica,
                        cvor.BrojZgrade.ToString()
                    }));
            }
            int cvorId = DTOManager.VratiIdKomCvora(this.id);

            foreach (ListViewItem item in lvIzmenaKomCvora.Items)
            {
                if (item.SubItems[0].Text==cvorId.ToString())
                {
                    item.Selected = true;
                }
            }

        }
    }
}
