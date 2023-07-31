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
    public partial class FizickoLiceKontakt : Form
    {
        private int idKlijenta;
        private List<string> brojevi;
        private List<string> selectedBrojevi=new List<string>();

        public FizickoLiceKontakt(int id)
        {
            InitializeComponent();
            this.idKlijenta = id;
        }

        private void FizickoLiceKontakt_Load(object sender, EventArgs e)
        {
                       RefreshData();
        }

        private void RefreshData()
        {
            this.brojevi = new List<string>();
            this.brojevi = DTOManager.VratiSveTelBrojeveKlijent(this.idKlijenta);

            listViewBrojevi.Items.Clear();
            foreach(var b in this.brojevi)
            {
                listViewBrojevi.Items.Add(
                    new ListViewItem(new string[]
                    {
                        b
                    }));
            }
          //  listViewBrojevi.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajTel_Click(object sender, EventArgs e)
        {
            new DodajTelBroj(this.idKlijenta).ShowDialog();
            RefreshData();
        }

        private void buttonIzmeniTel_Click(object sender, EventArgs e)
        {
            SelectCheck();
            if (this.selectedBrojevi.Count == 1)
            {
                new BrojTelefonaIzmena(this.selectedBrojevi[0],this.idKlijenta).ShowDialog();
                RefreshData();
            }
            else if (this.selectedBrojevi.Count == 0)
            {
                MessageBox.Show("Izaberite broj koji želite da menjate");
            }
            else
            {
                MessageBox.Show("Izaberite samo jedan broj za izmenu");
            }
        }

        private void buttonObrisiTel_Click(object sender, EventArgs e)
        {
            SelectCheck();
            if (this.selectedBrojevi.Count == 1)
            {
                DTOManager.IzbrisiBrojKorisnika(this.idKlijenta, this.selectedBrojevi[0]);
                RefreshData();
            }
            else if (this.selectedBrojevi.Count == 0)
            {
                MessageBox.Show("Izaberite broj koji želite da obrišete");
            }
            else
            {
                MessageBox.Show("Izaberite samo jedan broj za brisanje");
            }
            RefreshData();

        }

        private void SelectCheck()
        {
            this.selectedBrojevi = new List<string>();
            foreach (ListViewItem item in listViewBrojevi.Items)
            {
                if (listViewBrojevi.SelectedItems.Contains(item))
                {
                    this.selectedBrojevi.Add(item.Text);
                }
            }
        }

        private void listViewBrojevi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
