namespace Telekomunikacija.Forms
{
    partial class IzmeniOstvareni
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
            this.labelDanDan = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.textBoxDanPlac = new System.Windows.Forms.TextBox();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.buttonZapamti = new System.Windows.Forms.Button();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPotr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDanDan
            // 
            this.labelDanDan.AutoSize = true;
            this.labelDanDan.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelDanDan.Location = new System.Drawing.Point(10, 51);
            this.labelDanDan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDanDan.Name = "labelDanDan";
            this.labelDanDan.Size = new System.Drawing.Size(87, 13);
            this.labelDanDan.TabIndex = 0;
            this.labelDanDan.Text = "Dan plaćanja:";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelCena.Location = new System.Drawing.Point(10, 93);
            this.labelCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(67, 13);
            this.labelCena.TabIndex = 1;
            this.labelCena.Text = "Cena MB: ";
            // 
            // textBoxDanPlac
            // 
            this.textBoxDanPlac.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxDanPlac.Location = new System.Drawing.Point(130, 51);
            this.textBoxDanPlac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDanPlac.Name = "textBoxDanPlac";
            this.textBoxDanPlac.Size = new System.Drawing.Size(90, 21);
            this.textBoxDanPlac.TabIndex = 2;
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOtkazi.Location = new System.Drawing.Point(28, 177);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(93, 24);
            this.buttonOtkazi.TabIndex = 5;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonZapamti
            // 
            this.buttonZapamti.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonZapamti.Location = new System.Drawing.Point(217, 177);
            this.buttonZapamti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZapamti.Name = "buttonZapamti";
            this.buttonZapamti.Size = new System.Drawing.Size(93, 24);
            this.buttonZapamti.TabIndex = 6;
            this.buttonZapamti.Text = "Zapamti";
            this.buttonZapamti.UseVisualStyleBackColor = true;
            this.buttonZapamti.Click += new System.EventHandler(this.buttonZapamti_Click);
            // 
            // textBoxCena
            // 
            this.textBoxCena.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBoxCena.Location = new System.Drawing.Point(130, 93);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(90, 21);
            this.textBoxCena.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(130, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 21);
            this.textBox2.TabIndex = 8;
            // 
            // labelPotr
            // 
            this.labelPotr.AutoSize = true;
            this.labelPotr.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelPotr.Location = new System.Drawing.Point(10, 134);
            this.labelPotr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPotr.Name = "labelPotr";
            this.labelPotr.Size = new System.Drawing.Size(73, 13);
            this.labelPotr.TabIndex = 9;
            this.labelPotr.Text = "Potrošeno: ";
            // 
            // IzmeniOstvareni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 230);
            this.Controls.Add(this.labelPotr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.buttonZapamti);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.textBoxDanPlac);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelDanDan);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "IzmeniOstvareni";
            this.Text = "IzmeniPrepaid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDanDan;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxDanPlac;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonZapamti;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPotr;
    }
}