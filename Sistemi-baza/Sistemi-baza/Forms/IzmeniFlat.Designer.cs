namespace Telekomunikacija.Forms
{
    partial class IzmeniFlat
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
            this.labelMes = new System.Windows.Forms.Label();
            this.labela1 = new System.Windows.Forms.Label();
            this.textBoxMes = new System.Windows.Forms.TextBox();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.buttonZapamti = new System.Windows.Forms.Button();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.labela2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelMes.Location = new System.Drawing.Point(9, 51);
            this.labelMes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(96, 13);
            this.labelMes.TabIndex = 0;
            this.labelMes.Text = "Mesečna cena: ";
            // 
            // labela1
            // 
            this.labela1.AutoSize = true;
            this.labela1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labela1.Location = new System.Drawing.Point(9, 93);
            this.labela1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labela1.Name = "labela1";
            this.labela1.Size = new System.Drawing.Size(67, 13);
            this.labela1.TabIndex = 1;
            this.labela1.Text = "Adresa 1: ";
            // 
            // textBoxMes
            // 
            this.textBoxMes.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxMes.Location = new System.Drawing.Point(123, 48);
            this.textBoxMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMes.Name = "textBoxMes";
            this.textBoxMes.Size = new System.Drawing.Size(78, 21);
            this.textBoxMes.TabIndex = 2;
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOtkazi.Location = new System.Drawing.Point(24, 180);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(68, 21);
            this.buttonOtkazi.TabIndex = 5;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonZapamti
            // 
            this.buttonZapamti.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonZapamti.Location = new System.Drawing.Point(142, 180);
            this.buttonZapamti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZapamti.Name = "buttonZapamti";
            this.buttonZapamti.Size = new System.Drawing.Size(69, 21);
            this.buttonZapamti.TabIndex = 6;
            this.buttonZapamti.Text = "Zapamti";
            this.buttonZapamti.UseVisualStyleBackColor = true;
            this.buttonZapamti.Click += new System.EventHandler(this.buttonZapamti_Click);
            // 
            // textBoxA1
            // 
            this.textBoxA1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxA1.Location = new System.Drawing.Point(123, 90);
            this.textBoxA1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(78, 21);
            this.textBoxA1.TabIndex = 7;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxA2.Location = new System.Drawing.Point(123, 129);
            this.textBoxA2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(78, 21);
            this.textBoxA2.TabIndex = 8;
            // 
            // labela2
            // 
            this.labela2.AutoSize = true;
            this.labela2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labela2.Location = new System.Drawing.Point(9, 134);
            this.labela2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labela2.Name = "labela2";
            this.labela2.Size = new System.Drawing.Size(67, 13);
            this.labela2.TabIndex = 9;
            this.labela2.Text = "Adresa 2: ";
            // 
            // IzmeniFlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 230);
            this.Controls.Add(this.labela2);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.textBoxA1);
            this.Controls.Add(this.buttonZapamti);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.textBoxMes);
            this.Controls.Add(this.labela1);
            this.Controls.Add(this.labelMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "IzmeniFlat";
            this.Text = "IzmeniPrepaid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labela1;
        private System.Windows.Forms.TextBox textBoxMes;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonZapamti;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.Label labela2;
    }
}