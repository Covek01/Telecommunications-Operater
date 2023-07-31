namespace Telekomunikacija.Forms
{
    partial class GlavnaStanicaDodavanje
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
            this.lblSerijskiBroj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBroj = new System.Windows.Forms.TextBox();
            this.txtNazivProizvodjaca = new System.Windows.Forms.TextBox();
            this.txtRazlogServisa = new System.Windows.Forms.TextBox();
            this.btnDodajCvor = new System.Windows.Forms.Button();
            this.dateZadnjiServis = new System.Windows.Forms.DateTimePicker();
            this.dateUpotrebaOd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSerijskiBroj
            // 
            this.lblSerijskiBroj.AutoSize = true;
            this.lblSerijskiBroj.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.lblSerijskiBroj.Location = new System.Drawing.Point(32, 60);
            this.lblSerijskiBroj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerijskiBroj.Name = "lblSerijskiBroj";
            this.lblSerijskiBroj.Size = new System.Drawing.Size(113, 18);
            this.lblSerijskiBroj.TabIndex = 29;
            this.lblSerijskiBroj.Text = "Serijski broj : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label1.Location = new System.Drawing.Point(22, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Naziv proizvodjaca :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Upotreba od :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label3.Location = new System.Drawing.Point(32, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Zadnji servis :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.label4.Location = new System.Drawing.Point(32, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Razlog servisa :";
            // 
            // txtBroj
            // 
            this.txtBroj.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txtBroj.Location = new System.Drawing.Point(190, 54);
            this.txtBroj.Margin = new System.Windows.Forms.Padding(4);
            this.txtBroj.Name = "txtBroj";
            this.txtBroj.Size = new System.Drawing.Size(220, 26);
            this.txtBroj.TabIndex = 34;
            // 
            // txtNazivProizvodjaca
            // 
            this.txtNazivProizvodjaca.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txtNazivProizvodjaca.Location = new System.Drawing.Point(190, 108);
            this.txtNazivProizvodjaca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNazivProizvodjaca.Name = "txtNazivProizvodjaca";
            this.txtNazivProizvodjaca.Size = new System.Drawing.Size(220, 26);
            this.txtNazivProizvodjaca.TabIndex = 35;
            // 
            // txtRazlogServisa
            // 
            this.txtRazlogServisa.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.txtRazlogServisa.Location = new System.Drawing.Point(190, 279);
            this.txtRazlogServisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazlogServisa.Name = "txtRazlogServisa";
            this.txtRazlogServisa.Size = new System.Drawing.Size(220, 26);
            this.txtRazlogServisa.TabIndex = 38;
            // 
            // btnDodajCvor
            // 
            this.btnDodajCvor.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.btnDodajCvor.Location = new System.Drawing.Point(63, 340);
            this.btnDodajCvor.Name = "btnDodajCvor";
            this.btnDodajCvor.Size = new System.Drawing.Size(124, 36);
            this.btnDodajCvor.TabIndex = 39;
            this.btnDodajCvor.Text = "Dodaj cvor";
            this.btnDodajCvor.UseVisualStyleBackColor = true;
            this.btnDodajCvor.Click += new System.EventHandler(this.btnDodajCvor_Click);
            // 
            // dateZadnjiServis
            // 
            this.dateZadnjiServis.CalendarFont = new System.Drawing.Font("Verdana", 8.25F);
            this.dateZadnjiServis.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.dateZadnjiServis.Location = new System.Drawing.Point(178, 220);
            this.dateZadnjiServis.Name = "dateZadnjiServis";
            this.dateZadnjiServis.Size = new System.Drawing.Size(281, 26);
            this.dateZadnjiServis.TabIndex = 40;
            // 
            // dateUpotrebaOd
            // 
            this.dateUpotrebaOd.CalendarFont = new System.Drawing.Font("Verdana", 8.25F);
            this.dateUpotrebaOd.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.dateUpotrebaOd.Location = new System.Drawing.Point(178, 169);
            this.dateUpotrebaOd.Name = "dateUpotrebaOd";
            this.dateUpotrebaOd.Size = new System.Drawing.Size(281, 26);
            this.dateUpotrebaOd.TabIndex = 42;
            // 
            // GlavnaStanicaDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 496);
            this.Controls.Add(this.dateUpotrebaOd);
            this.Controls.Add(this.dateZadnjiServis);
            this.Controls.Add(this.btnDodajCvor);
            this.Controls.Add(this.txtRazlogServisa);
            this.Controls.Add(this.txtNazivProizvodjaca);
            this.Controls.Add(this.txtBroj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSerijskiBroj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GlavnaStanicaDodavanje";
            this.Text = "GlavnaStanicaDodavanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerijskiBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBroj;
        private System.Windows.Forms.TextBox txtNazivProizvodjaca;
        private System.Windows.Forms.TextBox txtRazlogServisa;
        private System.Windows.Forms.Button btnDodajCvor;
        private System.Windows.Forms.DateTimePicker dateZadnjiServis;
        private System.Windows.Forms.DateTimePicker dateUpotrebaOd;
    }
}