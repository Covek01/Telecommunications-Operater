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
    public partial class PravnoLiceKontakt : Form
    {
        private int idKlijenta;
        private List<string> brojevi;
        private List<string> faksevi;

        private List<string> selectedBrojevi = new List<string>();
        private List<string> selectedFaksevi = new List<string>();

        public PravnoLiceKontakt(int id)
        {
            InitializeComponent();
            this.idKlijenta = id;
        }

        private void PravnoLiceKontakt_Load(object sender, EventArgs e)
        {
          
            RefreshData();

        }

        private void RefreshData()
        {
            this.brojevi = new List<string>();
            this.brojevi = DTOManager.VratiSveTelBrojeveKlijent(this.idKlijenta);
            this.faksevi = new List<string>();
            this.faksevi = DTOManager.VratiSveFaksBrojeveKlijent(this.idKlijenta);

            listViewFaks.Items.Clear();
            listViewTel.Items.Clear();
            foreach (var b in this.brojevi)
            {
                listViewTel.Items.Add(
                    new ListViewItem(new string[]
                    {
                        b
                    }));
            }
           // listViewTel.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            foreach (var f in this.faksevi)
            {
                listViewFaks.Items.Add(
                    new ListViewItem(new string[]
                    {
                        f
                    }));
            }
            //listViewFaks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


        }
        private void SelectCheck()
        {
            
            this.selectedBrojevi = new List<string>();
            this.selectedFaksevi = new List<string>();
            foreach (ListViewItem item in listViewTel.Items)
            {
                if (listViewTel.SelectedItems.Contains(item))
                {
                    this.selectedBrojevi.Add(item.Text);
                }
            }
            foreach (ListViewItem item in listViewFaks.Items)
            {
                if (listViewFaks.SelectedItems.Contains(item))
                {
                    this.selectedFaksevi.Add(item.Text);
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
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
                new BrojTelefonaIzmena(this.selectedBrojevi[0], this.idKlijenta).ShowDialog();
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
        }

        private void buttonDodajFaks_Click(object sender, EventArgs e)
        {
            new DodajFaksBroj(this.idKlijenta).ShowDialog();
            RefreshData();
        }

        private void buttonIzmeniFaks_Click(object sender, EventArgs e)
        {
            SelectCheck();
            if (this.selectedFaksevi.Count == 1)
            {
                new BrojFaksaIzmena(this.selectedFaksevi[0], this.idKlijenta).ShowDialog();
                RefreshData();

            }
            else if (this.selectedFaksevi.Count == 0)
            {
                MessageBox.Show("Izaberite broj koji želite da menjate");
            }
            else
            {
                MessageBox.Show("Izaberite samo jedan broj za izmenu");
            }
        }

        private void buttonObrisiFaks_Click(object sender, EventArgs e)
        {
            SelectCheck();
            if (this.selectedFaksevi.Count == 1)
            {
                DTOManager.IzbrisiFaksPravnogLica(this.idKlijenta, this.selectedFaksevi[0]);
                RefreshData();
            }
            else if (this.selectedFaksevi.Count == 0)
            {
                MessageBox.Show("Izaberite faks broj koji želite da obrišete");
            }
            else
            {
                MessageBox.Show("Izaberite samo jedan faks broj za brisanje");
            }
        }
    }
}
