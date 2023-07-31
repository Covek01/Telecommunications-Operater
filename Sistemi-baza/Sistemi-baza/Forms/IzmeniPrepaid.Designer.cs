namespace Telekomunikacija.Forms
{
    partial class IzmeniPrepaid
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
            this.labelStanje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.buttonZapamti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStanje
            // 
            this.labelStanje.AutoSize = true;
            this.labelStanje.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.labelStanje.Location = new System.Drawing.Point(34, 54);
            this.labelStanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStanje.Name = "labelStanje";
            this.labelStanje.Size = new System.Drawing.Size(49, 13);
            this.labelStanje.TabIndex = 0;
            this.labelStanje.Text = "Stanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(34, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum Uplate:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(153, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 21);
            this.textBox1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 100);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOtkazi.Location = new System.Drawing.Point(40, 171);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(79, 30);
            this.buttonOtkazi.TabIndex = 5;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonZapamti
            // 
            this.buttonZapamti.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonZapamti.Location = new System.Drawing.Point(202, 171);
            this.buttonZapamti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZapamti.Name = "buttonZapamti";
            this.buttonZapamti.Size = new System.Drawing.Size(79, 30);
            this.buttonZapamti.TabIndex = 6;
            this.buttonZapamti.Text = "Zapamti";
            this.buttonZapamti.UseVisualStyleBackColor = true;
            this.buttonZapamti.Click += new System.EventHandler(this.buttonZapamti_Click);
            // 
            // IzmeniPrepaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 230);
            this.Controls.Add(this.buttonZapamti);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelStanje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "IzmeniPrepaid";
            this.Text = "IzmeniPrepaid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonZapamti;
    }
}