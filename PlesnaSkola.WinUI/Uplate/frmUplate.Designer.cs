namespace PlesnaSkola.WinUI.Uplate
{
    partial class frmUplate
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
            this.dgvUplate = new System.Windows.Forms.DataGridView();
            this.UplataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaUplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodajUplatu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVrsteUplata = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ime ili prezime člana:";
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
            this.groupBox1.Controls.Add(this.dgvUplate);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uplate";
            // 
            // dgvUplate
            // 
            this.dgvUplate.AllowUserToAddRows = false;
            this.dgvUplate.AllowUserToDeleteRows = false;
            this.dgvUplate.AllowUserToResizeColumns = false;
            this.dgvUplate.AllowUserToResizeRows = false;
            this.dgvUplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UplataId,
            this.ImePrezime,
            this.IznosUplate,
            this.DatumUplate,
            this.VrstaUplate});
            this.dgvUplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUplate.Location = new System.Drawing.Point(3, 16);
            this.dgvUplate.MultiSelect = false;
            this.dgvUplate.Name = "dgvUplate";
            this.dgvUplate.ReadOnly = true;
            this.dgvUplate.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUplate.Size = new System.Drawing.Size(769, 333);
            this.dgvUplate.TabIndex = 0;
            this.dgvUplate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUplate_CellDoubleClick);
            // 
            // UplataId
            // 
            this.UplataId.DataPropertyName = "UplataId";
            this.UplataId.HeaderText = "UplataId";
            this.UplataId.Name = "UplataId";
            this.UplataId.ReadOnly = true;
            this.UplataId.Visible = false;
            // 
            // ImePrezime
            // 
            this.ImePrezime.DataPropertyName = "Plesac";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 150;
            // 
            // IznosUplate
            // 
            this.IznosUplate.DataPropertyName = "IznosUplateText";
            this.IznosUplate.HeaderText = "Iznos uplate";
            this.IznosUplate.Name = "IznosUplate";
            this.IznosUplate.ReadOnly = true;
            // 
            // DatumUplate
            // 
            this.DatumUplate.DataPropertyName = "DatumUplate";
            this.DatumUplate.HeaderText = "Datum uplate";
            this.DatumUplate.Name = "DatumUplate";
            this.DatumUplate.ReadOnly = true;
            // 
            // VrstaUplate
            // 
            this.VrstaUplate.DataPropertyName = "VrstaUplateText";
            this.VrstaUplate.HeaderText = "Vrsta uplate";
            this.VrstaUplate.Name = "VrstaUplate";
            this.VrstaUplate.ReadOnly = true;
            // 
            // btnDodajUplatu
            // 
            this.btnDodajUplatu.Location = new System.Drawing.Point(15, 444);
            this.btnDodajUplatu.Name = "btnDodajUplatu";
            this.btnDodajUplatu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajUplatu.TabIndex = 8;
            this.btnDodajUplatu.Text = "Dodaj uplatu";
            this.btnDodajUplatu.UseVisualStyleBackColor = true;
            this.btnDodajUplatu.Click += new System.EventHandler(this.btnDodajUplatu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Vrsta uplate:";
            // 
            // cmbVrsteUplata
            // 
            this.cmbVrsteUplata.FormattingEnabled = true;
            this.cmbVrsteUplata.Location = new System.Drawing.Point(281, 33);
            this.cmbVrsteUplata.Name = "cmbVrsteUplata";
            this.cmbVrsteUplata.Size = new System.Drawing.Size(121, 21);
            this.cmbVrsteUplata.TabIndex = 9;
            this.cmbVrsteUplata.SelectedIndexChanged += new System.EventHandler(this.cmbVrsteUplata_SelectedIndexChanged);
            // 
            // frmUplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVrsteUplata);
            this.Controls.Add(this.btnDodajUplatu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Name = "frmUplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uplate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUplate_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUplate;
        private System.Windows.Forms.Button btnDodajUplatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UplataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaUplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVrsteUplata;
    }
}