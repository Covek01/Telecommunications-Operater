namespace Telekomunikacija.Forms
{
    partial class DodajTelBroj
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFormat = new System.Windows.Forms.Label();
            this.labelUnos = new System.Windows.Forms.Label();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 9;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelFormat.Location = new System.Drawing.Point(30, 84);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(169, 13);
            this.labelFormat.TabIndex = 8;
            this.labelFormat.Text = "Format unosa: 060/1234567";
            // 
            // labelUnos
            // 
            this.labelUnos.AutoSize = true;
            this.labelUnos.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelUnos.Location = new System.Drawing.Point(30, 51);
            this.labelUnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnos.Name = "labelUnos";
            this.labelUnos.Size = new System.Drawing.Size(88, 13);
            this.labelUnos.TabIndex = 7;
            this.labelUnos.Text = "Broj Telefona:";
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonOtkazi.Location = new System.Drawing.Point(39, 130);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(62, 24);
            this.buttonOtkazi.TabIndex = 6;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonPotvrdi.Location = new System.Drawing.Point(141, 130);
            this.buttonPotvrdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(62, 24);
            this.buttonPotvrdi.TabIndex = 5;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // DodajTelBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(245, 196);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelUnos);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonPotvrdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "DodajTelBroj";
            this.Text = "Dodavanje Telefonskog Broja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.Label labelUnos;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonPotvrdi;
    }
}