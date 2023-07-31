namespace Telekomunikacija.Forms
{
    partial class UgovorForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.listViewKlijenti = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGrad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUlica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonUgovori = new System.Windows.Forms.Button();
            this.buttonUsluge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonOK.Location = new System.Drawing.Point(271, 315);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(82, 31);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // listViewKlijenti
            // 
            this.listViewKlijenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderIme,
            this.columnHeaderGrad,
            this.columnHeaderUlica,
            this.columnHeaderBroj,
            this.columnHeaderTip});
            this.listViewKlijenti.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewKlijenti.FullRowSelect = true;
            this.listViewKlijenti.HideSelection = false;
            this.listViewKlijenti.Location = new System.Drawing.Point(37, 28);
            this.listViewKlijenti.Margin = new System.Windows.Forms.Padding(2);
            this.listViewKlijenti.MultiSelect = false;
            this.listViewKlijenti.Name = "listViewKlijenti";
            this.listViewKlijenti.Size = new System.Drawing.Size(444, 258);
            this.listViewKlijenti.TabIndex = 1;
            this.listViewKlijenti.UseCompatibleStateImageBehavior = false;
            this.listViewKlijenti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderIme
            // 
            this.columnHeaderIme.Text = "Naziv";
            this.columnHeaderIme.Width = 127;
            // 
            // columnHeaderGrad
            // 
            this.columnHeaderGrad.Text = "Grad";
            this.columnHeaderGrad.Width = 120;
            // 
            // columnHeaderUlica
            // 
            this.columnHeaderUlica.Text = "Ulica";
            this.columnHeaderUlica.Width = 126;
            // 
            // columnHeaderBroj
            // 
            this.columnHeaderBroj.Text = "Broj";
            this.columnHeaderBroj.Width = 67;
            // 
            // columnHeaderTip
            // 
            this.columnHeaderTip.Text = "Tip";
            this.columnHeaderTip.Width = 61;
            // 
            // buttonUgovori
            // 
            this.buttonUgovori.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonUgovori.Location = new System.Drawing.Point(499, 36);
            this.buttonUgovori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUgovori.Name = "buttonUgovori";
            this.buttonUgovori.Size = new System.Drawing.Size(83, 37);
            this.buttonUgovori.TabIndex = 2;
            this.buttonUgovori.Text = "Prikaži ugovore";
            this.buttonUgovori.UseVisualStyleBackColor = true;
            this.buttonUgovori.Click += new System.EventHandler(this.buttonUgovori_Click);
            // 
            // buttonUsluge
            // 
            this.buttonUsluge.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonUsluge.Location = new System.Drawing.Point(499, 88);
            this.buttonUsluge.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUsluge.Name = "buttonUsluge";
            this.buttonUsluge.Size = new System.Drawing.Size(83, 37);
            this.buttonUsluge.TabIndex = 3;
            this.buttonUsluge.Text = "Prikaži usluge";
            this.buttonUsluge.UseVisualStyleBackColor = true;
            this.buttonUsluge.Click += new System.EventHandler(this.buttonUsluge_Click);
            // 
            // UgovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.buttonUsluge);
            this.Controls.Add(this.buttonUgovori);
            this.Controls.Add(this.listViewKlijenti);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UgovorForm";
            this.Text = "Spisak Klijenta";
            this.Load += new System.EventHandler(this.UgovorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uslugeView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ListView listViewKlijenti;
        private System.Windows.Forms.Button buttonUgovori;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderIme;
        private System.Windows.Forms.ColumnHeader columnHeaderGrad;
        private System.Windows.Forms.ColumnHeader columnHeaderUlica;
        private System.Windows.Forms.ColumnHeader columnHeaderBroj;
        private System.Windows.Forms.ColumnHeader columnHeaderTip;
        private System.Windows.Forms.Button buttonUsluge;
    }
}