namespace PlesnaSkola.WinUI.Treninzi
{
    partial class frmTreningDetails
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTrener = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSatnicaOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSatnicaDo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbPrisustvo = new System.Windows.Forms.CheckedListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(114, 207);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSala);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpSatnicaDo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpSatnicaOd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpDatum);
            this.groupBox2.Controls.Add(this.cmbGrupa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbTrener);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 185);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o treningu";
            // 
            // cmbTrener
            // 
            this.cmbTrener.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrener.FormattingEnabled = true;
            this.cmbTrener.Location = new System.Drawing.Point(102, 54);
            this.cmbTrener.Name = "cmbTrener";
            this.cmbTrener.Size = new System.Drawing.Size(149, 21);
            this.cmbTrener.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Trener";
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(102, 22);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(149, 21);
            this.cmbGrupa.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Grupa";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(102, 88);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(149, 20);
            this.dtpDatum.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Datum";
            // 
            // dtpSatnicaOd
            // 
            this.dtpSatnicaOd.CustomFormat = "HH:mm";
            this.dtpSatnicaOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSatnicaOd.Location = new System.Drawing.Point(102, 118);
            this.dtpSatnicaOd.Name = "dtpSatnicaOd";
            this.dtpSatnicaOd.ShowUpDown = true;
            this.dtpSatnicaOd.Size = new System.Drawing.Size(65, 20);
            this.dtpSatnicaOd.TabIndex = 34;
            this.dtpSatnicaOd.Value = new System.DateTime(2019, 12, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Satnica";
            // 
            // dtpSatnicaDo
            // 
            this.dtpSatnicaDo.CustomFormat = "HH:mm";
            this.dtpSatnicaDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSatnicaDo.Location = new System.Drawing.Point(186, 118);
            this.dtpSatnicaDo.Name = "dtpSatnicaDo";
            this.dtpSatnicaDo.ShowUpDown = true;
            this.dtpSatnicaDo.Size = new System.Drawing.Size(65, 20);
            this.dtpSatnicaDo.TabIndex = 36;
            this.dtpSatnicaDo.Value = new System.DateTime(2019, 12, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = " - ";
            // 
            // cmbSala
            // 
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(102, 150);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(149, 21);
            this.cmbSala.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sala";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbPrisustvo);
            this.groupBox1.Location = new System.Drawing.Point(292, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 185);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prisustvo";
            // 
            // clbPrisustvo
            // 
            this.clbPrisustvo.FormattingEnabled = true;
            this.clbPrisustvo.Location = new System.Drawing.Point(6, 19);
            this.clbPrisustvo.Name = "clbPrisustvo";
            this.clbPrisustvo.Size = new System.Drawing.Size(135, 154);
            this.clbPrisustvo.TabIndex = 0;
            // 
            // frmTreningDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 244);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTreningDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji treninga";
            this.Load += new System.EventHandler(this.frmTreningDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTrener;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSatnicaDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSatnicaOd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbPrisustvo;
    }
}