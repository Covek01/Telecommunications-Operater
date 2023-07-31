using Antlr.Runtime.Tree;
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
    public partial class PaketiForm : Form
    {
        private List<PaketKanalaBasic> PaketiKanala { get; set; }

        public PaketiForm()
        {
            InitializeComponent();
            this.PaketiKanala = new List<PaketKanalaBasic>();
        }

        private void listViewKanali_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKanali.SelectedItems.Count == 1)
            {
                //var paket = this.PaketiKanala.Find(p => p.Id == GetIdFromSelectedRowInPaketi());
                this.OsveziKanale(GetIdFromSelectedRowInPaketi());

            }
        }

        private void PaketiForm_Load(object sender, EventArgs e)
        {
            this.Text = "PAKETI KANALA";
            this.OsveziPodatke();
        }

        private void OsveziPodatke()
        {
            listViewPaketi.Items.Clear();
            listViewKanali.Items.Clear();
            List<PaketKanalaPregled> paketiKanala = DTOManager.VratiSvePaketeKanala();

            foreach(PaketKanalaPregled paket in paketiKanala)
            {
                ListViewItem item = new ListViewItem(new string[] { paket.Id.ToString(), paket.Ime });

                listViewPaketi.Items.Add(item);

                
            }

            
        }

        private void OsveziKanale(int idPaketa)
        {
            listViewKanali.Items.Clear();

            List<KanaliPregled> kanali = DTOManager.VratiSveKanaleZaPaket(idPaketa);

            foreach(KanaliPregled kanal in kanali)
            {
                ListViewItem item = new ListViewItem(new string[]{ kanal.Id.ToString(), kanal.ImeKanala });

                listViewKanali.Items.Add(item);
            }
        }

        private int GetIdFromSelectedRowInPaketi()
        {
            return Int32.Parse(parseCvorName(listViewPaketi.SelectedItems[0].ToString()));
        }

        private int GetIdFromSelectedRowInPaketi(ListViewItem item)
        {
            return Int32.Parse(parseCvorName(item.ToString()));
        }

      
        private List<int> GetIdsFromSelectedRowsInPaketi()
        {
            List<int> ids = new List<int>();

            foreach(ListViewItem item in  listViewPaketi.SelectedItems)
            {
                ids.Add(this.GetIdFromSelectedRowInPaketi(item));
            }

            return ids;
        }

        private List<int> GetIdsFromSelectedRowsInKanali()
        {
            List<int> ids = new List<int>();

            foreach (ListViewItem item in listViewKanali.SelectedItems)
            {
                ids.Add(this.GetIdFromSelectedRowInKanali(item));
            }

            return ids;
        }

        private int GetIdFromSelectedRowInKanali(ListViewItem item)
        {
            return Int32.Parse(parseCvorName(item.ToString()));
        }

        private string parseCvorName(string name)
        {
            int position = name.IndexOf('{');
            return name.Substring(position + 1, name.Length - 2 - position);
        }

        private void UredjajForma_Load(object sender, EventArgs e)
        {

            this.Text = "PAKETI KANALA";

            this.OsveziPodatke();

        }

        private void listViewKanali_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        private void listViewPaketi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPaketi.SelectedItems.Count == 1)
            {
                //var paket = this.PaketiKanala.Find(p => p.Id == GetIdFromSelectedRowInPaketi());
                this.OsveziKanale(GetIdFromSelectedRowInPaketi());
                string proba = listViewPaketi.SelectedItems[0].SubItems[1].ToString();
                lblImePaketaSet.Text = this.parseCvorName(listViewPaketi.SelectedItems[0].SubItems[1].ToString());
            }
        }

        private void btnDodajPaket_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PaketDodavanje().ShowDialog();
        }

        private void btnDodajKanal_Click(object sender, EventArgs e)
        {
            if (txtImeKanala.Text == String.Empty)
            {
                MessageBox.Show("UNESI IME KANALA");
                return;
            }
            DTOManager.DodajKanalZaPaket(txtImeKanala.Text, lblImePaketaSet.Text);
        }

        private void btnObrisiPaket_Click(object sender, EventArgs e)
        {
            if (listViewPaketi.SelectedItems.Count == 0)
            {
                MessageBox.Show("SELEKTUJ PAKETE KOJE HOCES DA BRISES.");
                return;
            }

            List<int> idjevi = this.GetIdsFromSelectedRowsInPaketi();

            DTOManager.ObrisiPaketeKanala(idjevi);

            this.OsveziPodatke();
        }

        private void btnObrisiKanal_Click(object sender, EventArgs e)
        {
            if (listViewKanali.SelectedItems.Count == 0)
            {
                MessageBox.Show("SELEKTUJ KANALE ZA BRISANJE");
                return;
            }
            List<int> ids = this.GetIdsFromSelectedRowsInKanali();

            bool flag = DTOManager.ObrisiKanale(ids);
            

        }

        private void lblUlica_Click(object sender, EventArgs e)
        {

        }
    }
}
