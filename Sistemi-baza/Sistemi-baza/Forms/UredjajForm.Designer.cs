namespace Telekomunikacija.Forms
{
    partial class UredjajForm
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
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.comboTipovi = new System.Windows.Forms.ComboBox();
            this.groupBoxKlijent = new System.Windows.Forms.GroupBox();
            this.GroupBoxCvor = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodajCvor = new System.Windows.Forms.Button();
            this.btnObrisiUredjaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.groupBoxKlijent.SuspendLayout();
            this.GroupBoxCvor.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.Tip});
            this.listViewUredjaji.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewUredjaji.FullRowSelect = true;
            this.listViewUredjaji.HideSelection = false;
            this.listViewUredjaji.Location = new System.Drawing.Point(24, 22);
            this.listViewUredjaji.Name = "listViewUredjaji";
            this.listViewUredjaji.Size = new System.Drawing.Size(582, 444);
            this.listViewUredjaji.TabIndex = 0;
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
            this.Serijski_broj.Width = 110;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.Text = "Proizvodjac";
            this.Proizvodjac.Width = 100;
            // 
            // Upotreba_od
            // 
            this.Upotreba_od.Text = "Upotreba od";
            this.Upotreba_od.Width = 120;
            // 
            // Zadnji_servis
            // 
            this.Zadnji_servis.Text = "Zadnji servis";
            this.Zadnji_servis.Width = 120;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.Width = 70;
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodajKlijenta.Location = new System.Drawing.Point(41, 58);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(110, 37);
            this.btnDodajKlijenta.TabIndex = 1;
            this.btnDodajKlijenta.Text = "Dodaj";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblTip.Location = new System.Drawing.Point(27, 23);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(46, 18);
            this.lblTip.TabIndex = 15;
            this.lblTip.Text = "Tip :";
            // 
            // comboTipovi
            // 
            this.comboTipovi.FormattingEnabled = true;
            this.comboTipovi.Location = new System.Drawing.Point(103, 20);
            this.comboTipovi.Name = "comboTipovi";
            this.comboTipovi.Size = new System.Drawing.Size(135, 21);
            this.comboTipovi.TabIndex = 19;
            // 
            // groupBoxKlijent
            // 
            this.groupBoxKlijent.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxKlijent.Controls.Add(this.btnDodajKlijenta);
            this.groupBoxKlijent.Controls.Add(this.comboTipovi);
            this.groupBoxKlijent.Controls.Add(this.lblTip);
            this.groupBoxKlijent.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxKlijent.Location = new System.Drawing.Point(639, 237);
            this.groupBoxKlijent.Name = "groupBoxKlijent";
            this.groupBoxKlijent.Size = new System.Drawing.Size(276, 101);
            this.groupBoxKlijent.TabIndex = 20;
            this.groupBoxKlijent.TabStop = false;
            this.groupBoxKlijent.Text = "Klijent";
            // 
            // GroupBoxCvor
            // 
            this.GroupBoxCvor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GroupBoxCvor.Controls.Add(this.btnIzmeni);
            this.GroupBoxCvor.Controls.Add(this.btnDodajCvor);
            this.GroupBoxCvor.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.GroupBoxCvor.Location = new System.Drawing.Point(639, 22);
            this.GroupBoxCvor.Name = "GroupBoxCvor";
            this.GroupBoxCvor.Size = new System.Drawing.Size(276, 108);
            this.GroupBoxCvor.TabIndex = 21;
            this.GroupBoxCvor.TabStop = false;
            this.GroupBoxCvor.Text = "Komunikacioni cvor";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnIzmeni.Location = new System.Drawing.Point(125, 38);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(113, 36);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodajCvor
            // 
            this.btnDodajCvor.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodajCvor.Location = new System.Drawing.Point(6, 40);
            this.btnDodajCvor.Name = "btnDodajCvor";
            this.btnDodajCvor.Size = new System.Drawing.Size(113, 34);
            this.btnDodajCvor.TabIndex = 1;
            this.btnDodajCvor.Text = "Dodaj";
            this.btnDodajCvor.UseVisualStyleBackColor = true;
            this.btnDodajCvor.Click += new System.EventHandler(this.btnDodajCvor_Click);
            // 
            // btnObrisiUredjaj
            // 
            this.btnObrisiUredjaj.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnObrisiUredjaj.Location = new System.Drawing.Point(639, 375);
            this.btnObrisiUredjaj.Name = "btnObrisiUredjaj";
            this.btnObrisiUredjaj.Size = new System.Drawing.Size(137, 36);
            this.btnObrisiUredjaj.TabIndex = 2;
            this.btnObrisiUredjaj.Text = "Obrisi uredjaj";
            this.btnObrisiUredjaj.UseVisualStyleBackColor = true;
            this.btnObrisiUredjaj.Click += new System.EventHandler(this.btnObrisiUredjaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDodajStanicu);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(639, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 95);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Glavna stanica";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button1.Location = new System.Drawing.Point(139, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodajStanicu.Location = new System.Drawing.Point(6, 32);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(113, 34);
            this.btnDodajStanicu.TabIndex = 1;
            this.btnDodajStanicu.Text = "Dodaj";
            this.btnDodajStanicu.UseVisualStyleBackColor = true;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click);
            // 
            // UredjajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxCvor);
            this.Controls.Add(this.btnObrisiUredjaj);
            this.Controls.Add(this.groupBoxKlijent);
            this.Controls.Add(this.listViewUredjaji);
            this.Name = "UredjajForm";
            this.Text = "UredjajForma";
            this.Load += new System.EventHandler(this.UredjajForma_Load);
            this.groupBoxKlijent.ResumeLayout(false);
            this.groupBoxKlijent.PerformLayout();
            this.GroupBoxCvor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUredjaji;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Serijski_broj;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.ColumnHeader Upotreba_od;
        private System.Windows.Forms.ColumnHeader Zadnji_servis;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.ComboBox comboTipovi;
        private System.Windows.Forms.GroupBox groupBoxKlijent;
        private System.Windows.Forms.GroupBox GroupBoxCvor;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodajCvor;
        private System.Windows.Forms.Button btnObrisiUredjaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodajStanicu;
    }
}