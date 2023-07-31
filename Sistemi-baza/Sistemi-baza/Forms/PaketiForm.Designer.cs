namespace Telekomunikacija.Forms
{
    partial class PaketiForm
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
            this.listViewPaketi = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaketKanala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewKanali = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImeKanala = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajPaket = new System.Windows.Forms.Button();
            this.btnObrisiPaket = new System.Windows.Forms.Button();
            this.btnDodajKanal = new System.Windows.Forms.Button();
            this.btnObrisiKanal = new System.Windows.Forms.Button();
            this.txtImeKanala = new System.Windows.Forms.TextBox();
            this.lblUlica = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImePaketaSet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPaketi
            // 
            this.listViewPaketi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.PaketKanala});
            this.listViewPaketi.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewPaketi.FullRowSelect = true;
            this.listViewPaketi.HideSelection = false;
            this.listViewPaketi.Location = new System.Drawing.Point(18, 25);
            this.listViewPaketi.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPaketi.Name = "listViewPaketi";
            this.listViewPaketi.Size = new System.Drawing.Size(187, 175);
            this.listViewPaketi.TabIndex = 0;
            this.listViewPaketi.UseCompatibleStateImageBehavior = false;
            this.listViewPaketi.View = System.Windows.Forms.View.Details;
            this.listViewPaketi.SelectedIndexChanged += new System.EventHandler(this.listViewPaketi_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // PaketKanala
            // 
            this.PaketKanala.Text = "Paket kanala";
            this.PaketKanala.Width = 110;
            // 
            // listViewKanali
            // 
            this.listViewKanali.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.ImeKanala});
            this.listViewKanali.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.listViewKanali.FullRowSelect = true;
            this.listViewKanali.HideSelection = false;
            this.listViewKanali.Location = new System.Drawing.Point(18, 222);
            this.listViewKanali.Margin = new System.Windows.Forms.Padding(2);
            this.listViewKanali.Name = "listViewKanali";
            this.listViewKanali.Size = new System.Drawing.Size(187, 177);
            this.listViewKanali.TabIndex = 2;
            this.listViewKanali.UseCompatibleStateImageBehavior = false;
            this.listViewKanali.View = System.Windows.Forms.View.Details;
            this.listViewKanali.SelectedIndexChanged += new System.EventHandler(this.listViewKanali_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // ImeKanala
            // 
            this.ImeKanala.Text = "Ime kanala";
            this.ImeKanala.Width = 110;
            // 
            // btnDodajPaket
            // 
            this.btnDodajPaket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodajPaket.Location = new System.Drawing.Point(261, 25);
            this.btnDodajPaket.Name = "btnDodajPaket";
            this.btnDodajPaket.Size = new System.Drawing.Size(142, 31);
            this.btnDodajPaket.TabIndex = 3;
            this.btnDodajPaket.Text = "Dodaj paket";
            this.btnDodajPaket.UseVisualStyleBackColor = true;
            this.btnDodajPaket.Click += new System.EventHandler(this.btnDodajPaket_Click);
            // 
            // btnObrisiPaket
            // 
            this.btnObrisiPaket.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnObrisiPaket.Location = new System.Drawing.Point(261, 72);
            this.btnObrisiPaket.Name = "btnObrisiPaket";
            this.btnObrisiPaket.Size = new System.Drawing.Size(142, 34);
            this.btnObrisiPaket.TabIndex = 4;
            this.btnObrisiPaket.Text = "Obrisi paket";
            this.btnObrisiPaket.UseVisualStyleBackColor = true;
            this.btnObrisiPaket.Click += new System.EventHandler(this.btnObrisiPaket_Click);
            // 
            // btnDodajKanal
            // 
            this.btnDodajKanal.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnDodajKanal.Location = new System.Drawing.Point(247, 269);
            this.btnDodajKanal.Name = "btnDodajKanal";
            this.btnDodajKanal.Size = new System.Drawing.Size(140, 46);
            this.btnDodajKanal.TabIndex = 5;
            this.btnDodajKanal.Text = "Dodaj kanal za selektovani paket";
            this.btnDodajKanal.UseVisualStyleBackColor = true;
            this.btnDodajKanal.Click += new System.EventHandler(this.btnDodajKanal_Click);
            // 
            // btnObrisiKanal
            // 
            this.btnObrisiKanal.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnObrisiKanal.Location = new System.Drawing.Point(247, 352);
            this.btnObrisiKanal.Name = "btnObrisiKanal";
            this.btnObrisiKanal.Size = new System.Drawing.Size(140, 35);
            this.btnObrisiKanal.TabIndex = 6;
            this.btnObrisiKanal.Text = "Obrisi kanal";
            this.btnObrisiKanal.UseVisualStyleBackColor = true;
            this.btnObrisiKanal.Click += new System.EventHandler(this.btnObrisiKanal_Click);
            // 
            // txtImeKanala
            // 
            this.txtImeKanala.Location = new System.Drawing.Point(139, 77);
            this.txtImeKanala.Name = "txtImeKanala";
            this.txtImeKanala.Size = new System.Drawing.Size(130, 21);
            this.txtImeKanala.TabIndex = 7;
            // 
            // lblUlica
            // 
            this.lblUlica.AutoSize = true;
            this.lblUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUlica.Location = new System.Drawing.Point(16, 77);
            this.lblUlica.Name = "lblUlica";
            this.lblUlica.Size = new System.Drawing.Size(95, 20);
            this.lblUlica.TabIndex = 29;
            this.lblUlica.Text = "Ime kanala :";
            this.lblUlica.Click += new System.EventHandler(this.lblUlica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ime paketa  :";
            // 
            // lblImePaketaSet
            // 
            this.lblImePaketaSet.AutoSize = true;
            this.lblImePaketaSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePaketaSet.Location = new System.Drawing.Point(178, 38);
            this.lblImePaketaSet.Name = "lblImePaketaSet";
            this.lblImePaketaSet.Size = new System.Drawing.Size(0, 20);
            this.lblImePaketaSet.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblImePaketaSet);
            this.groupBox1.Controls.Add(this.txtImeKanala);
            this.groupBox1.Controls.Add(this.lblUlica);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(247, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 118);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje kanala";
            // 
            // PaketiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiKanal);
            this.Controls.Add(this.btnDodajKanal);
            this.Controls.Add(this.btnObrisiPaket);
            this.Controls.Add(this.btnDodajPaket);
            this.Controls.Add(this.listViewKanali);
            this.Controls.Add(this.listViewPaketi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PaketiForm";
            this.Text = "PaketiForm";
            this.Load += new System.EventHandler(this.PaketiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPaketi;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader PaketKanala;
        private System.Windows.Forms.ListView listViewKanali;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ImeKanala;
        private System.Windows.Forms.Button btnDodajPaket;
        private System.Windows.Forms.Button btnObrisiPaket;
        private System.Windows.Forms.Button btnDodajKanal;
        private System.Windows.Forms.Button btnObrisiKanal;
        private System.Windows.Forms.TextBox txtImeKanala;
        private System.Windows.Forms.Label lblUlica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImePaketaSet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}