﻿namespace PlesnaSkola.WinUI.Clanovi
{
    partial class frmPlesaciDetails
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbAktivan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrojPasosa = new System.Windows.Forms.TextBox();
            this.gbxDodatniPodaci = new System.Windows.Forms.GroupBox();
            this.lblGrupaNePostoji = new System.Windows.Forms.Label();
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.btnDodajRoditelja = new System.Windows.Forms.Button();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.cmbRoditelj = new System.Windows.Forms.ComboBox();
            this.txtNazivSkole = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBrojOdjece = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBrojObuce = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.gbxDodatniPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(100, 229);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(149, 20);
            this.txtIme.TabIndex = 4;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(100, 264);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(149, 20);
            this.txtPrezime.TabIndex = 5;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(100, 334);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(149, 20);
            this.txtMail.TabIndex = 7;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mail";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(102, 25);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(149, 20);
            this.txtKorisnickoIme.TabIndex = 9;
            this.txtKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorisnickoIme_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Korisničko ime";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(102, 61);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(149, 20);
            this.txtLozinka.TabIndex = 11;
            this.txtLozinka.UseSystemPasswordChar = true;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinka_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lozinka";
            // 
            // txtPotvrdaLozinke
            // 
            this.txtPotvrdaLozinke.Location = new System.Drawing.Point(102, 96);
            this.txtPotvrdaLozinke.Name = "txtPotvrdaLozinke";
            this.txtPotvrdaLozinke.Size = new System.Drawing.Size(149, 20);
            this.txtPotvrdaLozinke.TabIndex = 13;
            this.txtPotvrdaLozinke.UseSystemPasswordChar = true;
            this.txtPotvrdaLozinke.Validating += new System.ComponentModel.CancelEventHandler(this.txtPotvrdaLozinke_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Potvrda lozinke";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Datum rođenja";
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(100, 299);
            this.dtpDatumRodjenja.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDatumRodjenja.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(149, 20);
            this.dtpDatumRodjenja.TabIndex = 15;
            this.dtpDatumRodjenja.ValueChanged += new System.EventHandler(this.dtpDatumRodjenja_ValueChanged);
            this.dtpDatumRodjenja.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDatumRodjenja_Validating);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(254, 424);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAktivan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Controls.Add(this.txtPotvrdaLozinke);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(294, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 172);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci za prijavu";
            // 
            // chbAktivan
            // 
            this.chbAktivan.AutoSize = true;
            this.chbAktivan.Checked = true;
            this.chbAktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAktivan.Location = new System.Drawing.Point(102, 135);
            this.chbAktivan.Name = "chbAktivan";
            this.chbAktivan.Size = new System.Drawing.Size(62, 17);
            this.chbAktivan.TabIndex = 20;
            this.chbAktivan.Text = "Aktivan";
            this.chbAktivan.UseVisualStyleBackColor = true;
            this.chbAktivan.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOdaberi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pbSlika);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBrojPasosa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIme);
            this.groupBox2.Controls.Add(this.dtpDatumRodjenja);
            this.groupBox2.Controls.Add(this.txtPrezime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 405);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lični podaci";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(99, 178);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 23;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Slika";
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSlika.InitialImage = global::PlesnaSkola.WinUI.Properties.Resources.default_pic;
            this.pbSlika.Location = new System.Drawing.Point(99, 22);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(150, 150);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 21;
            this.pbSlika.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Broj pasoša";
            // 
            // txtBrojPasosa
            // 
            this.txtBrojPasosa.Location = new System.Drawing.Point(100, 369);
            this.txtBrojPasosa.Name = "txtBrojPasosa";
            this.txtBrojPasosa.Size = new System.Drawing.Size(149, 20);
            this.txtBrojPasosa.TabIndex = 17;
            this.txtBrojPasosa.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojPasosa_Validating);
            // 
            // gbxDodatniPodaci
            // 
            this.gbxDodatniPodaci.Controls.Add(this.lblGrupaNePostoji);
            this.gbxDodatniPodaci.Controls.Add(this.btnDodajGrupu);
            this.gbxDodatniPodaci.Controls.Add(this.btnDodajRoditelja);
            this.gbxDodatniPodaci.Controls.Add(this.cmbGrupa);
            this.gbxDodatniPodaci.Controls.Add(this.cmbRoditelj);
            this.gbxDodatniPodaci.Controls.Add(this.txtNazivSkole);
            this.gbxDodatniPodaci.Controls.Add(this.label10);
            this.gbxDodatniPodaci.Controls.Add(this.txtBrojOdjece);
            this.gbxDodatniPodaci.Controls.Add(this.label11);
            this.gbxDodatniPodaci.Controls.Add(this.label14);
            this.gbxDodatniPodaci.Controls.Add(this.label12);
            this.gbxDodatniPodaci.Controls.Add(this.label13);
            this.gbxDodatniPodaci.Controls.Add(this.txtBrojObuce);
            this.gbxDodatniPodaci.Location = new System.Drawing.Point(294, 13);
            this.gbxDodatniPodaci.Name = "gbxDodatniPodaci";
            this.gbxDodatniPodaci.Size = new System.Drawing.Size(275, 227);
            this.gbxDodatniPodaci.TabIndex = 19;
            this.gbxDodatniPodaci.TabStop = false;
            this.gbxDodatniPodaci.Text = "Dodatni podaci";
            // 
            // lblGrupaNePostoji
            // 
            this.lblGrupaNePostoji.AutoSize = true;
            this.lblGrupaNePostoji.Location = new System.Drawing.Point(99, 200);
            this.lblGrupaNePostoji.Name = "lblGrupaNePostoji";
            this.lblGrupaNePostoji.Size = new System.Drawing.Size(155, 13);
            this.lblGrupaNePostoji.TabIndex = 33;
            this.lblGrupaNePostoji.Text = "Grupa za ovaj uzrast ne postoji.";
            this.lblGrupaNePostoji.Visible = false;
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Location = new System.Drawing.Point(229, 164);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(23, 23);
            this.btnDodajGrupu.TabIndex = 32;
            this.btnDodajGrupu.Text = "+";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            this.btnDodajGrupu.Click += new System.EventHandler(this.btnDodajGrupu_Click);
            // 
            // btnDodajRoditelja
            // 
            this.btnDodajRoditelja.Location = new System.Drawing.Point(229, 126);
            this.btnDodajRoditelja.Name = "btnDodajRoditelja";
            this.btnDodajRoditelja.Size = new System.Drawing.Size(23, 23);
            this.btnDodajRoditelja.TabIndex = 31;
            this.btnDodajRoditelja.Text = "+";
            this.btnDodajRoditelja.UseVisualStyleBackColor = true;
            this.btnDodajRoditelja.Click += new System.EventHandler(this.btnDodajRoditelja_Click);
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.cmbGrupa, 30);
            this.cmbGrupa.Location = new System.Drawing.Point(102, 165);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupa.TabIndex = 30;
            this.cmbGrupa.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGrupa_Validating);
            // 
            // cmbRoditelj
            // 
            this.cmbRoditelj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoditelj.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.cmbRoditelj, 30);
            this.cmbRoditelj.Location = new System.Drawing.Point(102, 127);
            this.cmbRoditelj.Name = "cmbRoditelj";
            this.cmbRoditelj.Size = new System.Drawing.Size(121, 21);
            this.cmbRoditelj.TabIndex = 29;
            this.cmbRoditelj.Validating += new System.ComponentModel.CancelEventHandler(this.cmbRoditelj_Validating);
            // 
            // txtNazivSkole
            // 
            this.txtNazivSkole.Location = new System.Drawing.Point(102, 91);
            this.txtNazivSkole.Name = "txtNazivSkole";
            this.txtNazivSkole.Size = new System.Drawing.Size(149, 20);
            this.txtNazivSkole.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Grupa";
            // 
            // txtBrojOdjece
            // 
            this.txtBrojOdjece.Location = new System.Drawing.Point(102, 21);
            this.txtBrojOdjece.Name = "txtBrojOdjece";
            this.txtBrojOdjece.Size = new System.Drawing.Size(149, 20);
            this.txtBrojOdjece.TabIndex = 20;
            this.txtBrojOdjece.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojOdjece_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Broj odjeće";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Roditelj";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Broj obuće";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Naziv škole";
            // 
            // txtBrojObuce
            // 
            this.txtBrojObuce.Location = new System.Drawing.Point(102, 56);
            this.txtBrojObuce.Name = "txtBrojObuce";
            this.txtBrojObuce.Size = new System.Drawing.Size(149, 20);
            this.txtBrojObuce.TabIndex = 21;
            this.txtBrojObuce.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojObuce_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images|*.jpg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.jpeg|All Files|*.*";
            // 
            // frmPlesaciDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 459);
            this.Controls.Add(this.gbxDodatniPodaci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlesaciDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji člana";
            this.Load += new System.EventHandler(this.frmPlesaciDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.gbxDodatniPodaci.ResumeLayout(false);
            this.gbxDodatniPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPotvrdaLozinke;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrojPasosa;
        private System.Windows.Forms.GroupBox gbxDodatniPodaci;
        private System.Windows.Forms.CheckBox chbAktivan;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.ComboBox cmbRoditelj;
        private System.Windows.Forms.TextBox txtNazivSkole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBrojOdjece;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBrojObuce;
        private System.Windows.Forms.Button btnDodajRoditelja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblGrupaNePostoji;
        private System.Windows.Forms.Button btnDodajGrupu;
    }
}