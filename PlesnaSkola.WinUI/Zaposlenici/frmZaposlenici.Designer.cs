namespace PlesnaSkola.WinUI.Zaposlenici
{
    partial class frmZaposlenici
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
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPasosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajVoditelja = new System.Windows.Forms.Button();
            this.btnDodajTrenera = new System.Windows.Forms.Button();
            this.btnDodajAsistenta = new System.Windows.Forms.Button();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvZaposlenici);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaposlenici";
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.AllowUserToAddRows = false;
            this.dgvZaposlenici.AllowUserToDeleteRows = false;
            this.dgvZaposlenici.AllowUserToResizeColumns = false;
            this.dgvZaposlenici.AllowUserToResizeRows = false;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KorisnikId,
            this.ImePrezime,
            this.Mail,
            this.DatumRodjenja,
            this.BrojPasosa,
            this.Aktivan,
            this.Uloga});
            this.dgvZaposlenici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZaposlenici.Location = new System.Drawing.Point(3, 16);
            this.dgvZaposlenici.MultiSelect = false;
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.ReadOnly = true;
            this.dgvZaposlenici.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(769, 333);
            this.dgvZaposlenici.TabIndex = 0;
            this.dgvZaposlenici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaposlenici_CellDoubleClick);
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
            // Uloga
            // 
            this.Uloga.DataPropertyName = "Uloga";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
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
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ime ili prezime zaposlenika:";
            // 
            // btnDodajVoditelja
            // 
            this.btnDodajVoditelja.Location = new System.Drawing.Point(15, 444);
            this.btnDodajVoditelja.Name = "btnDodajVoditelja";
            this.btnDodajVoditelja.Size = new System.Drawing.Size(96, 23);
            this.btnDodajVoditelja.TabIndex = 4;
            this.btnDodajVoditelja.Text = "Dodaj voditelja";
            this.btnDodajVoditelja.UseVisualStyleBackColor = true;
            this.btnDodajVoditelja.Click += new System.EventHandler(this.btnDodajVoditelja_Click);
            // 
            // btnDodajTrenera
            // 
            this.btnDodajTrenera.Location = new System.Drawing.Point(117, 444);
            this.btnDodajTrenera.Name = "btnDodajTrenera";
            this.btnDodajTrenera.Size = new System.Drawing.Size(96, 23);
            this.btnDodajTrenera.TabIndex = 5;
            this.btnDodajTrenera.Text = "Dodaj trenera";
            this.btnDodajTrenera.UseVisualStyleBackColor = true;
            this.btnDodajTrenera.Click += new System.EventHandler(this.btnDodajTrenera_Click);
            // 
            // btnDodajAsistenta
            // 
            this.btnDodajAsistenta.Location = new System.Drawing.Point(219, 444);
            this.btnDodajAsistenta.Name = "btnDodajAsistenta";
            this.btnDodajAsistenta.Size = new System.Drawing.Size(96, 23);
            this.btnDodajAsistenta.TabIndex = 6;
            this.btnDodajAsistenta.Text = "Dodaj asistenta";
            this.btnDodajAsistenta.UseVisualStyleBackColor = true;
            this.btnDodajAsistenta.Click += new System.EventHandler(this.btnDodajAsistenta_Click);
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(281, 33);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(121, 21);
            this.cmbUloga.TabIndex = 7;
            this.cmbUloga.SelectedIndexChanged += new System.EventHandler(this.cmbUloga_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uloga:";
            // 
            // frmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.btnDodajAsistenta);
            this.Controls.Add(this.btnDodajTrenera);
            this.Controls.Add(this.btnDodajVoditelja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmZaposlenici_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajVoditelja;
        private System.Windows.Forms.Button btnDodajTrenera;
        private System.Windows.Forms.Button btnDodajAsistenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPasosa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label label2;
    }
}