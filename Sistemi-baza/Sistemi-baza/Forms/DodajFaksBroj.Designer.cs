namespace Telekomunikacija.Forms
{
    partial class DodajFaksBroj
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
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.labelUnos = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonPotvrdi.Location = new System.Drawing.Point(148, 136);
            this.buttonPotvrdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(62, 24);
            this.buttonPotvrdi.TabIndex = 0;
            this.buttonPotvrdi.Text = "Potvrdi";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonOtkazi.Location = new System.Drawing.Point(46, 136);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(62, 24);
            this.buttonOtkazi.TabIndex = 1;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // labelUnos
            // 
            this.labelUnos.AutoSize = true;
            this.labelUnos.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelUnos.Location = new System.Drawing.Point(58, 58);
            this.labelUnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnos.Name = "labelUnos";
            this.labelUnos.Size = new System.Drawing.Size(64, 13);
            this.labelUnos.TabIndex = 2;
            this.labelUnos.Text = "Faks broj:";
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelFormat.Location = new System.Drawing.Point(58, 88);
            this.labelFormat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(184, 13);
            this.labelFormat.TabIndex = 3;
            this.labelFormat.Text = "Format unosa: F112233445566";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 4;
            // 
            // DodajFaksBroj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(270, 220);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.labelUnos);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonPotvrdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "DodajFaksBroj";
            this.Text = "Dodavanje Faks Broja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Label labelUnos;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.TextBox textBox1;
    }
}