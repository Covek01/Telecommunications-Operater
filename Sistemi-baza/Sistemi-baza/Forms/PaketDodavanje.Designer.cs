namespace Telekomunikacija.Forms
{
    partial class PaketDodavanje
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
            this.lblUlica = new System.Windows.Forms.Label();
            this.txtImePaketa = new System.Windows.Forms.TextBox();
            this.btnDodajPaket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Verdana", 11.75F);
            this.lblUlica.Location = new System.Drawing.Point(11, 33);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(115, 18);
            this.lblUlica.TabIndex = 25;
            this.lblUlica.Text = "Ime paketa :";
            // 
            // txtImePaketa
            // 
            this.txtImePaketa.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.txtImePaketa.Location = new System.Drawing.Point(132, 28);
            this.txtImePaketa.Name = "txtImePaketa";
            this.txtImePaketa.Size = new System.Drawing.Size(158, 23);
            this.txtImePaketa.TabIndex = 26;
            // 
            // btnDodajPaket
            // 
            this.btnDodajPaket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodajPaket.Location = new System.Drawing.Point(98, 85);
            this.btnDodajPaket.Name = "btnDodajPaket";
            this.btnDodajPaket.Size = new System.Drawing.Size(89, 33);
            this.btnDodajPaket.TabIndex = 27;
            this.btnDodajPaket.Text = "Dodaj";
            this.btnDodajPaket.UseVisualStyleBackColor = true;
            this.btnDodajPaket.Click += new System.EventHandler(this.btnDodajPaket_Click);
            // 
            // PaketDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 155);
            this.Controls.Add(this.btnDodajPaket);
            this.Controls.Add(this.txtImePaketa);
            this.Controls.Add(this.lblUlica);
            this.Name = "PaketDodavanje";
            this.Text = "PaketDodavanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.TextBox txtImePaketa;
        private System.Windows.Forms.Button btnDodajPaket;
    }
}