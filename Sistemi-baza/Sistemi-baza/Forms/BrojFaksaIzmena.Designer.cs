namespace Telekomunikacija.Forms
{
    partial class BrojFaksaIzmena
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
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.labelFormatUnosa = new System.Windows.Forms.Label();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.textBoxFaks = new System.Windows.Forms.TextBox();
            this.labelNoviBrojFaks = new System.Windows.Forms.Label();
            this.labelStariBrojFaksValue = new System.Windows.Forms.Label();
            this.labelStariBrojFaks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonOtkazi.Location = new System.Drawing.Point(52, 175);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(83, 24);
            this.buttonOtkazi.TabIndex = 13;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // labelFormatUnosa
            // 
            this.labelFormatUnosa.AutoSize = true;
            this.labelFormatUnosa.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelFormatUnosa.Location = new System.Drawing.Point(41, 117);
            this.labelFormatUnosa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormatUnosa.Name = "labelFormatUnosa";
            this.labelFormatUnosa.Size = new System.Drawing.Size(188, 13);
            this.labelFormatUnosa.TabIndex = 12;
            this.labelFormatUnosa.Text = "Format unosa:  F112233445566";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Font = new System.Drawing.Font("Verdana", 8F);
            this.buttonIzmeni.Location = new System.Drawing.Point(154, 175);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(83, 24);
            this.buttonIzmeni.TabIndex = 11;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // textBoxFaks
            // 
            this.textBoxFaks.Font = new System.Drawing.Font("Verdana", 8F);
            this.textBoxFaks.Location = new System.Drawing.Point(154, 77);
            this.textBoxFaks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFaks.Name = "textBoxFaks";
            this.textBoxFaks.Size = new System.Drawing.Size(146, 20);
            this.textBoxFaks.TabIndex = 10;
            // 
            // labelNoviBrojFaks
            // 
            this.labelNoviBrojFaks.AutoSize = true;
            this.labelNoviBrojFaks.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelNoviBrojFaks.Location = new System.Drawing.Point(41, 80);
            this.labelNoviBrojFaks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNoviBrojFaks.Name = "labelNoviBrojFaks";
            this.labelNoviBrojFaks.Size = new System.Drawing.Size(99, 13);
            this.labelNoviBrojFaks.TabIndex = 9;
            this.labelNoviBrojFaks.Text = "Novi broj faksa:";
            // 
            // labelStariBrojFaksValue
            // 
            this.labelStariBrojFaksValue.AutoSize = true;
            this.labelStariBrojFaksValue.Location = new System.Drawing.Point(131, 35);
            this.labelStariBrojFaksValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStariBrojFaksValue.Name = "labelStariBrojFaksValue";
            this.labelStariBrojFaksValue.Size = new System.Drawing.Size(73, 13);
            this.labelStariBrojFaksValue.TabIndex = 8;
            this.labelStariBrojFaksValue.Text = "                      ";
            // 
            // labelStariBrojFaks
            // 
            this.labelStariBrojFaks.AutoSize = true;
            this.labelStariBrojFaks.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelStariBrojFaks.Location = new System.Drawing.Point(41, 35);
            this.labelStariBrojFaks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStariBrojFaks.Name = "labelStariBrojFaks";
            this.labelStariBrojFaks.Size = new System.Drawing.Size(94, 13);
            this.labelStariBrojFaks.TabIndex = 7;
            this.labelStariBrojFaks.Text = "Stari broj faks:";
            // 
            // BrojFaksaIzmena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 235);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.labelFormatUnosa);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.textBoxFaks);
            this.Controls.Add(this.labelNoviBrojFaks);
            this.Controls.Add(this.labelStariBrojFaksValue);
            this.Controls.Add(this.labelStariBrojFaks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "BrojFaksaIzmena";
            this.Text = "Izmena broja faksa";
            this.Load += new System.EventHandler(this.BrojFaksaIzmena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Label labelFormatUnosa;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.TextBox textBoxFaks;
        private System.Windows.Forms.Label labelNoviBrojFaks;
        private System.Windows.Forms.Label labelStariBrojFaksValue;
        private System.Windows.Forms.Label labelStariBrojFaks;
    }
}