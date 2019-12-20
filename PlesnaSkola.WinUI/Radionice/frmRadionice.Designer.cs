namespace PlesnaSkola.WinUI.Radionice
{
    partial class frmRadionice
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
            this.btnDodajRadionicu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRadionice = new System.Windows.Forms.DataGridView();
            this.RadionicaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivRadionice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeOdržavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadionice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajRadionicu
            // 
            this.btnDodajRadionicu.Location = new System.Drawing.Point(15, 444);
            this.btnDodajRadionicu.Name = "btnDodajRadionicu";
            this.btnDodajRadionicu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajRadionicu.TabIndex = 11;
            this.btnDodajRadionicu.Text = "Dodaj radionicu";
            this.btnDodajRadionicu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRadionice);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treninzi";
            // 
            // dgvRadionice
            // 
            this.dgvRadionice.AllowUserToAddRows = false;
            this.dgvRadionice.AllowUserToDeleteRows = false;
            this.dgvRadionice.AllowUserToResizeColumns = false;
            this.dgvRadionice.AllowUserToResizeRows = false;
            this.dgvRadionice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadionice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RadionicaId,
            this.NazivRadionice,
            this.MjestoOdrzavanja,
            this.DatumOdrzavanja,
            this.VrijemeOdržavanja,
            this.Opis,
            this.Asistent});
            this.dgvRadionice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRadionice.Location = new System.Drawing.Point(3, 16);
            this.dgvRadionice.MultiSelect = false;
            this.dgvRadionice.Name = "dgvRadionice";
            this.dgvRadionice.ReadOnly = true;
            this.dgvRadionice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRadionice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadionice.Size = new System.Drawing.Size(769, 333);
            this.dgvRadionice.TabIndex = 0;
            // 
            // RadionicaId
            // 
            this.RadionicaId.DataPropertyName = "RadionicaId";
            this.RadionicaId.HeaderText = "RadionicaId";
            this.RadionicaId.Name = "RadionicaId";
            this.RadionicaId.ReadOnly = true;
            this.RadionicaId.Visible = false;
            // 
            // NazivRadionice
            // 
            this.NazivRadionice.DataPropertyName = "NazivRadionice";
            this.NazivRadionice.HeaderText = "Naziv radionice";
            this.NazivRadionice.Name = "NazivRadionice";
            this.NazivRadionice.ReadOnly = true;
            this.NazivRadionice.Width = 150;
            // 
            // MjestoOdrzavanja
            // 
            this.MjestoOdrzavanja.DataPropertyName = "MjestoOdrzavanja";
            this.MjestoOdrzavanja.HeaderText = "Mjesto održavanja";
            this.MjestoOdrzavanja.Name = "MjestoOdrzavanja";
            this.MjestoOdrzavanja.ReadOnly = true;
            this.MjestoOdrzavanja.Width = 120;
            // 
            // DatumOdrzavanja
            // 
            this.DatumOdrzavanja.DataPropertyName = "DatumOdrzavanja";
            this.DatumOdrzavanja.HeaderText = "Datum održavanja";
            this.DatumOdrzavanja.Name = "DatumOdrzavanja";
            this.DatumOdrzavanja.ReadOnly = true;
            this.DatumOdrzavanja.Width = 120;
            // 
            // VrijemeOdržavanja
            // 
            this.VrijemeOdržavanja.DataPropertyName = "VrijemeOdržavanja";
            this.VrijemeOdržavanja.HeaderText = "Vrijeme održavanja";
            this.VrijemeOdržavanja.Name = "VrijemeOdržavanja";
            this.VrijemeOdržavanja.ReadOnly = true;
            this.VrijemeOdržavanja.Width = 120;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // Asistent
            // 
            this.Asistent.DataPropertyName = "Asistent";
            this.Asistent.HeaderText = "Asistent";
            this.Asistent.Name = "Asistent";
            this.Asistent.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv radionice:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(242, 20);
            this.txtPretraga.TabIndex = 14;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(710, 34);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 15;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            // 
            // frmRadionice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajRadionicu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRadionice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Radionice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadionice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajRadionicu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRadionice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadionicaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivRadionice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeOdržavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asistent;
    }
}