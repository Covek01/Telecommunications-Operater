namespace Telekomunikacija.Forms
{
    partial class PrikazUgovora
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
            this.listViewUgovori = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBrojUgovora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsluge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUgovori
            // 
            this.listViewUgovori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderBrojUgovora,
            this.columnHeaderUsluge});
            this.listViewUgovori.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewUgovori.FullRowSelect = true;
            this.listViewUgovori.HideSelection = false;
            this.listViewUgovori.Location = new System.Drawing.Point(34, 37);
            this.listViewUgovori.Margin = new System.Windows.Forms.Padding(2);
            this.listViewUgovori.MultiSelect = false;
            this.listViewUgovori.Name = "listViewUgovori";
            this.listViewUgovori.Size = new System.Drawing.Size(427, 243);
            this.listViewUgovori.TabIndex = 0;
            this.listViewUgovori.UseCompatibleStateImageBehavior = false;
            this.listViewUgovori.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderBrojUgovora
            // 
            this.columnHeaderBrojUgovora.Text = "Broj Ugovora";
            this.columnHeaderBrojUgovora.Width = 119;
            // 
            // columnHeaderUsluge
            // 
            this.columnHeaderUsluge.Text = "Usluge";
            this.columnHeaderUsluge.Width = 357;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonOK.Location = new System.Drawing.Point(273, 310);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(85, 30);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonDodaj.Location = new System.Drawing.Point(494, 54);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(82, 28);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonObrisi.Location = new System.Drawing.Point(494, 100);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(82, 32);
            this.buttonObrisi.TabIndex = 4;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // PrikazUgovora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 364);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listViewUgovori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PrikazUgovora";
            this.Text = "Prikaz Ugovora";
            this.Load += new System.EventHandler(this.PrikazUgovora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUgovori;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderBrojUgovora;
        private System.Windows.Forms.ColumnHeader columnHeaderUsluge;
    }
}