namespace PlesnaSkola.WinUI.Pravdanja
{
    partial class frmPravdanja
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
            this.btnDodajPravdanje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPravdanja = new System.Windows.Forms.DataGridView();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.PravdanjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Voditelj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZahtjeva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPravdanja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajPravdanje
            // 
            this.btnDodajPravdanje.Location = new System.Drawing.Point(15, 370);
            this.btnDodajPravdanje.Name = "btnDodajPravdanje";
            this.btnDodajPravdanje.Size = new System.Drawing.Size(108, 23);
            this.btnDodajPravdanje.TabIndex = 11;
            this.btnDodajPravdanje.Text = "Izdaj Pravdanje";
            this.btnDodajPravdanje.UseVisualStyleBackColor = true;
            this.btnDodajPravdanje.Click += new System.EventHandler(this.btnDodajPravdanje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPravdanja);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 310);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pravdanja";
            // 
            // dgvPravdanja
            // 
            this.dgvPravdanja.AllowUserToAddRows = false;
            this.dgvPravdanja.AllowUserToDeleteRows = false;
            this.dgvPravdanja.AllowUserToResizeColumns = false;
            this.dgvPravdanja.AllowUserToResizeRows = false;
            this.dgvPravdanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPravdanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PravdanjeId,
            this.DatumOd,
            this.DatumDo,
            this.Voditelj,
            this.Opis,
            this.DatumZahtjeva,
            this.DatumIzdavanja});
            this.dgvPravdanja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPravdanja.Location = new System.Drawing.Point(3, 16);
            this.dgvPravdanja.MultiSelect = false;
            this.dgvPravdanja.Name = "dgvPravdanja";
            this.dgvPravdanja.ReadOnly = true;
            this.dgvPravdanja.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPravdanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPravdanja.Size = new System.Drawing.Size(769, 291);
            this.dgvPravdanja.TabIndex = 0;
            this.dgvPravdanja.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPravdanja_CellDoubleClick);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(15, 17);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Filter:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(54, 13);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 13;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // PravdanjeId
            // 
            this.PravdanjeId.DataPropertyName = "PravdanjeId";
            this.PravdanjeId.HeaderText = "PravdanjeId";
            this.PravdanjeId.Name = "PravdanjeId";
            this.PravdanjeId.ReadOnly = true;
            this.PravdanjeId.Visible = false;
            // 
            // DatumOd
            // 
            this.DatumOd.DataPropertyName = "DatumOd";
            this.DatumOd.HeaderText = "Od";
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.ReadOnly = true;
            this.DatumOd.Width = 120;
            // 
            // DatumDo
            // 
            this.DatumDo.DataPropertyName = "DatumDo";
            this.DatumDo.HeaderText = "Do";
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.ReadOnly = true;
            // 
            // Voditelj
            // 
            this.Voditelj.DataPropertyName = "Voditelj";
            this.Voditelj.HeaderText = "Voditelj";
            this.Voditelj.Name = "Voditelj";
            this.Voditelj.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // DatumZahtjeva
            // 
            this.DatumZahtjeva.DataPropertyName = "DatumZahtjeva";
            this.DatumZahtjeva.HeaderText = "Datum zahtjeva";
            this.DatumZahtjeva.Name = "DatumZahtjeva";
            this.DatumZahtjeva.ReadOnly = true;
            this.DatumZahtjeva.Width = 120;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            this.DatumIzdavanja.Width = 120;
            // 
            // frmPravdanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnDodajPravdanje);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPravdanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pravdanja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPravdanja_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPravdanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajPravdanje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPravdanja;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn PravdanjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voditelj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZahtjeva;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
    }
}