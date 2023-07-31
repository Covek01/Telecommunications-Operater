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
    public partial class PrikazUgovora : Form
    {
        private int idKorisnika;
        private List<UgovorSaUslugama> ugovori;
        private int SelectedUgovorId;
        public PrikazUgovora(int id)
        {
            InitializeComponent();
            this.idKorisnika=id;
            this.ugovori=new List<UgovorSaUslugama>();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrikazUgovora_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            listViewUgovori.Items.Clear();

            this.ugovori = DTOManager.VratiUgovoreSaUslugama(this.idKorisnika);
            
            foreach(var u in ugovori)
            {
                string usluge = this.ListOfStringToString(u.usluge);
                listViewUgovori.Items.Add(
                    new ListViewItem(new string[]
                    {
                        u.ugovor.Id.ToString(),
                        u.ugovor.BrojUgovora.ToString(),
                        usluge
                    }));
            }
        }

        private string ListOfStringToString(List<string> list)
        {
            string result = String.Empty;
            foreach(var l in list) {
                result += l;
                result += ", ";
            }
            if (result.Length > 2)
            {
                result = result.Substring(0, result.Length - 2);
            }
            return result;
        }

        private void SelectCheck()
        {
            foreach(ListViewItem item in listViewUgovori.Items)
            {
                if (item.Selected)
                {
                    this.SelectedUgovorId = Int32.Parse(item.SubItems[0].Text);
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            new DodajUgovor(this.idKorisnika).ShowDialog();
            RefreshData();

        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            SelectCheck();
            DTOManager.ObrisiUgovor(this.SelectedUgovorId);
            RefreshData();
        }
    }
}
