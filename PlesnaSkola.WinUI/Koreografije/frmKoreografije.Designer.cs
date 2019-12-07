namespace PlesnaSkola.WinUI.Koreografije
{
    partial class frmKoreografije
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKoreografije = new System.Windows.Forms.DataGridView();
            this.btnDodajUplatu = new System.Windows.Forms.Button();
            this.KoreografijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivKoreografije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoreografije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv koreografije:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(242, 20);
            this.txtPretraga.TabIndex = 5;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(710, 34);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 4;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKoreografije);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Koreografije";
            // 
            // dgvKoreografije
            // 
            this.dgvKoreografije.AllowUserToAddRows = false;
            this.dgvKoreografije.AllowUserToDeleteRows = false;
            this.dgvKoreografije.AllowUserToResizeColumns = false;
            this.dgvKoreografije.AllowUserToResizeRows = false;
            this.dgvKoreografije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKoreografije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KoreografijaId,
            this.NazivKoreografije,
            this.Stil});
            this.dgvKoreografije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKoreografije.Location = new System.Drawing.Point(3, 16);
            this.dgvKoreografije.MultiSelect = false;
            this.dgvKoreografije.Name = "dgvKoreografije";
            this.dgvKoreografije.ReadOnly = true;
            this.dgvKoreografije.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKoreografije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKoreografije.Size = new System.Drawing.Size(769, 333);
            this.dgvKoreografije.TabIndex = 0;
            this.dgvKoreografije.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKoreografije_CellDoubleClick);
            // 
            // btnDodajUplatu
            // 
            this.btnDodajUplatu.Location = new System.Drawing.Point(15, 444);
            this.btnDodajUplatu.Name = "btnDodajUplatu";
            this.btnDodajUplatu.Size = new System.Drawing.Size(108, 23);
            this.btnDodajUplatu.TabIndex = 8;
            this.btnDodajUplatu.Text = "Dodaj koreografiju";
            this.btnDodajUplatu.UseVisualStyleBackColor = true;
            this.btnDodajUplatu.Click += new System.EventHandler(this.btnDodajKoreografiju_Click);
            // 
            // KoreografijaId
            // 
            this.KoreografijaId.DataPropertyName = "KoreografijaId";
            this.KoreografijaId.HeaderText = "KoreografijaId";
            this.KoreografijaId.Name = "KoreografijaId";
            this.KoreografijaId.ReadOnly = true;
            this.KoreografijaId.Visible = false;
            // 
            // NazivKoreografije
            // 
            this.NazivKoreografije.DataPropertyName = "NazivKoreografije";
            this.NazivKoreografije.HeaderText = "Naziv koreografije";
            this.NazivKoreografije.Name = "NazivKoreografije";
            this.NazivKoreografije.ReadOnly = true;
            this.NazivKoreografije.Width = 150;
            // 
            // Stil
            // 
            this.Stil.DataPropertyName = "Stil";
            this.Stil.HeaderText = "Stil";
            this.Stil.Name = "Stil";
            this.Stil.ReadOnly = true;
            // 
            // frmKoreografije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnDodajUplatu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmKoreografije";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Koreografije";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKoreografije_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoreografije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKoreografije;
        private System.Windows.Forms.Button btnDodajUplatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoreografijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivKoreografije;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stil;
    }
}