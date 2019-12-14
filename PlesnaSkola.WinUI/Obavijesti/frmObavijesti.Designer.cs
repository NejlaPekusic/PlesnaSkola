namespace PlesnaSkola.WinUI.Obavijesti
{
    partial class frmObavijesti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.btnDodajUplatu = new System.Windows.Forms.Button();
            this.ObavijestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naslov obavijesti:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(242, 20);
            this.txtPretraga.TabIndex = 5;
            this.txtPretraga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPretraga_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvObavijesti);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obavijesti";
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.AllowUserToResizeColumns = false;
            this.dgvObavijesti.AllowUserToResizeRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavijestId,
            this.Naslov,
            this.Korisnik});
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObavijesti.Location = new System.Drawing.Point(3, 16);
            this.dgvObavijesti.MultiSelect = false;
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObavijesti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijesti.Size = new System.Drawing.Size(769, 333);
            this.dgvObavijesti.TabIndex = 0;
            this.dgvObavijesti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObavijesti_CellDoubleClick);
            // 
            // btnDodajUplatu
            // 
            this.btnDodajUplatu.Location = new System.Drawing.Point(15, 444);
            this.btnDodajUplatu.Name = "btnDodajUplatu";
            this.btnDodajUplatu.Size = new System.Drawing.Size(108, 23);
            this.btnDodajUplatu.TabIndex = 8;
            this.btnDodajUplatu.Text = "Dodaj obavijest";
            this.btnDodajUplatu.UseVisualStyleBackColor = true;
            this.btnDodajUplatu.Click += new System.EventHandler(this.btnDodajObavijest_Click);
            // 
            // ObavijestId
            // 
            this.ObavijestId.DataPropertyName = "ObavijestId";
            this.ObavijestId.HeaderText = "ObavijestId";
            this.ObavijestId.Name = "ObavijestId";
            this.ObavijestId.ReadOnly = true;
            this.ObavijestId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov obavijesti";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            this.Naslov.Width = 150;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Autor";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // frmObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnDodajUplatu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obavijesti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmObavijesti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Button btnDodajUplatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
    }
}