namespace PlesnaSkola.WinUI.Radionice
{
    partial class frmRadionicaDetails
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNazivRadionice = new System.Windows.Forms.TextBox();
            this.lblBrojUcesnika = new System.Windows.Forms.Label();
            this.txtBrojUcesnika = new System.Windows.Forms.TextBox();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.txtMjestoOdrzavanja = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbAsistent = new System.Windows.Forms.ComboBox();
            this.lblAsistent = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(126, 332);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNazivRadionice);
            this.groupBox2.Controls.Add(this.lblBrojUcesnika);
            this.groupBox2.Controls.Add(this.txtBrojUcesnika);
            this.groupBox2.Controls.Add(this.lblMjesto);
            this.groupBox2.Controls.Add(this.txtMjestoOdrzavanja);
            this.groupBox2.Controls.Add(this.lblOpis);
            this.groupBox2.Controls.Add(this.txtOpis);
            this.groupBox2.Controls.Add(this.lblVrijeme);
            this.groupBox2.Controls.Add(this.dtpVrijeme);
            this.groupBox2.Controls.Add(this.lblDatum);
            this.groupBox2.Controls.Add(this.dtpDatum);
            this.groupBox2.Controls.Add(this.cmbAsistent);
            this.groupBox2.Controls.Add(this.lblAsistent);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 315);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o radionici";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Naziv radionice";
            // 
            // txtNazivRadionice
            // 
            this.txtNazivRadionice.Location = new System.Drawing.Point(124, 28);
            this.txtNazivRadionice.Name = "txtNazivRadionice";
            this.txtNazivRadionice.Size = new System.Drawing.Size(149, 20);
            this.txtNazivRadionice.TabIndex = 42;
            this.txtNazivRadionice.Validating += new System.ComponentModel.CancelEventHandler(this.txtNazivRadionice_Validating);
            // 
            // lblBrojUcesnika
            // 
            this.lblBrojUcesnika.AutoSize = true;
            this.lblBrojUcesnika.Location = new System.Drawing.Point(41, 99);
            this.lblBrojUcesnika.Name = "lblBrojUcesnika";
            this.lblBrojUcesnika.Size = new System.Drawing.Size(71, 13);
            this.lblBrojUcesnika.TabIndex = 41;
            this.lblBrojUcesnika.Text = "Broj učesnika";
            // 
            // txtBrojUcesnika
            // 
            this.txtBrojUcesnika.Location = new System.Drawing.Point(124, 96);
            this.txtBrojUcesnika.Name = "txtBrojUcesnika";
            this.txtBrojUcesnika.Size = new System.Drawing.Size(65, 20);
            this.txtBrojUcesnika.TabIndex = 40;
            this.txtBrojUcesnika.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojUcesnika_Validating);
            // 
            // lblMjesto
            // 
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Location = new System.Drawing.Point(20, 65);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(93, 13);
            this.lblMjesto.TabIndex = 39;
            this.lblMjesto.Text = "Mjesto održavanja";
            // 
            // txtMjestoOdrzavanja
            // 
            this.txtMjestoOdrzavanja.Location = new System.Drawing.Point(124, 62);
            this.txtMjestoOdrzavanja.Name = "txtMjestoOdrzavanja";
            this.txtMjestoOdrzavanja.Size = new System.Drawing.Size(149, 20);
            this.txtMjestoOdrzavanja.TabIndex = 38;
            this.txtMjestoOdrzavanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtMjestoOdrzavanja_Validating);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Location = new System.Drawing.Point(80, 237);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(28, 13);
            this.lblOpis.TabIndex = 37;
            this.lblOpis.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(124, 238);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(149, 59);
            this.txtOpis.TabIndex = 36;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.AutoSize = true;
            this.lblVrijeme.Location = new System.Drawing.Point(15, 167);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(96, 13);
            this.lblVrijeme.TabIndex = 35;
            this.lblVrijeme.Text = "Vrijeme održavanja";
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.CustomFormat = "HH:mm";
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVrijeme.Location = new System.Drawing.Point(124, 164);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.ShowUpDown = true;
            this.dtpVrijeme.Size = new System.Drawing.Size(65, 20);
            this.dtpVrijeme.TabIndex = 34;
            this.dtpVrijeme.Value = new System.DateTime(2019, 12, 7, 0, 0, 0, 0);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(19, 132);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(93, 13);
            this.lblDatum.TabIndex = 33;
            this.lblDatum.Text = "Datum održavanja";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(124, 130);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(149, 20);
            this.dtpDatum.TabIndex = 32;
            // 
            // cmbAsistent
            // 
            this.cmbAsistent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsistent.FormattingEnabled = true;
            this.cmbAsistent.Location = new System.Drawing.Point(124, 199);
            this.cmbAsistent.Name = "cmbAsistent";
            this.cmbAsistent.Size = new System.Drawing.Size(149, 21);
            this.cmbAsistent.TabIndex = 29;
            this.cmbAsistent.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAsistent_Validating);
            // 
            // lblAsistent
            // 
            this.lblAsistent.AutoSize = true;
            this.lblAsistent.Location = new System.Drawing.Point(66, 201);
            this.lblAsistent.Name = "lblAsistent";
            this.lblAsistent.Size = new System.Drawing.Size(44, 13);
            this.lblAsistent.TabIndex = 22;
            this.lblAsistent.Text = "Asistent";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRadionicaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRadionicaDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji radionice";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAsistent;
        private System.Windows.Forms.Label lblAsistent;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.TextBox txtMjestoOdrzavanja;
        private System.Windows.Forms.Label lblBrojUcesnika;
        private System.Windows.Forms.TextBox txtBrojUcesnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNazivRadionice;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}