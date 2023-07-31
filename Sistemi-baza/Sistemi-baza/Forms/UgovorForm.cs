using NHibernate.Type;
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
using Telekomunikacija.Entiteti;

namespace Telekomunikacija.Forms
{
    public partial class UgovorForm : Form
    {
        private List<FizickoLicePregled> fizickaLica;
        private List<PravnoLicePregled> pravnaLica;
        private List<KlijentPregled> klijenti;
        private List<int> selectedIds;

        public UgovorForm()
        {
            InitializeComponent();
            this.fizickaLica = new List<FizickoLicePregled>();
            this.pravnaLica = new List<PravnoLicePregled>();
            this.klijenti = new List<KlijentPregled>();
            this.selectedIds = new List<int>();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUgovori_Click(object sender, EventArgs e)
        {
            bool jestePravnoLice = false;
            SelectCheck(out jestePravnoLice);
            if (this.selectedIds.Count == 0)
            {
                MessageBox.Show("Označite korisnika čije ugovore želite da vidite");
            }
            else
            {
                new PrikazUgovora(this.selectedIds[0]).Show();
                RefreshData();
            }
        }

        private void UgovorForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            listViewKlijenti.Items.Clear();

            // klijenti = DTOManager.VratiSveKlijente();
            pravnaLica = DTOManager.VratiSvaPravnaLica();
            fizickaLica = DTOManager.VratiSvaFizickaLica();

            foreach (var p in pravnaLica)
            {
                listViewKlijenti.Items.Add(
                    new ListViewItem(new string[]
                    {
                        p.Id.ToString(),
                        p.Ime,
                        p.Grad,
                        p.Ulica,
                        p.BrojZgrade.ToString(),
                        p.Tip
                    }));
                klijenti.Add(p);
            }

            foreach (var f in fizickaLica)
            {
                listViewKlijenti.Items.Add(
                    new ListViewItem(new string[]
                    {
                        f.Id.ToString(),
                        f.Ime,
                        f.Grad,
                        f.Ulica,
                        f.BrojZgrade.ToString(),
                        f.Tip
                    }));
                klijenti.Add(f);

            }
        }
        private void SelectCheck(out bool jestePravnoLice)
        {
            jestePravnoLice = false;
            this.selectedIds = new List<int>();
            foreach (ListViewItem item in listViewKlijenti.Items)
            {
                if (listViewKlijenti.SelectedItems.Contains(item))
                {
                    int id = Int32.Parse(item.SubItems[0].Text);
                    this.selectedIds.Add(id);
                    if (this.pravnaLica.Any(p => p.Id == id))
                    {
                        jestePravnoLice = true;
                    }
                    else
                    {
                        jestePravnoLice = false;
                    }
                }
            }
        }

        private void buttonUsluge_Click(object sender, EventArgs e)
        {
            bool jePravnoLice = false;
            SelectCheck(out jePravnoLice);
            if (selectedIds.Count == 1)
            {
                new PrikazUsluga(this.selectedIds[0]).Show();
            }
            else
            {
                MessageBox.Show("Označite klijenta čije usluga želite da vidite");
            }
        }
    }
}
