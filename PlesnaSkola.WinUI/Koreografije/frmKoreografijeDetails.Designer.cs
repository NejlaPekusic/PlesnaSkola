namespace PlesnaSkola.WinUI.Koreografije
{
    partial class frmKoreografijeDetails
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAsistenti = new System.Windows.Forms.ComboBox();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.cmbStil = new System.Windows.Forms.ComboBox();
            this.gbxDodatniPodaci = new System.Windows.Forms.GroupBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.dtpTrajanje = new System.Windows.Forms.DateTimePicker();
            this.txtNazivPjesme = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.gbxDodatniPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stil";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(102, 21);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(149, 20);
            this.txtNaziv.TabIndex = 4;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asistent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Grupa";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(484, 155);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbAsistenti);
            this.groupBox2.Controls.Add(this.cmbGrupa);
            this.groupBox2.Controls.Add(this.cmbStil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNaziv);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 166);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o koreografiji";
            // 
            // cmbAsistenti
            // 
            this.cmbAsistenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistenti.FormattingEnabled = true;
            this.cmbAsistenti.Location = new System.Drawing.Point(102, 126);
            this.cmbAsistenti.Name = "cmbAsistenti";
            this.cmbAsistenti.Size = new System.Drawing.Size(149, 21);
            this.cmbAsistenti.TabIndex = 33;
            this.cmbAsistenti.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAsistenti_Validating);
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(102, 90);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(149, 21);
            this.cmbGrupa.TabIndex = 32;
            this.cmbGrupa.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrupa_Validating);
            // 
            // cmbStil
            // 
            this.cmbStil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStil.FormattingEnabled = true;
            this.cmbStil.Location = new System.Drawing.Point(102, 55);
            this.cmbStil.Name = "cmbStil";
            this.cmbStil.Size = new System.Drawing.Size(149, 21);
            this.cmbStil.TabIndex = 31;
            this.cmbStil.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStil_Validating);
            // 
            // gbxDodatniPodaci
            // 
            this.gbxDodatniPodaci.Controls.Add(this.lblFileName);
            this.gbxDodatniPodaci.Controls.Add(this.btnOdaberi);
            this.gbxDodatniPodaci.Controls.Add(this.dtpTrajanje);
            this.gbxDodatniPodaci.Controls.Add(this.txtNazivPjesme);
            this.gbxDodatniPodaci.Controls.Add(this.label11);
            this.gbxDodatniPodaci.Controls.Add(this.label12);
            this.gbxDodatniPodaci.Controls.Add(this.label13);
            this.gbxDodatniPodaci.Location = new System.Drawing.Point(294, 13);
            this.gbxDodatniPodaci.Name = "gbxDodatniPodaci";
            this.gbxDodatniPodaci.Size = new System.Drawing.Size(265, 121);
            this.gbxDodatniPodaci.TabIndex = 19;
            this.gbxDodatniPodaci.TabStop = false;
            this.gbxDodatniPodaci.Text = "Podaci o muzici";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(184, 93);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 31;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(102, 87);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 30;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // dtpTrajanje
            // 
            this.dtpTrajanje.CustomFormat = "mm:ss";
            this.dtpTrajanje.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTrajanje.Location = new System.Drawing.Point(102, 54);
            this.dtpTrajanje.Name = "dtpTrajanje";
            this.dtpTrajanje.ShowUpDown = true;
            this.dtpTrajanje.Size = new System.Drawing.Size(149, 20);
            this.dtpTrajanje.TabIndex = 29;
            this.dtpTrajanje.Value = new System.DateTime(2019, 12, 7, 0, 0, 0, 0);
            //this.dtpTrajanje.Validating += new System.ComponentModel.CancelEventHandler(this.dtpTrajanje_Validating);
            // 
            // txtNazivPjesme
            // 
            this.txtNazivPjesme.Location = new System.Drawing.Point(102, 21);
            this.txtNazivPjesme.Name = "txtNazivPjesme";
            this.txtNazivPjesme.Size = new System.Drawing.Size(149, 20);
            this.txtNazivPjesme.TabIndex = 20;
            this.txtNazivPjesme.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivPjesme_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Naziv pjesme";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Trajanje";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Pjesma";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKoreografijeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 191);
            this.Controls.Add(this.gbxDodatniPodaci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKoreografijeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji koreografije";
            this.Load += new System.EventHandler(this.frmKoreografijeDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxDodatniPodaci.ResumeLayout(false);
            this.gbxDodatniPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxDodatniPodaci;
        private System.Windows.Forms.TextBox txtNazivPjesme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbStil;
        private System.Windows.Forms.ComboBox cmbAsistenti;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.DateTimePicker dtpTrajanje;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}