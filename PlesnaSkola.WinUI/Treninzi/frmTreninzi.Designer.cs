namespace PlesnaSkola.WinUI.Treninzi
{
    partial class frmTreninzi
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
            this.btnDodajTrening = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTreninzi = new System.Windows.Forms.DataGridView();
            this.TreningId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGrupe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Location = new System.Drawing.Point(15, 444);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTrening.TabIndex = 11;
            this.btnDodajTrening.Text = "Dodaj trening";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            this.btnDodajTrening.Click += new System.EventHandler(this.btnDodajTrening_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTreninzi);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treninzi";
            // 
            // dgvTreninzi
            // 
            this.dgvTreninzi.AllowUserToAddRows = false;
            this.dgvTreninzi.AllowUserToDeleteRows = false;
            this.dgvTreninzi.AllowUserToResizeColumns = false;
            this.dgvTreninzi.AllowUserToResizeRows = false;
            this.dgvTreninzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreninzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TreningId,
            this.Grupa,
            this.Trener,
            this.DatumOdrzavanja,
            this.Satnica,
            this.Sala});
            this.dgvTreninzi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreninzi.Location = new System.Drawing.Point(3, 16);
            this.dgvTreninzi.MultiSelect = false;
            this.dgvTreninzi.Name = "dgvTreninzi";
            this.dgvTreninzi.ReadOnly = true;
            this.dgvTreninzi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreninzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreninzi.Size = new System.Drawing.Size(769, 333);
            this.dgvTreninzi.TabIndex = 0;
            this.dgvTreninzi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreninzi_CellDoubleClick);
            // 
            // TreningId
            // 
            this.TreningId.DataPropertyName = "TreningId";
            this.TreningId.HeaderText = "TreningId";
            this.TreningId.Name = "TreningId";
            this.TreningId.ReadOnly = true;
            this.TreningId.Visible = false;
            // 
            // Grupa
            // 
            this.Grupa.DataPropertyName = "Grupa";
            this.Grupa.HeaderText = "Grupa";
            this.Grupa.Name = "Grupa";
            this.Grupa.ReadOnly = true;
            this.Grupa.Width = 150;
            // 
            // Trener
            // 
            this.Trener.DataPropertyName = "Trener";
            this.Trener.HeaderText = "Trener";
            this.Trener.Name = "Trener";
            this.Trener.ReadOnly = true;
            // 
            // DatumOdrzavanja
            // 
            this.DatumOdrzavanja.DataPropertyName = "DatumOdrzavanja";
            this.DatumOdrzavanja.HeaderText = "Datum održavanja";
            this.DatumOdrzavanja.Name = "DatumOdrzavanja";
            this.DatumOdrzavanja.ReadOnly = true;
            this.DatumOdrzavanja.Width = 120;
            // 
            // Satnica
            // 
            this.Satnica.DataPropertyName = "Satnica";
            this.Satnica.HeaderText = "Satnica";
            this.Satnica.Name = "Satnica";
            this.Satnica.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.DataPropertyName = "Sala";
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // cmbGrupe
            // 
            this.cmbGrupe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupe.FormattingEnabled = true;
            this.cmbGrupe.Location = new System.Drawing.Point(15, 34);
            this.cmbGrupe.Name = "cmbGrupe";
            this.cmbGrupe.Size = new System.Drawing.Size(134, 21);
            this.cmbGrupe.TabIndex = 12;
            this.cmbGrupe.SelectedIndexChanged += new System.EventHandler(this.cmbGrupe_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grupa:";
            // 
            // frmTreninzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGrupe);
            this.Controls.Add(this.btnDodajTrening);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTreninzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Treninzi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTreninzi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreninzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajTrening;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTreninzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TreningId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trener;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private System.Windows.Forms.ComboBox cmbGrupe;
        private System.Windows.Forms.Label label1;
       
    }
}