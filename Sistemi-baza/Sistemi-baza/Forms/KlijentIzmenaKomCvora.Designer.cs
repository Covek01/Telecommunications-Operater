namespace Telekomunikacija.Forms
{
    partial class KlijentIzmenaKomCvora
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
            this.lvIzmenaKomCvora = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonIzaberi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvIzmenaKomCvora
            // 
            this.lvIzmenaKomCvora.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Grad,
            this.Ulica,
            this.Broj});
            this.lvIzmenaKomCvora.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lvIzmenaKomCvora.FullRowSelect = true;
            this.lvIzmenaKomCvora.HideSelection = false;
            this.lvIzmenaKomCvora.Location = new System.Drawing.Point(28, 20);
            this.lvIzmenaKomCvora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvIzmenaKomCvora.MultiSelect = false;
            this.lvIzmenaKomCvora.Name = "lvIzmenaKomCvora";
            this.lvIzmenaKomCvora.Size = new System.Drawing.Size(374, 267);
            this.lvIzmenaKomCvora.TabIndex = 0;
            this.lvIzmenaKomCvora.UseCompatibleStateImageBehavior = false;
            this.lvIzmenaKomCvora.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            this.Grad.Width = 107;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.Width = 124;
            // 
            // Broj
            // 
            this.Broj.Text = "Broj";
            this.Broj.Width = 64;
            // 
            // buttonIzaberi
            // 
            this.buttonIzaberi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonIzaberi.Location = new System.Drawing.Point(256, 327);
            this.buttonIzaberi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzaberi.Name = "buttonIzaberi";
            this.buttonIzaberi.Size = new System.Drawing.Size(100, 24);
            this.buttonIzaberi.TabIndex = 1;
            this.buttonIzaberi.Text = "Izaberi";
            this.buttonIzaberi.UseVisualStyleBackColor = true;
            this.buttonIzaberi.Click += new System.EventHandler(this.buttonIzaberi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOtkazi.Location = new System.Drawing.Point(28, 327);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(100, 24);
            this.buttonOtkazi.TabIndex = 2;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // KlijentIzmenaKomCvora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(429, 388);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonIzaberi);
            this.Controls.Add(this.lvIzmenaKomCvora);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "KlijentIzmenaKomCvora";
            this.Text = "Izabir Novog Komunikacionog Cvora";
            this.Load += new System.EventHandler(this.KlijentIzmenaKomCvora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvIzmenaKomCvora;
        private System.Windows.Forms.Button buttonIzaberi;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Broj;
    }
}