namespace Telekomunikacija.Forms
{
    partial class PravnoLiceKontakt
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
            this.listViewTel = new System.Windows.Forms.ListView();
            this.columnHeaderTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFaks = new System.Windows.Forms.ListView();
            this.columnHeaderFaks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTelefonBr = new System.Windows.Forms.GroupBox();
            this.buttonObrisiTel = new System.Windows.Forms.Button();
            this.buttonIzmeniTel = new System.Windows.Forms.Button();
            this.buttonDodajTel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxFaksBr = new System.Windows.Forms.GroupBox();
            this.buttonObrisiFaks = new System.Windows.Forms.Button();
            this.buttonIzmeniFaks = new System.Windows.Forms.Button();
            this.buttonDodajFaks = new System.Windows.Forms.Button();
            this.groupBoxTelefonBr.SuspendLayout();
            this.groupBoxFaksBr.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewTel
            // 
            this.listViewTel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTel});
            this.listViewTel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewTel.FullRowSelect = true;
            this.listViewTel.HideSelection = false;
            this.listViewTel.Location = new System.Drawing.Point(20, 32);
            this.listViewTel.Margin = new System.Windows.Forms.Padding(2);
            this.listViewTel.MultiSelect = false;
            this.listViewTel.Name = "listViewTel";
            this.listViewTel.Size = new System.Drawing.Size(553, 143);
            this.listViewTel.TabIndex = 0;
            this.listViewTel.UseCompatibleStateImageBehavior = false;
            this.listViewTel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTel
            // 
            this.columnHeaderTel.Text = "Broj Telefona";
            this.columnHeaderTel.Width = 242;
            // 
            // listViewFaks
            // 
            this.listViewFaks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFaks});
            this.listViewFaks.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewFaks.FullRowSelect = true;
            this.listViewFaks.HideSelection = false;
            this.listViewFaks.Location = new System.Drawing.Point(18, 31);
            this.listViewFaks.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFaks.MultiSelect = false;
            this.listViewFaks.Name = "listViewFaks";
            this.listViewFaks.Size = new System.Drawing.Size(558, 141);
            this.listViewFaks.TabIndex = 1;
            this.listViewFaks.UseCompatibleStateImageBehavior = false;
            this.listViewFaks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFaks
            // 
            this.columnHeaderFaks.Text = "Brojevi Faksa";
            this.columnHeaderFaks.Width = 250;
            // 
            // groupBoxTelefonBr
            // 
            this.groupBoxTelefonBr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxTelefonBr.Controls.Add(this.buttonObrisiTel);
            this.groupBoxTelefonBr.Controls.Add(this.buttonIzmeniTel);
            this.groupBoxTelefonBr.Controls.Add(this.buttonDodajTel);
            this.groupBoxTelefonBr.Controls.Add(this.listViewTel);
            this.groupBoxTelefonBr.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxTelefonBr.Location = new System.Drawing.Point(14, 10);
            this.groupBoxTelefonBr.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTelefonBr.Name = "groupBoxTelefonBr";
            this.groupBoxTelefonBr.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTelefonBr.Size = new System.Drawing.Size(731, 197);
            this.groupBoxTelefonBr.TabIndex = 2;
            this.groupBoxTelefonBr.TabStop = false;
            this.groupBoxTelefonBr.Text = "Brojevi telefona";
            // 
            // buttonObrisiTel
            // 
            this.buttonObrisiTel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonObrisiTel.Location = new System.Drawing.Point(624, 144);
            this.buttonObrisiTel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisiTel.Name = "buttonObrisiTel";
            this.buttonObrisiTel.Size = new System.Drawing.Size(79, 31);
            this.buttonObrisiTel.TabIndex = 3;
            this.buttonObrisiTel.Text = "Obrisi";
            this.buttonObrisiTel.UseVisualStyleBackColor = true;
            this.buttonObrisiTel.Click += new System.EventHandler(this.buttonObrisiTel_Click);
            // 
            // buttonIzmeniTel
            // 
            this.buttonIzmeniTel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonIzmeniTel.Location = new System.Drawing.Point(624, 87);
            this.buttonIzmeniTel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeniTel.Name = "buttonIzmeniTel";
            this.buttonIzmeniTel.Size = new System.Drawing.Size(81, 31);
            this.buttonIzmeniTel.TabIndex = 2;
            this.buttonIzmeniTel.Text = "Izmeni";
            this.buttonIzmeniTel.UseVisualStyleBackColor = true;
            this.buttonIzmeniTel.Click += new System.EventHandler(this.buttonIzmeniTel_Click);
            // 
            // buttonDodajTel
            // 
            this.buttonDodajTel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonDodajTel.Location = new System.Drawing.Point(624, 32);
            this.buttonDodajTel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajTel.Name = "buttonDodajTel";
            this.buttonDodajTel.Size = new System.Drawing.Size(82, 31);
            this.buttonDodajTel.TabIndex = 1;
            this.buttonDodajTel.Text = "Dodaj";
            this.buttonDodajTel.UseVisualStyleBackColor = true;
            this.buttonDodajTel.Click += new System.EventHandler(this.buttonDodajTel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonOk.Location = new System.Drawing.Point(287, 425);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(86, 29);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxFaksBr
            // 
            this.groupBoxFaksBr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxFaksBr.Controls.Add(this.buttonObrisiFaks);
            this.groupBoxFaksBr.Controls.Add(this.buttonIzmeniFaks);
            this.groupBoxFaksBr.Controls.Add(this.buttonDodajFaks);
            this.groupBoxFaksBr.Controls.Add(this.listViewFaks);
            this.groupBoxFaksBr.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBoxFaksBr.Location = new System.Drawing.Point(11, 211);
            this.groupBoxFaksBr.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFaksBr.Name = "groupBoxFaksBr";
            this.groupBoxFaksBr.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFaksBr.Size = new System.Drawing.Size(734, 200);
            this.groupBoxFaksBr.TabIndex = 3;
            this.groupBoxFaksBr.TabStop = false;
            this.groupBoxFaksBr.Text = "Faks brojevi";
            // 
            // buttonObrisiFaks
            // 
            this.buttonObrisiFaks.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonObrisiFaks.Location = new System.Drawing.Point(628, 138);
            this.buttonObrisiFaks.Margin = new System.Windows.Forms.Padding(2);
            this.buttonObrisiFaks.Name = "buttonObrisiFaks";
            this.buttonObrisiFaks.Size = new System.Drawing.Size(83, 34);
            this.buttonObrisiFaks.TabIndex = 4;
            this.buttonObrisiFaks.Text = "Obrisi";
            this.buttonObrisiFaks.UseVisualStyleBackColor = true;
            this.buttonObrisiFaks.Click += new System.EventHandler(this.buttonObrisiFaks_Click);
            // 
            // buttonIzmeniFaks
            // 
            this.buttonIzmeniFaks.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonIzmeniFaks.Location = new System.Drawing.Point(628, 84);
            this.buttonIzmeniFaks.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzmeniFaks.Name = "buttonIzmeniFaks";
            this.buttonIzmeniFaks.Size = new System.Drawing.Size(83, 33);
            this.buttonIzmeniFaks.TabIndex = 3;
            this.buttonIzmeniFaks.Text = "Izmeni";
            this.buttonIzmeniFaks.UseVisualStyleBackColor = true;
            this.buttonIzmeniFaks.Click += new System.EventHandler(this.buttonIzmeniFaks_Click);
            // 
            // buttonDodajFaks
            // 
            this.buttonDodajFaks.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.buttonDodajFaks.Location = new System.Drawing.Point(628, 31);
            this.buttonDodajFaks.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajFaks.Name = "buttonDodajFaks";
            this.buttonDodajFaks.Size = new System.Drawing.Size(83, 32);
            this.buttonDodajFaks.TabIndex = 2;
            this.buttonDodajFaks.Text = "Dodaj";
            this.buttonDodajFaks.UseVisualStyleBackColor = true;
            this.buttonDodajFaks.Click += new System.EventHandler(this.buttonDodajFaks_Click);
            // 
            // PravnoLiceKontakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 471);
            this.Controls.Add(this.groupBoxFaksBr);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTelefonBr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "PravnoLiceKontakt";
            this.Text = "Kontakt Informacije";
            this.Load += new System.EventHandler(this.PravnoLiceKontakt_Load);
            this.groupBoxTelefonBr.ResumeLayout(false);
            this.groupBoxFaksBr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTel;
        private System.Windows.Forms.ListView listViewFaks;
        private System.Windows.Forms.GroupBox groupBoxTelefonBr;
        private System.Windows.Forms.Button buttonObrisiTel;
        private System.Windows.Forms.Button buttonIzmeniTel;
        private System.Windows.Forms.Button buttonDodajTel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBoxFaksBr;
        private System.Windows.Forms.Button buttonObrisiFaks;
        private System.Windows.Forms.Button buttonIzmeniFaks;
        private System.Windows.Forms.Button buttonDodajFaks;
        private System.Windows.Forms.ColumnHeader columnHeaderTel;
        private System.Windows.Forms.ColumnHeader columnHeaderFaks;
    }
}