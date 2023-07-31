namespace Sistemi_baza
{
    partial class Pocetna
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
            this.btnKlijentForma = new System.Windows.Forms.Button();
            this.btnUredjajForma = new System.Windows.Forms.Button();
            this.btnUslugaForma = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPaketi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKlijentForma
            // 
            this.btnKlijentForma.Location = new System.Drawing.Point(325, 88);
            this.btnKlijentForma.Name = "btnKlijentForma";
            this.btnKlijentForma.Size = new System.Drawing.Size(110, 35);
            this.btnKlijentForma.TabIndex = 0;
            this.btnKlijentForma.Text = "Klijenti";
            this.btnKlijentForma.UseVisualStyleBackColor = true;
            this.btnKlijentForma.Click += new System.EventHandler(this.btnKlijentForma_Click);
            // 
            // btnUredjajForma
            // 
            this.btnUredjajForma.Location = new System.Drawing.Point(325, 129);
            this.btnUredjajForma.Name = "btnUredjajForma";
            this.btnUredjajForma.Size = new System.Drawing.Size(110, 34);
            this.btnUredjajForma.TabIndex = 1;
            this.btnUredjajForma.Text = "Uredjaji";
            this.btnUredjajForma.UseVisualStyleBackColor = true;
            this.btnUredjajForma.Click += new System.EventHandler(this.btnUredjajForma_Click);
            // 
            // btnUslugaForma
            // 
            this.btnUslugaForma.Location = new System.Drawing.Point(325, 47);
            this.btnUslugaForma.Name = "btnUslugaForma";
            this.btnUslugaForma.Size = new System.Drawing.Size(110, 35);
            this.btnUslugaForma.TabIndex = 3;
            this.btnUslugaForma.Text = "Ugovori";
            this.btnUslugaForma.UseVisualStyleBackColor = true;
            this.btnUslugaForma.Click += new System.EventHandler(this.btnUslugaForma_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(476, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPaketi
            // 
            this.btnPaketi.Location = new System.Drawing.Point(325, 169);
            this.btnPaketi.Name = "btnPaketi";
            this.btnPaketi.Size = new System.Drawing.Size(110, 34);
            this.btnPaketi.TabIndex = 5;
            this.btnPaketi.Text = "Paketi";
            this.btnPaketi.UseVisualStyleBackColor = true;
            this.btnPaketi.Click += new System.EventHandler(this.btnPaketi_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Telekomunikacija.Properties.Resources.world_g36d7503eb_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(586, 277);
            this.Controls.Add(this.btnPaketi);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUslugaForma);
            this.Controls.Add(this.btnUredjajForma);
            this.Controls.Add(this.btnKlijentForma);
            this.Name = "Pocetna";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKlijentForma;
        private System.Windows.Forms.Button btnUredjajForma;
        private System.Windows.Forms.Button btnUslugaForma;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPaketi;
    }
}

