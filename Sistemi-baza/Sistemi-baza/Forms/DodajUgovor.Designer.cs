namespace Telekomunikacija.Forms
{
    partial class DodajUgovor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listViewOst = new System.Windows.Forms.ListView();
            this.columnHeaderDanPlacanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPotroseno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCenaMB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFlat = new System.Windows.Forms.ListView();
            this.columnHeaderMesecnaCena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdresa2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTelev = new System.Windows.Forms.ListView();
            this.columnHeaderKanal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPaketKanala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTelef = new System.Windows.Forms.ListView();
            this.columnHeaderBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPre = new System.Windows.Forms.ListView();
            this.columnHeaderStanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdatumUplate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxPrepaid = new System.Windows.Forms.GroupBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonIzbaciPre = new System.Windows.Forms.Button();
            this.buttonDodajPre = new System.Windows.Forms.Button();
            this.groupBoxOstvareni = new System.Windows.Forms.GroupBox();
            this.buttonIzbacOst = new System.Windows.Forms.Button();
            this.buttonIzmeniOst = new System.Windows.Forms.Button();
            this.buttonDodajOst = new System.Windows.Forms.Button();
            this.groupBoxFlat = new System.Windows.Forms.GroupBox();
            this.buttonIzbaciFlat = new System.Windows.Forms.Button();
            this.buttonIzmeniFlat = new System.Windows.Forms.Button();
            this.buttonDodajFlat = new System.Windows.Forms.Button();
            this.groupBoxTelevizija = new System.Windows.Forms.GroupBox();
            this.buttonIzbaciTelev = new System.Windows.Forms.Button();
            this.buttonDodajTelev = new System.Windows.Forms.Button();
            this.groupBoxTelefonija = new System.Windows.Forms.GroupBox();
            this.buttonIzbaciTelef = new System.Windows.Forms.Button();
            this.buttonIzmeniTelef = new System.Windows.Forms.Button();
            this.buttonDodajTelef = new System.Windows.Forms.Button();
            this.groupBoxPrepaid.SuspendLayout();
            this.groupBoxOstvareni.SuspendLayout();
            this.groupBoxFlat.SuspendLayout();
            this.groupBoxTelevizija.SuspendLayout();
            this.groupBoxTelefonija.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonDodaj.Location = new System.Drawing.Point(430, 609);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(78, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonCancel.Location = new System.Drawing.Point(68, 609);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Otkаži";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listViewOst
            // 
            this.listViewOst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDanPlacanja,
            this.columnHeaderPotroseno,
            this.columnHeaderCenaMB});
            this.listViewOst.Font = new System.Drawing.Font("Verdana", 8F);
            this.listViewOst.FullRowSelect = true;
            this.listViewOst.HideSelection = false;
            this.listViewOst.Location = new System.Drawing.Point(3, 17);
            this.listViewOst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewOst.MultiSelect = false;
            this.listViewOst.Name = "listViewOst";
            this.listViewOst.Size = new System.Drawing.Size(492, 82);
            this.listViewOst.TabIndex = 3;
            this.listViewOst.UseCompatibleStateImageBehavior = false;
            this.listViewOst.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDanPlacanja
            // 
            this.columnHeaderDanPlacanja.Text = "Dan Plaćanja";
            this.columnHeaderDanPlacanja.Width = 86;
            // 
            // columnHeaderPotroseno
            // 
            this.columnHeaderPotroseno.Text = "Potrošeno";
            this.columnHeaderPotroseno.Width = 93;
            // 
            // columnHeaderCenaMB
            // 
            this.columnHeaderCenaMB.Text = "Cena Megabajta";
            this.columnHeaderCenaMB.Width = 133;
            // 
            // listViewFlat
            // 
            this.listViewFlat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMesecnaCena,
            this.columnHeaderAdresa1,
            this.columnHeaderAdresa2});
            this.listViewFlat.Font = new System.Drawing.Font("Verdana", 8F);
            this.listViewFlat.FullRowSelect = true;
            this.listViewFlat.HideSelection = false;
            this.listViewFlat.Location = new System.Drawing.Point(2, 23);
            this.listViewFlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewFlat.MultiSelect = false;
            this.listViewFlat.Name = "listViewFlat";
            this.listViewFlat.Size = new System.Drawing.Size(492, 82);
            this.listViewFlat.TabIndex = 4;
            this.listViewFlat.UseCompatibleStateImageBehavior = false;
            this.listViewFlat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderMesecnaCena
            // 
            this.columnHeaderMesecnaCena.Text = "Mesečna cena";
            this.columnHeaderMesecnaCena.Width = 117;
            // 
            // columnHeaderAdresa1
            // 
            this.columnHeaderAdresa1.Text = "Statička adresa 1";
            this.columnHeaderAdresa1.Width = 146;
            // 
            // columnHeaderAdresa2
            // 
            this.columnHeaderAdresa2.Text = "Statička adresa 2";
            this.columnHeaderAdresa2.Width = 160;
            // 
            // listViewTelev
            // 
            this.listViewTelev.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderKanal,
            this.columnHeaderPaketKanala});
            this.listViewTelev.Font = new System.Drawing.Font("Verdana", 8F);
            this.listViewTelev.FullRowSelect = true;
            this.listViewTelev.HideSelection = false;
            this.listViewTelev.Location = new System.Drawing.Point(1, 29);
            this.listViewTelev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewTelev.MultiSelect = false;
            this.listViewTelev.Name = "listViewTelev";
            this.listViewTelev.Size = new System.Drawing.Size(492, 82);
            this.listViewTelev.TabIndex = 5;
            this.listViewTelev.UseCompatibleStateImageBehavior = false;
            this.listViewTelev.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderKanal
            // 
            this.columnHeaderKanal.Text = "Ime Kanala";
            this.columnHeaderKanal.Width = 111;
            // 
            // columnHeaderPaketKanala
            // 
            this.columnHeaderPaketKanala.Text = "Paket Kanala";
            this.columnHeaderPaketKanala.Width = 124;
            // 
            // listViewTelef
            // 
            this.listViewTelef.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBroj});
            this.listViewTelef.Font = new System.Drawing.Font("Verdana", 8F);
            this.listViewTelef.FullRowSelect = true;
            this.listViewTelef.HideSelection = false;
            this.listViewTelef.Location = new System.Drawing.Point(6, 15);
            this.listViewTelef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewTelef.MultiSelect = false;
            this.listViewTelef.Name = "listViewTelef";
            this.listViewTelef.Size = new System.Drawing.Size(492, 82);
            this.listViewTelef.TabIndex = 6;
            this.listViewTelef.UseCompatibleStateImageBehavior = false;
            this.listViewTelef.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBroj
            // 
            this.columnHeaderBroj.Text = "Broj telefona";
            // 
            // listViewPre
            // 
            this.listViewPre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderStanje,
            this.columnHeaderdatumUplate});
            this.listViewPre.Font = new System.Drawing.Font("Verdana", 8F);
            this.listViewPre.FullRowSelect = true;
            this.listViewPre.HideSelection = false;
            this.listViewPre.Location = new System.Drawing.Point(5, 20);
            this.listViewPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewPre.MultiSelect = false;
            this.listViewPre.Name = "listViewPre";
            this.listViewPre.Size = new System.Drawing.Size(492, 82);
            this.listViewPre.TabIndex = 2;
            this.listViewPre.UseCompatibleStateImageBehavior = false;
            this.listViewPre.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderStanje
            // 
            this.columnHeaderStanje.Text = "Stanje";
            // 
            // columnHeaderdatumUplate
            // 
            this.columnHeaderdatumUplate.Text = "Datum Uplate";
            this.columnHeaderdatumUplate.Width = 131;
            // 
            // groupBoxPrepaid
            // 
            this.groupBoxPrepaid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxPrepaid.Controls.Add(this.buttonIzmeni);
            this.groupBoxPrepaid.Controls.Add(this.buttonIzbaciPre);
            this.groupBoxPrepaid.Controls.Add(this.buttonDodajPre);
            this.groupBoxPrepaid.Controls.Add(this.listViewPre);
            this.groupBoxPrepaid.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBoxPrepaid.Location = new System.Drawing.Point(4, 11);
            this.groupBoxPrepaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPrepaid.Name = "groupBoxPrepaid";
            this.groupBoxPrepaid.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPrepaid.Size = new System.Drawing.Size(588, 108);
            this.groupBoxPrepaid.TabIndex = 7;
            this.groupBoxPrepaid.TabStop = false;
            this.groupBoxPrepaid.Text = "Prepaid";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzmeni.Location = new System.Drawing.Point(514, 57);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(60, 20);
            this.buttonIzmeni.TabIndex = 6;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonIzbaciPre
            // 
            this.buttonIzbaciPre.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzbaciPre.Location = new System.Drawing.Point(514, 81);
            this.buttonIzbaciPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzbaciPre.Name = "buttonIzbaciPre";
            this.buttonIzbaciPre.Size = new System.Drawing.Size(60, 20);
            this.buttonIzbaciPre.TabIndex = 5;
            this.buttonIzbaciPre.Text = "Izbaci";
            this.buttonIzbaciPre.UseVisualStyleBackColor = true;
            this.buttonIzbaciPre.Click += new System.EventHandler(this.buttonIzbaciPre_Click);
            // 
            // buttonDodajPre
            // 
            this.buttonDodajPre.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonDodajPre.Location = new System.Drawing.Point(515, 32);
            this.buttonDodajPre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajPre.Name = "buttonDodajPre";
            this.buttonDodajPre.Size = new System.Drawing.Size(60, 20);
            this.buttonDodajPre.TabIndex = 3;
            this.buttonDodajPre.Text = "Dodaj";
            this.buttonDodajPre.UseVisualStyleBackColor = true;
            this.buttonDodajPre.Click += new System.EventHandler(this.buttonDodajPre_Click);
            // 
            // groupBoxOstvareni
            // 
            this.groupBoxOstvareni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxOstvareni.Controls.Add(this.buttonIzbacOst);
            this.groupBoxOstvareni.Controls.Add(this.buttonIzmeniOst);
            this.groupBoxOstvareni.Controls.Add(this.buttonDodajOst);
            this.groupBoxOstvareni.Controls.Add(this.listViewOst);
            this.groupBoxOstvareni.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBoxOstvareni.Location = new System.Drawing.Point(6, 127);
            this.groupBoxOstvareni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOstvareni.Name = "groupBoxOstvareni";
            this.groupBoxOstvareni.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOstvareni.Size = new System.Drawing.Size(585, 105);
            this.groupBoxOstvareni.TabIndex = 8;
            this.groupBoxOstvareni.TabStop = false;
            this.groupBoxOstvareni.Text = "Ostvareni Protok";
            // 
            // buttonIzbacOst
            // 
            this.buttonIzbacOst.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzbacOst.Location = new System.Drawing.Point(512, 79);
            this.buttonIzbacOst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzbacOst.Name = "buttonIzbacOst";
            this.buttonIzbacOst.Size = new System.Drawing.Size(59, 20);
            this.buttonIzbacOst.TabIndex = 8;
            this.buttonIzbacOst.Text = "Izbaci";
            this.buttonIzbacOst.UseVisualStyleBackColor = true;
            this.buttonIzbacOst.Click += new System.EventHandler(this.buttonIzbacOst_Click);
            // 
            // buttonIzmeniOst
            // 
            this.buttonIzmeniOst.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzmeniOst.Location = new System.Drawing.Point(513, 54);
            this.buttonIzmeniOst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeniOst.Name = "buttonIzmeniOst";
            this.buttonIzmeniOst.Size = new System.Drawing.Size(59, 20);
            this.buttonIzmeniOst.TabIndex = 7;
            this.buttonIzmeniOst.Text = "Izmeni";
            this.buttonIzmeniOst.UseVisualStyleBackColor = true;
            this.buttonIzmeniOst.Click += new System.EventHandler(this.buttonIzmeniOst_Click);
            // 
            // buttonDodajOst
            // 
            this.buttonDodajOst.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonDodajOst.Location = new System.Drawing.Point(512, 30);
            this.buttonDodajOst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajOst.Name = "buttonDodajOst";
            this.buttonDodajOst.Size = new System.Drawing.Size(60, 20);
            this.buttonDodajOst.TabIndex = 6;
            this.buttonDodajOst.Text = "Dodaj";
            this.buttonDodajOst.UseVisualStyleBackColor = true;
            this.buttonDodajOst.Click += new System.EventHandler(this.buttonDodajOst_Click);
            // 
            // groupBoxFlat
            // 
            this.groupBoxFlat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxFlat.Controls.Add(this.buttonIzbaciFlat);
            this.groupBoxFlat.Controls.Add(this.buttonIzmeniFlat);
            this.groupBoxFlat.Controls.Add(this.buttonDodajFlat);
            this.groupBoxFlat.Controls.Add(this.listViewFlat);
            this.groupBoxFlat.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBoxFlat.Location = new System.Drawing.Point(7, 240);
            this.groupBoxFlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFlat.Name = "groupBoxFlat";
            this.groupBoxFlat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxFlat.Size = new System.Drawing.Size(584, 111);
            this.groupBoxFlat.TabIndex = 9;
            this.groupBoxFlat.TabStop = false;
            this.groupBoxFlat.Text = "Flat Rate";
            // 
            // buttonIzbaciFlat
            // 
            this.buttonIzbaciFlat.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzbaciFlat.Location = new System.Drawing.Point(512, 84);
            this.buttonIzbaciFlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzbaciFlat.Name = "buttonIzbaciFlat";
            this.buttonIzbaciFlat.Size = new System.Drawing.Size(59, 20);
            this.buttonIzbaciFlat.TabIndex = 8;
            this.buttonIzbaciFlat.Text = "Izbaci";
            this.buttonIzbaciFlat.UseVisualStyleBackColor = true;
            this.buttonIzbaciFlat.Click += new System.EventHandler(this.buttonIzbaciFlat_Click);
            // 
            // buttonIzmeniFlat
            // 
            this.buttonIzmeniFlat.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzmeniFlat.Location = new System.Drawing.Point(512, 60);
            this.buttonIzmeniFlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeniFlat.Name = "buttonIzmeniFlat";
            this.buttonIzmeniFlat.Size = new System.Drawing.Size(59, 20);
            this.buttonIzmeniFlat.TabIndex = 7;
            this.buttonIzmeniFlat.Text = "Izmeni";
            this.buttonIzmeniFlat.UseVisualStyleBackColor = true;
            this.buttonIzmeniFlat.Click += new System.EventHandler(this.buttonIzmeniFlat_Click);
            // 
            // buttonDodajFlat
            // 
            this.buttonDodajFlat.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonDodajFlat.Location = new System.Drawing.Point(512, 36);
            this.buttonDodajFlat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajFlat.Name = "buttonDodajFlat";
            this.buttonDodajFlat.Size = new System.Drawing.Size(60, 20);
            this.buttonDodajFlat.TabIndex = 6;
            this.buttonDodajFlat.Text = "Dodaj";
            this.buttonDodajFlat.UseVisualStyleBackColor = true;
            this.buttonDodajFlat.Click += new System.EventHandler(this.buttonDodajFlat_Click);
            // 
            // groupBoxTelevizija
            // 
            this.groupBoxTelevizija.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxTelevizija.Controls.Add(this.buttonIzbaciTelev);
            this.groupBoxTelevizija.Controls.Add(this.listViewTelev);
            this.groupBoxTelevizija.Controls.Add(this.buttonDodajTelev);
            this.groupBoxTelevizija.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBoxTelevizija.Location = new System.Drawing.Point(8, 358);
            this.groupBoxTelevizija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTelevizija.Name = "groupBoxTelevizija";
            this.groupBoxTelevizija.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTelevizija.Size = new System.Drawing.Size(583, 117);
            this.groupBoxTelevizija.TabIndex = 10;
            this.groupBoxTelevizija.TabStop = false;
            this.groupBoxTelevizija.Text = "Televizija";
            // 
            // buttonIzbaciTelev
            // 
            this.buttonIzbaciTelev.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzbaciTelev.Location = new System.Drawing.Point(509, 76);
            this.buttonIzbaciTelev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzbaciTelev.Name = "buttonIzbaciTelev";
            this.buttonIzbaciTelev.Size = new System.Drawing.Size(59, 20);
            this.buttonIzbaciTelev.TabIndex = 14;
            this.buttonIzbaciTelev.Text = "Izbaci";
            this.buttonIzbaciTelev.UseVisualStyleBackColor = true;
            this.buttonIzbaciTelev.Click += new System.EventHandler(this.buttonIzbaciTelev_Click);
            // 
            // buttonDodajTelev
            // 
            this.buttonDodajTelev.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonDodajTelev.Location = new System.Drawing.Point(510, 52);
            this.buttonDodajTelev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajTelev.Name = "buttonDodajTelev";
            this.buttonDodajTelev.Size = new System.Drawing.Size(60, 20);
            this.buttonDodajTelev.TabIndex = 12;
            this.buttonDodajTelev.Text = "Dodaj";
            this.buttonDodajTelev.UseVisualStyleBackColor = true;
            this.buttonDodajTelev.Click += new System.EventHandler(this.buttonDodajTelev_Click);
            // 
            // groupBoxTelefonija
            // 
            this.groupBoxTelefonija.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxTelefonija.Controls.Add(this.buttonIzbaciTelef);
            this.groupBoxTelefonija.Controls.Add(this.buttonIzmeniTelef);
            this.groupBoxTelefonija.Controls.Add(this.buttonDodajTelef);
            this.groupBoxTelefonija.Controls.Add(this.listViewTelef);
            this.groupBoxTelefonija.Font = new System.Drawing.Font("Verdana", 8F);
            this.groupBoxTelefonija.Location = new System.Drawing.Point(3, 483);
            this.groupBoxTelefonija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTelefonija.Name = "groupBoxTelefonija";
            this.groupBoxTelefonija.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTelefonija.Size = new System.Drawing.Size(586, 103);
            this.groupBoxTelefonija.TabIndex = 11;
            this.groupBoxTelefonija.TabStop = false;
            this.groupBoxTelefonija.Text = "Telefonija";
            // 
            // buttonIzbaciTelef
            // 
            this.buttonIzbaciTelef.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzbaciTelef.Location = new System.Drawing.Point(515, 77);
            this.buttonIzbaciTelef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzbaciTelef.Name = "buttonIzbaciTelef";
            this.buttonIzbaciTelef.Size = new System.Drawing.Size(59, 20);
            this.buttonIzbaciTelef.TabIndex = 9;
            this.buttonIzbaciTelef.Text = "Izbaci";
            this.buttonIzbaciTelef.UseVisualStyleBackColor = true;
            this.buttonIzbaciTelef.Click += new System.EventHandler(this.buttonIzbaciTelef_Click);
            // 
            // buttonIzmeniTelef
            // 
            this.buttonIzmeniTelef.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzmeniTelef.Location = new System.Drawing.Point(515, 53);
            this.buttonIzmeniTelef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeniTelef.Name = "buttonIzmeniTelef";
            this.buttonIzmeniTelef.Size = new System.Drawing.Size(59, 20);
            this.buttonIzmeniTelef.TabIndex = 8;
            this.buttonIzmeniTelef.Text = "Izmeni";
            this.buttonIzmeniTelef.UseVisualStyleBackColor = true;
            this.buttonIzmeniTelef.Click += new System.EventHandler(this.buttonIzmeniTelef_Click);
            // 
            // buttonDodajTelef
            // 
            this.buttonDodajTelef.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonDodajTelef.Location = new System.Drawing.Point(515, 28);
            this.buttonDodajTelef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajTelef.Name = "buttonDodajTelef";
            this.buttonDodajTelef.Size = new System.Drawing.Size(60, 20);
            this.buttonDodajTelef.TabIndex = 7;
            this.buttonDodajTelef.Text = "Dodaj";
            this.buttonDodajTelef.UseVisualStyleBackColor = true;
            this.buttonDodajTelef.Click += new System.EventHandler(this.buttonDodajTelef_Click);
            // 
            // DodajUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 655);
            this.Controls.Add(this.groupBoxTelefonija);
            this.Controls.Add(this.groupBoxTelevizija);
            this.Controls.Add(this.groupBoxFlat);
            this.Controls.Add(this.groupBoxOstvareni);
            this.Controls.Add(this.groupBoxPrepaid);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "DodajUgovor";
            this.Text = "DodajUgovor";
            this.Load += new System.EventHandler(this.DodajUgovor_Load);
            this.groupBoxPrepaid.ResumeLayout(false);
            this.groupBoxOstvareni.ResumeLayout(false);
            this.groupBoxFlat.ResumeLayout(false);
            this.groupBoxTelevizija.ResumeLayout(false);
            this.groupBoxTelefonija.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listViewOst;
        private System.Windows.Forms.ListView listViewFlat;
        private System.Windows.Forms.ListView listViewTelev;
        private System.Windows.Forms.ListView listViewTelef;
        private System.Windows.Forms.ListView listViewPre;
        private System.Windows.Forms.GroupBox groupBoxPrepaid;
        private System.Windows.Forms.Button buttonIzbaciPre;
        private System.Windows.Forms.Button buttonDodajPre;
        private System.Windows.Forms.GroupBox groupBoxOstvareni;
        private System.Windows.Forms.Button buttonIzbacOst;
        private System.Windows.Forms.Button buttonIzmeniOst;
        private System.Windows.Forms.Button buttonDodajOst;
        private System.Windows.Forms.GroupBox groupBoxFlat;
        private System.Windows.Forms.Button buttonIzbaciFlat;
        private System.Windows.Forms.Button buttonDodajFlat;
        private System.Windows.Forms.GroupBox groupBoxTelevizija;
        private System.Windows.Forms.Button buttonIzbaciTelev;
        private System.Windows.Forms.Button buttonDodajTelev;
        private System.Windows.Forms.GroupBox groupBoxTelefonija;
        private System.Windows.Forms.Button buttonIzbaciTelef;
        private System.Windows.Forms.Button buttonIzmeniTelef;
        private System.Windows.Forms.Button buttonDodajTelef;
        private System.Windows.Forms.ColumnHeader columnHeaderDanPlacanja;
        private System.Windows.Forms.ColumnHeader columnHeaderPotroseno;
        private System.Windows.Forms.ColumnHeader columnHeaderCenaMB;
        private System.Windows.Forms.ColumnHeader columnHeaderMesecnaCena;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa1;
        private System.Windows.Forms.ColumnHeader columnHeaderAdresa2;
        private System.Windows.Forms.ColumnHeader columnHeaderKanal;
        private System.Windows.Forms.ColumnHeader columnHeaderPaketKanala;
        private System.Windows.Forms.ColumnHeader columnHeaderBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderStanje;
        private System.Windows.Forms.ColumnHeader columnHeaderdatumUplate;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonIzmeniFlat;
    }
}