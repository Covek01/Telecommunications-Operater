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
    public partial class KlijentForm : Form
    {

       // List<KlijentPregled> klijenti;
        private List<PravnoLicePregled> pravnaLica;
        private List<FizickoLicePregled> fizickaLica;
        private List<int> selectedIds;
        public KlijentForm()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            lvKlijenti.Items.Clear();
            lvKlijenti.Columns.Clear();
            lvKlijenti.Columns.Add("Id");
            lvKlijenti.Columns.Add("Naziv");
            lvKlijenti.Columns.Add("Grad");
            lvKlijenti.Columns.Add("Ulica");
            lvKlijenti.Columns.Add("Broj");
            lvKlijenti.Columns.Add("Tip");


            if (checkBoxFizicka.Checked && checkBoxPravna.Checked)
            {


                // klijenti = DTOManager.VratiSveKlijente();
                pravnaLica = DTOManager.VratiSvaPravnaLica();
                fizickaLica = DTOManager.VratiSvaFizickaLica();

                foreach (var p in pravnaLica)
                {
                    lvKlijenti.Items.Add(
                        new ListViewItem(new string[]
                        {
                        p.Id.ToString(),
                        p.Ime,
                        p.Grad,
                        p.Ulica,
                        p.BrojZgrade.ToString(),
                        p.Tip
                        }));
                }

                foreach (var f in fizickaLica)
                {
                    lvKlijenti.Items.Add(
                        new ListViewItem(new string[]
                        {
                        f.Id.ToString(),
                        f.Ime,
                        f.Grad,
                        f.Ulica,
                        f.BrojZgrade.ToString(),
                        f.Tip
                        }));
                }
            }
            else if (checkBoxPravna.Checked)
            {
                lvKlijenti.Columns.Add("Ime Kontakta");
                lvKlijenti.Columns.Add("Matični broj");
                lvKlijenti.Columns.Add("PIB");

                pravnaLica = DTOManager.VratiSvaPravnaLica();

                foreach (var p in pravnaLica)
                {
                    lvKlijenti.Items.Add(
                        new ListViewItem(new string[]
                        {
                        p.Id.ToString(),
                        p.Ime,
                        p.Grad,
                        p.Ulica,
                        p.BrojZgrade.ToString(),
                        p.Tip,
                        p.ImeKontakta,
                        p.MaticniBroj,
                        p.PIB
                        }));
                }
            }else if(checkBoxFizicka.Checked)
            {
                lvKlijenti.Columns.Add("JMBG");

                fizickaLica = DTOManager.VratiSvaFizickaLica();

                foreach (var f in fizickaLica)
                {
                    lvKlijenti.Items.Add(
                        new ListViewItem(new string[]
                        {
                        f.Id.ToString(),
                        f.Ime,
                        f.Grad,
                        f.Ulica,
                        f.BrojZgrade.ToString(),
                        f.Tip,
                        f.JMBG
                        }));
                }
            }
            lvKlijenti.Refresh();
            lvKlijenti.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void KlijentForma_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void checkBoxPravna_CheckedChanged(object sender, EventArgs e)
        {
            this.RefreshData();
            }

        private void checkBoxFizicka_CheckedChanged(object sender, EventArgs e)
        {
            this.RefreshData();
        }
        private void SelectCheck(out bool jestePravnoLice)
        {
            jestePravnoLice = false;
            this.selectedIds = new List<int>();
            foreach (ListViewItem item in lvKlijenti.Items)
            {
                if (lvKlijenti.SelectedItems.Contains(item))
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
        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            bool jestePravnoLice = false;
            SelectCheck(out jestePravnoLice);
            if (this.selectedIds.Count == 0)
            {
                MessageBox.Show("Označite klijenta koga želite da izmenite");
            }
            else
            if (this.selectedIds.Count == 1)
            {
                if (jestePravnoLice)
                {
                    new KlijentPravnoLiceIzmena(this.selectedIds[0]).ShowDialog();
                }
                else
                {
                    new KlijentFizickoLiceIzmena(this.selectedIds[0]).ShowDialog();
                }
                this.RefreshData();
            }
            else
            {
                MessageBox.Show("Označite jednog klijenta");
            }
            
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            bool jestePravnoLice = false;
            SelectCheck(out jestePravnoLice);

            if(this.selectedIds.Count ==0) {
                MessageBox.Show("Označite klijenta/klijente koje želite da obišete");
            }else
                if(this.selectedIds.Count == 1)
            {
                DTOManager.ObrisiKlijenta(this.selectedIds[0]);
                this.RefreshData();
            }
            else
            {
                DTOManager.ObrisiKlijente(this.selectedIds);
                this.RefreshData();
            }

        }

        private void buttonBrojeviTelefona_Click(object sender, EventArgs e)
        {
            bool jestePravnoLice = false;
            SelectCheck(out jestePravnoLice);

            if (this.selectedIds.Count == 0)
            {
                MessageBox.Show("Označite klijenta čije kontakt informacije želite da vidite");
            }
            else
          if (this.selectedIds.Count == 1)
            {
                if (jestePravnoLice)
                {
                    new PravnoLiceKontakt(this.selectedIds[0]).ShowDialog();
                }
                else
                {
                    new FizickoLiceKontakt(this.selectedIds[0]).ShowDialog();
                }
                this.RefreshData();
            }
            else
            {
                MessageBox.Show("Označite jednog klijenta");
            }
        }
    }
}
