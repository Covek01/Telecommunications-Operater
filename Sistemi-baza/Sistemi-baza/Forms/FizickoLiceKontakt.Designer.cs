namespace Telekomunikacija.Forms
{
    partial class FizickoLiceKontakt
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
            this.buttonObrisiTel = new System.Windows.Forms.Button();
            this.buttonIzmeniTel = new System.Windows.Forms.Button();
            this.buttonDodajTel = new System.Windows.Forms.Button();
            this.listViewBrojevi = new System.Windows.Forms.ListView();
            this.columnHeaderBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTelefonBr = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxTelefonBr.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonObrisiTel
            // 
            this.buttonObrisiTel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonObrisiTel.Location = new System.Drawing.Point(361, 89);
            this.buttonObrisiTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonObrisiTel.Name = "buttonObrisiTel";
            this.buttonObrisiTel.Size = new System.Drawing.Size(65, 25);
            this.buttonObrisiTel.TabIndex = 3;
            this.buttonObrisiTel.Text = "Obrisi";
            this.buttonObrisiTel.UseVisualStyleBackColor = true;
            this.buttonObrisiTel.Click += new System.EventHandler(this.buttonObrisiTel_Click);
            // 
            // buttonIzmeniTel
            // 
            this.buttonIzmeniTel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonIzmeniTel.Location = new System.Drawing.Point(361, 58);
            this.buttonIzmeniTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIzmeniTel.Name = "buttonIzmeniTel";
            this.buttonIzmeniTel.Size = new System.Drawing.Size(65, 25);
            this.buttonIzmeniTel.TabIndex = 2;
            this.buttonIzmeniTel.Text = "Izmeni";
            this.buttonIzmeniTel.UseVisualStyleBackColor = true;
            this.buttonIzmeniTel.Click += new System.EventHandler(this.buttonIzmeniTel_Click);
            // 
            // buttonDodajTel
            // 
            this.buttonDodajTel.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonDodajTel.Location = new System.Drawing.Point(361, 28);
            this.buttonDodajTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDodajTel.Name = "buttonDodajTel";
            this.buttonDodajTel.Size = new System.Drawing.Size(65, 25);
            this.buttonDodajTel.TabIndex = 1;
            this.buttonDodajTel.Text = "Dodaj";
            this.buttonDodajTel.UseVisualStyleBackColor = true;
            this.buttonDodajTel.Click += new System.EventHandler(this.buttonDodajTel_Click);
            // 
            // listViewBrojevi
            // 
            this.listViewBrojevi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBroj});
            this.listViewBrojevi.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.listViewBrojevi.FullRowSelect = true;
            this.listViewBrojevi.HideSelection = false;
            this.listViewBrojevi.Location = new System.Drawing.Point(14, 28);
            this.listViewBrojevi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewBrojevi.MultiSelect = false;
            this.listViewBrojevi.Name = "listViewBrojevi";
            this.listViewBrojevi.Size = new System.Drawing.Size(283, 94);
            this.listViewBrojevi.TabIndex = 0;
            this.listViewBrojevi.UseCompatibleStateImageBehavior = false;
            this.listViewBrojevi.View = System.Windows.Forms.View.Details;
            this.listViewBrojevi.SelectedIndexChanged += new System.EventHandler(this.listViewBrojevi_SelectedIndexChanged);
            // 
            // columnHeaderBroj
            // 
            this.columnHeaderBroj.Text = "Broj Telefona";
            this.columnHeaderBroj.Width = 171;
            // 
            // groupBoxTelefonBr
            // 
            this.groupBoxTelefonBr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxTelefonBr.Controls.Add(this.buttonObrisiTel);
            this.groupBoxTelefonBr.Controls.Add(this.buttonIzmeniTel);
            this.groupBoxTelefonBr.Controls.Add(this.buttonDodajTel);
            this.groupBoxTelefonBr.Controls.Add(this.listViewBrojevi);
            this.groupBoxTelefonBr.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxTelefonBr.Location = new System.Drawing.Point(8, 10);
            this.groupBoxTelefonBr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTelefonBr.Name = "groupBoxTelefonBr";
            this.groupBoxTelefonBr.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTelefonBr.Size = new System.Drawing.Size(493, 139);
            this.groupBoxTelefonBr.TabIndex = 3;
            this.groupBoxTelefonBr.TabStop = false;
            this.groupBoxTelefonBr.Text = "Brojevi telefona";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.buttonOK.Location = new System.Drawing.Point(243, 189);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(69, 27);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FizickoLiceKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 244);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxTelefonBr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FizickoLiceKontakt";
            this.Text = "PravnoLiceKontakt";
            this.Load += new System.EventHandler(this.FizickoLiceKontakt_Load);
            this.groupBoxTelefonBr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonObrisiTel;
        private System.Windows.Forms.Button buttonIzmeniTel;
        private System.Windows.Forms.Button buttonDodajTel;
        private System.Windows.Forms.ListView listViewBrojevi;
        private System.Windows.Forms.GroupBox groupBoxTelefonBr;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ColumnHeader columnHeaderBroj;
    }
}