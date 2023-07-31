namespace Telekomunikacija.Entiteti
{
    partial class KanalDodavanje
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
            this.btnDodajKanal = new System.Windows.Forms.Button();
            this.txtImeKanala = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajKanal
            // 
            this.btnDodajKanal.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnDodajKanal.Location = new System.Drawing.Point(98, 87);
            this.btnDodajKanal.Name = "btnDodajKanal";
            this.btnDodajKanal.Size = new System.Drawing.Size(89, 33);
            this.btnDodajKanal.TabIndex = 30;
            this.btnDodajKanal.Text = "Dodaj";
            this.btnDodajKanal.UseVisualStyleBackColor = true;
            this.btnDodajKanal.Click += new System.EventHandler(this.btnDodajKanal_Click);
            // 
            // txtImeKanala
            // 
            this.txtImeKanala.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtImeKanala.Location = new System.Drawing.Point(132, 30);
            this.txtImeKanala.Name = "txtImeKanala";
            this.txtImeKanala.Size = new System.Drawing.Size(158, 21);
            this.txtImeKanala.TabIndex = 29;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblUlica.Location = new System.Drawing.Point(12, 33);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(113, 18);
            this.lblUlica.TabIndex = 28;
            this.lblUlica.Text = "Ime kanala :";
            // 
            // KanalDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 163);
            this.Controls.Add(this.btnDodajKanal);
            this.Controls.Add(this.txtImeKanala);
            this.Controls.Add(this.lblUlica);
            this.Name = "KanalDodavanje";
            this.Text = "KanalDodavanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKanal;
        private System.Windows.Forms.TextBox txtImeKanala;
        private System.Windows.Forms.Label lblUlica;
    }
}