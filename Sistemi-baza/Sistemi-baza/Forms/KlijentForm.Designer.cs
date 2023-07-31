namespace Telekomunikacija.Forms
{
    partial class KlijentForm
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
            this.lvKlijenti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxFizicka = new System.Windows.Forms.CheckBox();
            this.checkBoxPravna = new System.Windows.Forms.CheckBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBrojeviTelefona = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKlijenti
            // 
            this.lvKlijenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvKlijenti.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lvKlijenti.FullRowSelect = true;
            this.lvKlijenti.HideSelection = false;
            this.lvKlijenti.Location = new System.Drawing.Point(43, 21);
            this.lvKlijenti.Name = "lvKlijenti";
            this.lvKlijenti.Size = new System.Drawing.Size(572, 341);
            this.lvKlijenti.TabIndex = 0;
            this.lvKlijenti.UseCompatibleStateImageBehavior = false;
            this.lvKlijenti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grad";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ulica";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj";
            this.columnHeader5.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tip";
            this.columnHeader6.Width = 71;
            // 
            // checkBoxFizicka
            // 
            this.checkBoxFizicka.AutoSize = true;
            this.checkBoxFizicka.Checked = true;
            this.checkBoxFizicka.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFizicka.Font = new System.Drawing.Font("Verdana", 12F);
            this.checkBoxFizicka.Location = new System.Drawing.Point(267, 396);
            this.checkBoxFizicka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxFizicka.Name = "checkBoxFizicka";
            this.checkBoxFizicka.Size = new System.Drawing.Size(120, 22);
            this.checkBoxFizicka.TabIndex = 1;
            this.checkBoxFizicka.Text = "Fizicka Lica";
            this.checkBoxFizicka.UseVisualStyleBackColor = true;
            this.checkBoxFizicka.CheckedChanged += new System.EventHandler(this.checkBoxFizicka_CheckedChanged);
            // 
            // checkBoxPravna
            // 
            this.checkBoxPravna.AutoSize = true;
            this.checkBoxPravna.Checked = true;
            this.checkBoxPravna.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPravna.Font = new System.Drawing.Font("Verdana", 12F);
            this.checkBoxPravna.Location = new System.Drawing.Point(407, 396);
            this.checkBoxPravna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPravna.Name = "checkBoxPravna";
            this.checkBoxPravna.Size = new System.Drawing.Size(120, 22);
            this.checkBoxPravna.TabIndex = 2;
            this.checkBoxPravna.Text = "Pravna Lica";
            this.checkBoxPravna.UseVisualStyleBackColor = true;
            this.checkBoxPravna.CheckedChanged += new System.EventHandler(this.checkBoxPravna_CheckedChanged);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonIzmeni.Location = new System.Drawing.Point(14, 16);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(113, 29);
            this.buttonIzmeni.TabIndex = 3;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonObrisi.Location = new System.Drawing.Point(14, 65);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(113, 28);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.buttonBrojeviTelefona);
            this.groupBox1.Controls.Add(this.buttonObrisi);
            this.groupBox1.Controls.Add(this.buttonIzmeni);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(645, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(140, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijent";
            // 
            // buttonBrojeviTelefona
            // 
            this.buttonBrojeviTelefona.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonBrojeviTelefona.Location = new System.Drawing.Point(14, 111);
            this.buttonBrojeviTelefona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBrojeviTelefona.Name = "buttonBrojeviTelefona";
            this.buttonBrojeviTelefona.Size = new System.Drawing.Size(113, 28);
            this.buttonBrojeviTelefona.TabIndex = 5;
            this.buttonBrojeviTelefona.Text = "Kontakt Info";
            this.buttonBrojeviTelefona.UseVisualStyleBackColor = true;
            this.buttonBrojeviTelefona.Click += new System.EventHandler(this.buttonBrojeviTelefona_Click);
            // 
            // KlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxPravna);
            this.Controls.Add(this.checkBoxFizicka);
            this.Controls.Add(this.lvKlijenti);
            this.MaximizeBox = false;
            this.Name = "KlijentForm";
            this.Text = "KlijentForma";
            this.Load += new System.EventHandler(this.KlijentForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKlijenti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox checkBoxFizicka;
        private System.Windows.Forms.CheckBox checkBoxPravna;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBrojeviTelefona;
    }
}