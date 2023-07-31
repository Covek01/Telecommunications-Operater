namespace Telekomunikacija.Forms
{
    partial class KomunikacioniCvorDodavanje
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
            this.txtTipVeze = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojZgrade = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dateUpotrebaOd = new System.Windows.Forms.DateTimePicker();
            this.dateZadnjiServis = new System.Windows.Forms.DateTimePicker();
            this.txtRazlogServisa = new System.Windows.Forms.TextBox();
            this.txtNazivProizvodjaca = new System.Windows.Forms.TextBox();
            this.txtSerijskiBroj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerijskiBroj = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listViewUredjaji = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serijski_broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Upotreba_od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zadnji_servis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.razlogServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionalniFlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazivRegiona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.txtSerijskiBrojInsert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTipVeze
            // 
            this.txtTipVeze.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtTipVeze.FormattingEnabled = true;
            this.txtTipVeze.Location = new System.Drawing.Point(180, 521);
            this.txtTipVeze.Name = "txtTipVeze";
            this.txtTipVeze.Size = new System.Drawing.Size(151, 24);
            this.txtTipVeze.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label9.Location = new System.Drawing.Point(22, 524);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 84;
            this.label9.Text = "Tip veze :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label8.Location = new System.Drawing.Point(22, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 83;
            this.label8.Text = "Broj zgrade :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label7.Location = new System.Drawing.Point(22, 403);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "Ulica :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label6.Location = new System.Drawing.Point(22, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 81;
            this.label6.Text = "Grad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label5.Location = new System.Drawing.Point(22, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 80;
            this.label5.Text = "Opis :";
            // 
            // txtBrojZgrade
            // 
            this.txtBrojZgrade.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtBrojZgrade.Location = new System.Drawing.Point(180, 460);
            this.txtBrojZgrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojZgrade.Name = "txtBrojZgrade";
            this.txtBrojZgrade.Size = new System.Drawing.Size(151, 23);
            this.txtBrojZgrade.TabIndex = 79;
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtUlica.Location = new System.Drawing.Point(180, 403);
            this.txtUlica.Margin = new System.Windows.Forms.Padding(4);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(151, 23);
            this.txtUlica.TabIndex = 78;
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtGrad.Location = new System.Drawing.Point(180, 348);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(151, 23);
            this.txtGrad.TabIndex = 77;
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtOpis.Location = new System.Drawing.Point(180, 295);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(151, 23);
            this.txtOpis.TabIndex = 76;
            // 
            // dateUpotrebaOd
            // 
            this.dateUpotrebaOd.CalendarFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateUpotrebaOd.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dateUpotrebaOd.Location = new System.Drawing.Point(142, 129);
            this.dateUpotrebaOd.Name = "dateUpotrebaOd";
            this.dateUpotrebaOd.Size = new System.Drawing.Size(242, 23);
            this.dateUpotrebaOd.TabIndex = 75;
            // 
            // dateZadnjiServis
            // 
            this.dateZadnjiServis.CalendarFont = new System.Drawing.Font("Verdana", 8.25F);
            this.dateZadnjiServis.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dateZadnjiServis.Location = new System.Drawing.Point(142, 185);
            this.dateZadnjiServis.Name = "dateZadnjiServis";
            this.dateZadnjiServis.Size = new System.Drawing.Size(242, 23);
            this.dateZadnjiServis.TabIndex = 74;
            // 
            // txtRazlogServisa
            // 
            this.txtRazlogServisa.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtRazlogServisa.Location = new System.Drawing.Point(180, 244);
            this.txtRazlogServisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazlogServisa.Name = "txtRazlogServisa";
            this.txtRazlogServisa.Size = new System.Drawing.Size(151, 23);
            this.txtRazlogServisa.TabIndex = 73;
            // 
            // txtNazivProizvodjaca
            // 
            this.txtNazivProizvodjaca.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNazivProizvodjaca.Location = new System.Drawing.Point(180, 77);
            this.txtNazivProizvodjaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivProizvodjaca.Name = "txtNazivProizvodjaca";
            this.txtNazivProizvodjaca.Size = new System.Drawing.Size(151, 23);
            this.txtNazivProizvodjaca.TabIndex = 72;
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtSerijskiBroj.Location = new System.Drawing.Point(605, 599);
            this.txtSerijskiBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.ReadOnly = true;
            this.txtSerijskiBroj.Size = new System.Drawing.Size(151, 23);
            this.txtSerijskiBroj.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label4.Location = new System.Drawing.Point(21, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Razlog servisa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label3.Location = new System.Drawing.Point(22, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Zadnji servis :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.Location = new System.Drawing.Point(21, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 68;
            this.label2.Text = "Upotreba od :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "Naziv proizvodjaca :";
            // 
            // lblSerijskiBroj
            // 
            this.lblSerijskiBroj.AutoSize = true;
            this.lblSerijskiBroj.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblSerijskiBroj.Location = new System.Drawing.Point(22, 35);
            this.lblSerijskiBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerijskiBroj.Name = "lblSerijskiBroj";
            this.lblSerijskiBroj.Size = new System.Drawing.Size(113, 18);
            this.lblSerijskiBroj.TabIndex = 66;
            this.lblSerijskiBroj.Text = "Serijski broj : ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodaj.Location = new System.Drawing.Point(15, 576);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(187, 46);
            this.btnDodaj.TabIndex = 86;
            this.btnDodaj.Text = "Dodaj komunikacioni cvor";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listViewUredjaji
            // 
            this.listViewUredjaji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Serijski_broj,
            this.Proizvodjac,
            this.Upotreba_od,
            this.Zadnji_servis,
            this.razlogServisa,
            this.RegionalniFlag,
            this.NazivRegiona});
            this.listViewUredjaji.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewUredjaji.FullRowSelect = true;
            this.listViewUredjaji.HideSelection = false;
            this.listViewUredjaji.Location = new System.Drawing.Point(390, 12);
            this.listViewUredjaji.Name = "listViewUredjaji";
            this.listViewUredjaji.Size = new System.Drawing.Size(832, 568);
            this.listViewUredjaji.TabIndex = 87;
            this.listViewUredjaji.UseCompatibleStateImageBehavior = false;
            this.listViewUredjaji.View = System.Windows.Forms.View.Details;
            this.listViewUredjaji.SelectedIndexChanged += new System.EventHandler(this.listViewUredjaji_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Serijski_broj
            // 
            this.Serijski_broj.Text = "Serijski broj";
            this.Serijski_broj.Width = 100;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.Text = "Proizvodjac";
            this.Proizvodjac.Width = 90;
            // 
            // Upotreba_od
            // 
            this.Upotreba_od.Text = "Upotreba od";
            this.Upotreba_od.Width = 100;
            // 
            // Zadnji_servis
            // 
            this.Zadnji_servis.Text = "Zadnji servis";
            this.Zadnji_servis.Width = 100;
            // 
            // razlogServisa
            // 
            this.razlogServisa.Text = "Razlog servisa";
            this.razlogServisa.Width = 110;
            // 
            // RegionalniFlag
            // 
            this.RegionalniFlag.Text = "Regionalni flag";
            this.RegionalniFlag.Width = 14564;
            // 
            // NazivRegiona
            // 
            this.NazivRegiona.Text = "Naziv regiona";
            this.NazivRegiona.Width = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label10.Location = new System.Drawing.Point(352, 604);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 18);
            this.label10.TabIndex = 88;
            this.label10.Text = "Serijski broj glavne stanice :";
            // 
            // txtSerijskiBrojInsert
            // 
            this.txtSerijskiBrojInsert.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtSerijskiBrojInsert.Location = new System.Drawing.Point(180, 36);
            this.txtSerijskiBrojInsert.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerijskiBrojInsert.Name = "txtSerijskiBrojInsert";
            this.txtSerijskiBrojInsert.Size = new System.Drawing.Size(151, 23);
            this.txtSerijskiBrojInsert.TabIndex = 89;
            // 
            // KomunikacioniCvorDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1234, 660);
            this.Controls.Add(this.txtSerijskiBrojInsert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listViewUredjaji);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtTipVeze);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrojZgrade);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.dateUpotrebaOd);
            this.Controls.Add(this.dateZadnjiServis);
            this.Controls.Add(this.txtRazlogServisa);
            this.Controls.Add(this.txtNazivProizvodjaca);
            this.Controls.Add(this.txtSerijskiBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSerijskiBroj);
            this.Name = "KomunikacioniCvorDodavanje";
            this.Text = "KomunikacioniCvorDodavanje";
            this.Load += new System.EventHandler(this.KomunikacioniCvorDodavanje_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtTipVeze;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojZgrade;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DateTimePicker dateUpotrebaOd;
        private System.Windows.Forms.DateTimePicker dateZadnjiServis;
        private System.Windows.Forms.TextBox txtRazlogServisa;
        private System.Windows.Forms.TextBox txtNazivProizvodjaca;
        private System.Windows.Forms.TextBox txtSerijskiBroj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSerijskiBroj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView listViewUredjaji;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Serijski_broj;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.ColumnHeader Upotreba_od;
        private System.Windows.Forms.ColumnHeader Zadnji_servis;
        private System.Windows.Forms.ColumnHeader razlogServisa;
        private System.Windows.Forms.ColumnHeader RegionalniFlag;
        private System.Windows.Forms.ColumnHeader NazivRegiona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSerijskiBrojInsert;
    }
}