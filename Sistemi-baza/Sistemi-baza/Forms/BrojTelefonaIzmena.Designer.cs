namespace Telekomunikacija.Forms
{
    partial class BrojTelefonaIzmena
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
            this.labelStariBrojTel = new System.Windows.Forms.Label();
            this.labelStariBrojTelValue = new System.Windows.Forms.Label();
            this.labelNoviBrojTel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.labelFormatUnosa = new System.Windows.Forms.Label();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStariBrojTel
            // 
            this.labelStariBrojTel.AutoSize = true;
            this.labelStariBrojTel.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelStariBrojTel.Location = new System.Drawing.Point(44, 48);
            this.labelStariBrojTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStariBrojTel.Name = "labelStariBrojTel";
            this.labelStariBrojTel.Size = new System.Drawing.Size(116, 13);
            this.labelStariBrojTel.TabIndex = 0;
            this.labelStariBrojTel.Text = "Stari broj telefona:";
            // 
            // labelStariBrojTelValue
            // 
            this.labelStariBrojTelValue.AutoSize = true;
            this.labelStariBrojTelValue.Location = new System.Drawing.Point(134, 48);
            this.labelStariBrojTelValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStariBrojTelValue.Name = "labelStariBrojTelValue";
            this.labelStariBrojTelValue.Size = new System.Drawing.Size(73, 13);
            this.labelStariBrojTelValue.TabIndex = 1;
            this.labelStariBrojTelValue.Text = "                      ";
            // 
            // labelNoviBrojTel
            // 
            this.labelNoviBrojTel.AutoSize = true;
            this.labelNoviBrojTel.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelNoviBrojTel.Location = new System.Drawing.Point(44, 93);
            this.labelNoviBrojTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoviBrojTel.Name = "labelNoviBrojTel";
            this.labelNoviBrojTel.Size = new System.Drawing.Size(114, 13);
            this.labelNoviBrojTel.TabIndex = 2;
            this.labelNoviBrojTel.Text = "Novi broj telefona:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBox1.Location = new System.Drawing.Point(182, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzmeni.Location = new System.Drawing.Point(158, 188);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(83, 24);
            this.buttonIzmeni.TabIndex = 4;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // labelFormatUnosa
            // 
            this.labelFormatUnosa.AutoSize = true;
            this.labelFormatUnosa.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelFormatUnosa.Location = new System.Drawing.Point(44, 130);
            this.labelFormatUnosa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormatUnosa.Name = "labelFormatUnosa";
            this.labelFormatUnosa.Size = new System.Drawing.Size(162, 13);
            this.labelFormatUnosa.TabIndex = 5;
            this.labelFormatUnosa.Text = "Format unosa: 060/112233";
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonOtkazi.Location = new System.Drawing.Point(55, 188);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(83, 24);
            this.buttonOtkazi.TabIndex = 6;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // BrojTelefonaIzmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 259);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.labelFormatUnosa);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNoviBrojTel);
            this.Controls.Add(this.labelStariBrojTelValue);
            this.Controls.Add(this.labelStariBrojTel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "BrojTelefonaIzmena";
            this.Text = "Izmena broja telefona";
            this.Load += new System.EventHandler(this.BrojTelefonaIzmena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStariBrojTel;
        private System.Windows.Forms.Label labelStariBrojTelValue;
        private System.Windows.Forms.Label labelNoviBrojTel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Label labelFormatUnosa;
        private System.Windows.Forms.Button buttonOtkazi;
    }
}