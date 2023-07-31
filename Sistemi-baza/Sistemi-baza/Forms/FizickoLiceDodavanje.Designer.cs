namespace Telekomunikacija.Forms
{
    partial class FizickoLiceDodavanje
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
            this.listViewCvorovi = new System.Windows.Forms.ListView();
            this.SerijskiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proizvodjac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCvor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCvorovi
            // 
            this.listViewCvorovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerijskiBroj,
            this.Proizvodjac});
            this.listViewCvorovi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.listViewCvorovi.FullRowSelect = true;
            this.listViewCvorovi.HideSelection = false;
            this.listViewCvorovi.Location = new System.Drawing.Point(300, 43);
            this.listViewCvorovi.Name = "listViewCvorovi";
            this.listViewCvorovi.Size = new System.Drawing.Size(208, 301);
            this.listViewCvorovi.TabIndex = 30;
            this.listViewCvorovi.UseCompatibleStateImageBehavior = false;
            this.listViewCvorovi.View = System.Windows.Forms.View.Details;
            this.listViewCvorovi.SelectedIndexChanged += new System.EventHandler(this.listViewCvorovi_SelectedIndexChanged);
            // 
            // SerijskiBroj
            // 
            this.SerijskiBroj.Text = "Serijski broj";
            this.SerijskiBroj.Width = 100;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.Text = "Proizvodjac";
            this.Proizvodjac.Width = 100;
            // 
            // txtCvor
            // 
            this.txtCvor.Enabled = false;
            this.txtCvor.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtCvor.Location = new System.Drawing.Point(95, 242);
            this.txtCvor.Name = "txtCvor";
            this.txtCvor.ReadOnly = true;
            this.txtCvor.Size = new System.Drawing.Size(135, 21);
            this.txtCvor.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F);
            this.label4.Location = new System.Drawing.Point(17, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cvor :";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtJMBG.Location = new System.Drawing.Point(95, 203);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(135, 21);
            this.txtJMBG.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F);
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "JMBG :";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblBroj.Location = new System.Drawing.Point(17, 154);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(51, 18);
            this.lblBroj.TabIndex = 25;
            this.lblBroj.Text = "Broj :";
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblUlica.Location = new System.Drawing.Point(17, 114);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(54, 18);
            this.lblUlica.TabIndex = 24;
            this.lblUlica.Text = "Ulica :";
            // 
            // txtBroj
            // 
            this.txtBroj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtBroj.Location = new System.Drawing.Point(95, 156);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(135, 21);
            this.txtBroj.TabIndex = 23;
            // 
            // txtUlica
            // 
            this.txtUlica.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtUlica.Location = new System.Drawing.Point(95, 116);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(135, 21);
            this.txtUlica.TabIndex = 22;
            // 
            // txtGrad
            // 
            this.txtGrad.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtGrad.Location = new System.Drawing.Point(95, 76);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(135, 21);
            this.txtGrad.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Grad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ime :";
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtIme.Location = new System.Drawing.Point(95, 33);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(135, 21);
            this.txtIme.TabIndex = 18;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnDodaj.Location = new System.Drawing.Point(20, 301);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 33);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj klijenta";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Izaberi cvor:";
            // 
            // FizickoLiceDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listViewCvorovi);
            this.Controls.Add(this.txtCvor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblUlica);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FizickoLiceDodavanje";
            this.Text = "FizickoLiceDodavanje";
            this.Load += new System.EventHandler(this.FizickoLiceDodavanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCvorovi;
        private System.Windows.Forms.ColumnHeader SerijskiBroj;
        private System.Windows.Forms.ColumnHeader Proizvodjac;
        private System.Windows.Forms.TextBox txtCvor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label5;
    }
}