namespace PlesnaSkola.WinUI.Clanovi
{
    partial class frmClanovi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPasosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvClanovi);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clanovi";
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.AllowUserToResizeColumns = false;
            this.dgvClanovi.AllowUserToResizeRows = false;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.ImePrezime,
            this.Mail,
            this.DatumRodjenja,
            this.BrojPasosa,
            this.Aktivan});
            this.dgvClanovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClanovi.Location = new System.Drawing.Point(3, 16);
            this.dgvClanovi.MultiSelect = false;
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClanovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClanovi.Size = new System.Drawing.Size(769, 333);
            this.dgvClanovi.TabIndex = 0;
            this.dgvClanovi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClanovi_CellDoubleClick);
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "KorisnikId";
            this.KorisnikId.Name = "KorisnikId";
            this.KorisnikId.ReadOnly = true;
            this.KorisnikId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 150;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "Mail adresa";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            this.Mail.Width = 150;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenjaPrikaz";
            this.DatumRodjenja.HeaderText = "Datum rođenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            this.DatumRodjenja.ReadOnly = true;
            // 
            // BrojPasosa
            // 
            this.BrojPasosa.DataPropertyName = "BrojPasosa";
            this.BrojPasosa.HeaderText = "Broj pasoša";
            this.BrojPasosa.Name = "BrojPasosa";
            this.BrojPasosa.ReadOnly = true;
            this.BrojPasosa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.FalseValue = "0";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.TrueValue = "1";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(242, 20);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretraga_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime ili prezime člana:";
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.Location = new System.Drawing.Point(15, 444);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(75, 23);
            this.btnDodajClana.TabIndex = 4;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = true;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Plesači/Roditelji:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(280, 33);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 9;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // frmClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnDodajClana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmClanovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Članovi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClanovi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPasosa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}