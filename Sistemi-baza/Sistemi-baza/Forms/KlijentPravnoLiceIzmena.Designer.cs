namespace Telekomunikacija.Forms
{
    partial class KlijentPravnoLiceIzmena
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelGrad = new System.Windows.Forms.Label();
            this.labelImeKontakta = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.labelMaticniBroj = new System.Windows.Forms.Label();
            this.labelIDValue = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.textBoxMatBroj = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxBroj = new System.Windows.Forms.TextBox();
            this.textBoxImeKont = new System.Windows.Forms.TextBox();
            this.textBoxPIB = new System.Windows.Forms.TextBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelTipValue = new System.Windows.Forms.Label();
            this.labelPIB = new System.Windows.Forms.Label();
            this.buttonPromeniKomCvor = new System.Windows.Forms.Button();
            this.buttonZapamti = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelID.Location = new System.Drawing.Point(34, 28);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelNaziv.Location = new System.Drawing.Point(34, 83);
            this.labelNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(38, 13);
            this.labelNaziv.TabIndex = 1;
            this.labelNaziv.Text = "Naziv";
            this.labelNaziv.Click += new System.EventHandler(this.labelNaziv_Click);
            // 
            // labelGrad
            // 
            this.labelGrad.AutoSize = true;
            this.labelGrad.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelGrad.Location = new System.Drawing.Point(34, 124);
            this.labelGrad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGrad.Name = "labelGrad";
            this.labelGrad.Size = new System.Drawing.Size(40, 13);
            this.labelGrad.TabIndex = 2;
            this.labelGrad.Text = "Grad:";
            this.labelGrad.Click += new System.EventHandler(this.labelGrad_Click);
            // 
            // labelImeKontakta
            // 
            this.labelImeKontakta.AutoSize = true;
            this.labelImeKontakta.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelImeKontakta.Location = new System.Drawing.Point(34, 246);
            this.labelImeKontakta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImeKontakta.Name = "labelImeKontakta";
            this.labelImeKontakta.Size = new System.Drawing.Size(89, 13);
            this.labelImeKontakta.TabIndex = 3;
            this.labelImeKontakta.Text = "Ime kontakta:";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelBroj.Location = new System.Drawing.Point(34, 206);
            this.labelBroj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(36, 13);
            this.labelBroj.TabIndex = 4;
            this.labelBroj.Text = "Broj:";
            this.labelBroj.Click += new System.EventHandler(this.labelBroj_Click);
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelUlica.Location = new System.Drawing.Point(34, 166);
            this.labelUlica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(39, 13);
            this.labelUlica.TabIndex = 5;
            this.labelUlica.Text = "Ulica:";
            this.labelUlica.Click += new System.EventHandler(this.labelUlica_Click);
            // 
            // labelMaticniBroj
            // 
            this.labelMaticniBroj.AutoSize = true;
            this.labelMaticniBroj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelMaticniBroj.Location = new System.Drawing.Point(34, 287);
            this.labelMaticniBroj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaticniBroj.Name = "labelMaticniBroj";
            this.labelMaticniBroj.Size = new System.Drawing.Size(78, 13);
            this.labelMaticniBroj.TabIndex = 6;
            this.labelMaticniBroj.Text = "Maticni broj:";
            // 
            // labelIDValue
            // 
            this.labelIDValue.AutoSize = true;
            this.labelIDValue.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelIDValue.Location = new System.Drawing.Point(143, 28);
            this.labelIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDValue.Name = "labelIDValue";
            this.labelIDValue.Size = new System.Drawing.Size(131, 13);
            this.labelIDValue.TabIndex = 7;
            this.labelIDValue.Text = "                               ";
            this.labelIDValue.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxNaziv.Location = new System.Drawing.Point(145, 80);
            this.textBoxNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(116, 21);
            this.textBoxNaziv.TabIndex = 8;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxGrad.Location = new System.Drawing.Point(145, 122);
            this.textBoxGrad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(116, 21);
            this.textBoxGrad.TabIndex = 9;
            this.textBoxGrad.TextChanged += new System.EventHandler(this.textBoxGrad_TextChanged);
            // 
            // textBoxMatBroj
            // 
            this.textBoxMatBroj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxMatBroj.Location = new System.Drawing.Point(145, 284);
            this.textBoxMatBroj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMatBroj.Name = "textBoxMatBroj";
            this.textBoxMatBroj.Size = new System.Drawing.Size(116, 21);
            this.textBoxMatBroj.TabIndex = 10;
            this.textBoxMatBroj.TextChanged += new System.EventHandler(this.textBoxMatBroj_TextChanged);
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxUlica.Location = new System.Drawing.Point(145, 163);
            this.textBoxUlica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(116, 21);
            this.textBoxUlica.TabIndex = 11;
            this.textBoxUlica.TextChanged += new System.EventHandler(this.textBoxUlica_TextChanged);
            // 
            // textBoxBroj
            // 
            this.textBoxBroj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxBroj.Location = new System.Drawing.Point(145, 204);
            this.textBoxBroj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxBroj.Name = "textBoxBroj";
            this.textBoxBroj.Size = new System.Drawing.Size(116, 21);
            this.textBoxBroj.TabIndex = 12;
            this.textBoxBroj.TextChanged += new System.EventHandler(this.textBoxBroj_TextChanged);
            // 
            // textBoxImeKont
            // 
            this.textBoxImeKont.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxImeKont.Location = new System.Drawing.Point(145, 244);
            this.textBoxImeKont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImeKont.Name = "textBoxImeKont";
            this.textBoxImeKont.Size = new System.Drawing.Size(116, 21);
            this.textBoxImeKont.TabIndex = 13;
            this.textBoxImeKont.TextChanged += new System.EventHandler(this.textBoxImeKont_TextChanged);
            // 
            // textBoxPIB
            // 
            this.textBoxPIB.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxPIB.Location = new System.Drawing.Point(145, 325);
            this.textBoxPIB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPIB.Name = "textBoxPIB";
            this.textBoxPIB.Size = new System.Drawing.Size(116, 21);
            this.textBoxPIB.TabIndex = 14;
            this.textBoxPIB.TextChanged += new System.EventHandler(this.textBoxPIB_TextChanged);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelTip.Location = new System.Drawing.Point(34, 55);
            this.labelTip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(29, 13);
            this.labelTip.TabIndex = 15;
            this.labelTip.Text = "Tip:";
            this.labelTip.Click += new System.EventHandler(this.labelTip_Click);
            // 
            // labelTipValue
            // 
            this.labelTipValue.AutoSize = true;
            this.labelTipValue.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelTipValue.Location = new System.Drawing.Point(143, 55);
            this.labelTipValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipValue.Name = "labelTipValue";
            this.labelTipValue.Size = new System.Drawing.Size(70, 13);
            this.labelTipValue.TabIndex = 16;
            this.labelTipValue.Text = "Pravno lice";
            this.labelTipValue.Click += new System.EventHandler(this.labelTipValue_Click);
            // 
            // labelPIB
            // 
            this.labelPIB.AutoSize = true;
            this.labelPIB.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelPIB.Location = new System.Drawing.Point(34, 327);
            this.labelPIB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPIB.Name = "labelPIB";
            this.labelPIB.Size = new System.Drawing.Size(32, 13);
            this.labelPIB.TabIndex = 17;
            this.labelPIB.Text = "PIB:";
            // 
            // buttonPromeniKomCvor
            // 
            this.buttonPromeniKomCvor.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonPromeniKomCvor.Location = new System.Drawing.Point(37, 365);
            this.buttonPromeniKomCvor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPromeniKomCvor.Name = "buttonPromeniKomCvor";
            this.buttonPromeniKomCvor.Size = new System.Drawing.Size(188, 28);
            this.buttonPromeniKomCvor.TabIndex = 18;
            this.buttonPromeniKomCvor.Text = "Promeni Komunikacioni čvor";
            this.buttonPromeniKomCvor.UseVisualStyleBackColor = true;
            this.buttonPromeniKomCvor.Click += new System.EventHandler(this.buttonPromeniKomCvor_Click);
            // 
            // buttonZapamti
            // 
            this.buttonZapamti.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonZapamti.Location = new System.Drawing.Point(204, 411);
            this.buttonZapamti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZapamti.Name = "buttonZapamti";
            this.buttonZapamti.Size = new System.Drawing.Size(86, 23);
            this.buttonZapamti.TabIndex = 19;
            this.buttonZapamti.Text = "Zapamti";
            this.buttonZapamti.UseVisualStyleBackColor = true;
            this.buttonZapamti.Click += new System.EventHandler(this.buttonZapamti_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOtkazi.Location = new System.Drawing.Point(37, 411);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(86, 23);
            this.buttonOtkazi.TabIndex = 20;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // KlijentPravnoLiceIzmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 475);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonZapamti);
            this.Controls.Add(this.buttonPromeniKomCvor);
            this.Controls.Add(this.labelPIB);
            this.Controls.Add(this.labelTipValue);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.textBoxPIB);
            this.Controls.Add(this.textBoxImeKont);
            this.Controls.Add(this.textBoxBroj);
            this.Controls.Add(this.textBoxUlica);
            this.Controls.Add(this.textBoxMatBroj);
            this.Controls.Add(this.textBoxGrad);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.labelIDValue);
            this.Controls.Add(this.labelMaticniBroj);
            this.Controls.Add(this.labelUlica);
            this.Controls.Add(this.labelBroj);
            this.Controls.Add(this.labelImeKontakta);
            this.Controls.Add(this.labelGrad);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "KlijentPravnoLiceIzmena";
            this.Text = "PravnoLiceIzmena";
            this.Load += new System.EventHandler(this.KlijentPravnoLiceIzmena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelGrad;
        private System.Windows.Forms.Label labelImeKontakta;
        private System.Windows.Forms.Label labelBroj;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.Label labelMaticniBroj;
        private System.Windows.Forms.Label labelIDValue;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.TextBox textBoxMatBroj;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.TextBox textBoxBroj;
        private System.Windows.Forms.TextBox textBoxImeKont;
        private System.Windows.Forms.TextBox textBoxPIB;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelTipValue;
        private System.Windows.Forms.Label labelPIB;
        private System.Windows.Forms.Button buttonPromeniKomCvor;
        private System.Windows.Forms.Button buttonZapamti;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}