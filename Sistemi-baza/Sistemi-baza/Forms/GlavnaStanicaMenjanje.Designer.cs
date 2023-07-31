namespace Telekomunikacija.Forms
{
    partial class GlavnaStanicaMenjanje
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
            this.txtNazivRegiona = new System.Windows.Forms.TextBox();
            this.checkRegionalniHub = new System.Windows.Forms.CheckBox();
            this.listViewUredjaji = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serijski_broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Upotreba_od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zadnji_servis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.razlogServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegionalniFlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NazivRegiona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateUpotrebaOd
            // 
            this.dateUpotrebaOd.CalendarFont = new System.Drawing.Font("Verdana", 7.25F);
            this.dateUpotrebaOd.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dateUpotrebaOd.Location = new System.Drawing.Point(139, 140);
            this.dateUpotrebaOd.Name = "dateUpotrebaOd";
            this.dateUpotrebaOd.Size = new System.Drawing.Size(216, 21);
            this.dateUpotrebaOd.TabIndex = 61;
            // 
            // dateZadnjiServis
            // 
            this.dateZadnjiServis.CalendarFont = new System.Drawing.Font("Verdana", 7.25F);
            this.dateZadnjiServis.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dateZadnjiServis.Location = new System.Drawing.Point(142, 193);
            this.dateZadnjiServis.Name = "dateZadnjiServis";
            this.dateZadnjiServis.Size = new System.Drawing.Size(213, 21);
            this.dateZadnjiServis.TabIndex = 60;
            // 
            // txtRazlogServisa
            // 
            this.txtRazlogServisa.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtRazlogServisa.Location = new System.Drawing.Point(184, 253);
            this.txtRazlogServisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazlogServisa.Name = "txtRazlogServisa";
            this.txtRazlogServisa.Size = new System.Drawing.Size(151, 21);
            this.txtRazlogServisa.TabIndex = 59;
            // 
            // txtNazivProizvodjaca
            // 
            this.txtNazivProizvodjaca.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtNazivProizvodjaca.Location = new System.Drawing.Point(184, 82);
            this.txtNazivProizvodjaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivProizvodjaca.Name = "txtNazivProizvodjaca";
            this.txtNazivProizvodjaca.Size = new System.Drawing.Size(151, 21);
            this.txtNazivProizvodjaca.TabIndex = 58;
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtSerijskiBroj.Location = new System.Drawing.Point(184, 28);
            this.txtSerijskiBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.ReadOnly = true;
            this.txtSerijskiBroj.Size = new System.Drawing.Size(151, 21);
            this.txtSerijskiBroj.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label4.Location = new System.Drawing.Point(25, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Razlog servisa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label3.Location = new System.Drawing.Point(26, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Zadnji servis :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label2.Location = new System.Drawing.Point(25, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Upotreba od :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Naziv proizvodjaca :";
            // 
            // lblSerijskiBroj
            // 
            this.lblSerijskiBroj.AutoSize = true;
            this.lblSerijskiBroj.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.lblSerijskiBroj.Location = new System.Drawing.Point(26, 28);
            this.lblSerijskiBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerijskiBroj.Name = "lblSerijskiBroj";
            this.lblSerijskiBroj.Size = new System.Drawing.Size(109, 17);
            this.lblSerijskiBroj.TabIndex = 52;
            this.lblSerijskiBroj.Text = "Serijski broj : ";
            // 
            // txtNazivRegiona
            // 
            this.txtNazivRegiona.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtNazivRegiona.Location = new System.Drawing.Point(33, 339);
            this.txtNazivRegiona.Name = "txtNazivRegiona";
            this.txtNazivRegiona.ReadOnly = true;
            this.txtNazivRegiona.Size = new System.Drawing.Size(132, 21);
            this.txtNazivRegiona.TabIndex = 66;
            // 
            // checkRegionalniHub
            // 
            this.checkRegionalniHub.AutoSize = true;
            this.checkRegionalniHub.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.checkRegionalniHub.Location = new System.Drawing.Point(33, 307);
            this.checkRegionalniHub.Name = "checkRegionalniHub";
            this.checkRegionalniHub.Size = new System.Drawing.Size(103, 17);
            this.checkRegionalniHub.TabIndex = 65;
            this.checkRegionalniHub.Text = "Reginalni hub";
            this.checkRegionalniHub.UseVisualStyleBackColor = true;
            this.checkRegionalniHub.CheckedChanged += new System.EventHandler(this.checkRegionalniHub_CheckedChanged);
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
            this.listViewUredjaji.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.listViewUredjaji.FullRowSelect = true;
            this.listViewUredjaji.HideSelection = false;
            this.listViewUredjaji.Location = new System.Drawing.Point(361, 12);
            this.listViewUredjaji.Name = "listViewUredjaji";
            this.listViewUredjaji.Size = new System.Drawing.Size(773, 444);
            this.listViewUredjaji.TabIndex = 67;
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
            this.RegionalniFlag.Width = 100;
            // 
            // NazivRegiona
            // 
            this.NazivRegiona.Text = "Naziv regiona";
            this.NazivRegiona.Width = 100;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnIzmeni.Location = new System.Drawing.Point(184, 318);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(155, 41);
            this.btnIzmeni.TabIndex = 68;
            this.btnIzmeni.Text = "Izmeni uredjaj";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // GlavnaStanicaMenjanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1146, 493);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.listViewUredjaji);
            this.Controls.Add(this.txtNazivRegiona);
            this.Controls.Add(this.checkRegionalniHub);
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
            this.Name = "GlavnaStanicaMenjanje";
            this.Text = "GlavnaStanicaMenjanje";
            this.Load += new System.EventHandler(this.GlavnaStanicaMenjanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtNazivRegiona;
        private System.Windows.Forms.CheckBox checkRegionalniHub;
        private System.Windows.Forms.ListView listViewUredjaji;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Serijski_broj;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.ColumnHeader Upotreba_od;
        private System.Windows.Forms.ColumnHeader Zadnji_servis;
        private System.Windows.Forms.ColumnHeader razlogServisa;
        private System.Windows.Forms.ColumnHeader RegionalniFlag;
        private System.Windows.Forms.ColumnHeader NazivRegiona;
        private System.Windows.Forms.Button btnIzmeni;
    }
}