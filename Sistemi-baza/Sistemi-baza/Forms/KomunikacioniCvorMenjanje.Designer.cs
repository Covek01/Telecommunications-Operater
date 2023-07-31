namespace Telekomunikacija.Forms
{
    partial class KomunikacioniCvorMenjanje
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
            this.listViewUredjaji = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Serijski_broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Upotreba_od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zadnji_servis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.razlogServisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojZgrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipVeze = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtBrojZgrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtTipVeze = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.Opis,
            this.Grad,
            this.Ulica,
            this.BrojZgrade,
            this.TipVeze});
            this.listViewUredjaji.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewUredjaji.FullRowSelect = true;
            this.listViewUredjaji.HideSelection = false;
            this.listViewUredjaji.Location = new System.Drawing.Point(374, 43);
            this.listViewUredjaji.Name = "listViewUredjaji";
            this.listViewUredjaji.Size = new System.Drawing.Size(917, 490);
            this.listViewUredjaji.TabIndex = 1;
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
            // Opis
            // 
            this.Opis.Text = "Opis";
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            // 
            // BrojZgrade
            // 
            this.BrojZgrade.Text = "Broj zgrade";
            this.BrojZgrade.Width = 100;
            // 
            // TipVeze
            // 
            this.TipVeze.Text = "Tip veze";
            this.TipVeze.Width = 90;
            // 
            // dateUpotrebaOd
            // 
            this.dateUpotrebaOd.CalendarFont = new System.Drawing.Font("Verdana", 8.25F);
            this.dateUpotrebaOd.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dateUpotrebaOd.Location = new System.Drawing.Point(118, 153);
            this.dateUpotrebaOd.Name = "dateUpotrebaOd";
            this.dateUpotrebaOd.Size = new System.Drawing.Size(250, 23);
            this.dateUpotrebaOd.TabIndex = 51;
            // 
            // dateZadnjiServis
            // 
            this.dateZadnjiServis.CalendarFont = new System.Drawing.Font("Verdana", 8.25F);
            this.dateZadnjiServis.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dateZadnjiServis.Location = new System.Drawing.Point(118, 211);
            this.dateZadnjiServis.Name = "dateZadnjiServis";
            this.dateZadnjiServis.Size = new System.Drawing.Size(250, 23);
            this.dateZadnjiServis.TabIndex = 50;
            // 
            // txtRazlogServisa
            // 
            this.txtRazlogServisa.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtRazlogServisa.Location = new System.Drawing.Point(171, 268);
            this.txtRazlogServisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazlogServisa.Name = "txtRazlogServisa";
            this.txtRazlogServisa.Size = new System.Drawing.Size(151, 23);
            this.txtRazlogServisa.TabIndex = 49;
            // 
            // txtNazivProizvodjaca
            // 
            this.txtNazivProizvodjaca.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtNazivProizvodjaca.Location = new System.Drawing.Point(171, 97);
            this.txtNazivProizvodjaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivProizvodjaca.Name = "txtNazivProizvodjaca";
            this.txtNazivProizvodjaca.Size = new System.Drawing.Size(151, 23);
            this.txtNazivProizvodjaca.TabIndex = 48;
            // 
            // txtSerijskiBroj
            // 
            this.txtSerijskiBroj.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtSerijskiBroj.Location = new System.Drawing.Point(171, 43);
            this.txtSerijskiBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerijskiBroj.Name = "txtSerijskiBroj";
            this.txtSerijskiBroj.ReadOnly = true;
            this.txtSerijskiBroj.Size = new System.Drawing.Size(151, 23);
            this.txtSerijskiBroj.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 46;
            this.label4.Text = "Razlog servisa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Zadnji servis :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Upotreba od :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Naziv proizvodjaca :";
            // 
            // lblSerijskiBroj
            // 
            this.lblSerijskiBroj.AutoSize = true;
            this.lblSerijskiBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerijskiBroj.Location = new System.Drawing.Point(13, 43);
            this.lblSerijskiBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerijskiBroj.Name = "lblSerijskiBroj";
            this.lblSerijskiBroj.Size = new System.Drawing.Size(97, 18);
            this.lblSerijskiBroj.TabIndex = 42;
            this.lblSerijskiBroj.Text = "Serijski broj : ";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtOpis.Location = new System.Drawing.Point(171, 319);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(151, 23);
            this.txtOpis.TabIndex = 52;
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtGrad.Location = new System.Drawing.Point(171, 372);
            this.txtGrad.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(151, 23);
            this.txtGrad.TabIndex = 53;
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtUlica.Location = new System.Drawing.Point(171, 427);
            this.txtUlica.Margin = new System.Windows.Forms.Padding(4);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(151, 23);
            this.txtUlica.TabIndex = 54;
            // 
            // txtBrojZgrade
            // 
            this.txtBrojZgrade.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtBrojZgrade.Location = new System.Drawing.Point(171, 484);
            this.txtBrojZgrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojZgrade.Name = "txtBrojZgrade";
            this.txtBrojZgrade.Size = new System.Drawing.Size(151, 23);
            this.txtBrojZgrade.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 57;
            this.label5.Text = "Opis :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 58;
            this.label6.Text = "Grad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 427);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ulica :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 486);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Broj zgrade :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 548);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tip veze :";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnIzmeni.Location = new System.Drawing.Point(529, 562);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(169, 61);
            this.btnIzmeni.TabIndex = 62;
            this.btnIzmeni.Text = "Izmeni uredjaj";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtTipVeze
            // 
            this.txtTipVeze.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtTipVeze.FormattingEnabled = true;
            this.txtTipVeze.Location = new System.Drawing.Point(171, 545);
            this.txtTipVeze.Name = "txtTipVeze";
            this.txtTipVeze.Size = new System.Drawing.Size(151, 24);
            this.txtTipVeze.TabIndex = 65;
            // 
            // KomunikacioniCvorMenjanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 660);
            this.Controls.Add(this.txtTipVeze);
            this.Controls.Add(this.btnIzmeni);
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
            this.Controls.Add(this.listViewUredjaji);
            this.Name = "KomunikacioniCvorMenjanje";
            this.Text = "KomunikacioniCvorMenjanje";
            this.Load += new System.EventHandler(this.KomunikacioniCvorMenjanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUredjaji;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Serijski_broj;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.ColumnHeader Upotreba_od;
        private System.Windows.Forms.ColumnHeader Zadnji_servis;
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
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtBrojZgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ColumnHeader TipVeze;
        private System.Windows.Forms.ColumnHeader Opis;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader BrojZgrade;
        private System.Windows.Forms.ColumnHeader razlogServisa;
        private System.Windows.Forms.ComboBox txtTipVeze;
    }
}