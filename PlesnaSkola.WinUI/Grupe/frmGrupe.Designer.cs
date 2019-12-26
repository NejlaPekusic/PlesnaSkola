namespace PlesnaSkola.WinUI.Grupe
{
    partial class frmGrupe
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
            this.btnDodajGrupu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvGrupe = new System.Windows.Forms.DataGridView();
            this.GrupaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivGrupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plesaci = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BrojClanova = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzrast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv grupe:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(16, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(242, 20);
            this.txtPretraga.TabIndex = 8;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(710, 34);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 7;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // btnDodajGrupu
            // 
            this.btnDodajGrupu.Location = new System.Drawing.Point(15, 444);
            this.btnDodajGrupu.Name = "btnDodajGrupu";
            this.btnDodajGrupu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajGrupu.TabIndex = 11;
            this.btnDodajGrupu.Text = "Dodaj grupu";
            this.btnDodajGrupu.UseVisualStyleBackColor = true;
            this.btnDodajGrupu.Click += new System.EventHandler(this.btnDodajGrupu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGrupe);
            this.groupBox1.Location = new System.Drawing.Point(13, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 352);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupe";
            // 
            // dgvGrupe
            // 
            this.dgvGrupe.AllowUserToAddRows = false;
            this.dgvGrupe.AllowUserToDeleteRows = false;
            this.dgvGrupe.AllowUserToResizeColumns = false;
            this.dgvGrupe.AllowUserToResizeRows = false;
            this.dgvGrupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrupaId,
            this.NazivGrupe,
            this.Trener,
            this.Plesaci,
            this.BrojClanova,
            this.Uzrast});
            this.dgvGrupe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrupe.Location = new System.Drawing.Point(3, 16);
            this.dgvGrupe.MultiSelect = false;
            this.dgvGrupe.Name = "dgvGrupe";
            this.dgvGrupe.ReadOnly = true;
            this.dgvGrupe.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrupe.Size = new System.Drawing.Size(769, 333);
            this.dgvGrupe.TabIndex = 0;
            this.dgvGrupe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupe_CellContentClick);
            this.dgvGrupe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupe_CellDoubleClick);
            // 
            // GrupaId
            // 
            this.GrupaId.DataPropertyName = "GrupaId";
            this.GrupaId.HeaderText = "GrupaId";
            this.GrupaId.Name = "GrupaId";
            this.GrupaId.ReadOnly = true;
            this.GrupaId.Visible = false;
            // 
            // NazivGrupe
            // 
            this.NazivGrupe.DataPropertyName = "NazivGrupe";
            this.NazivGrupe.HeaderText = "Naziv grupe";
            this.NazivGrupe.Name = "NazivGrupe";
            this.NazivGrupe.ReadOnly = true;
            this.NazivGrupe.Width = 150;
            // 
            // Trener
            // 
            this.Trener.DataPropertyName = "Trener";
            this.Trener.HeaderText = "Trener";
            this.Trener.Name = "Trener";
            this.Trener.ReadOnly = true;
            // 
            // Plesaci
            // 
            this.Plesaci.DataPropertyName = "Plesaci";
            this.Plesaci.HeaderText = "Plesači";
            this.Plesaci.Name = "Plesaci";
            this.Plesaci.ReadOnly = true;
            this.Plesaci.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Plesaci.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Plesaci.Text = "Prikaži";
            this.Plesaci.UseColumnTextForButtonValue = true;
            // 
            // BrojClanova
            // 
            this.BrojClanova.DataPropertyName = "BrojClanova";
            this.BrojClanova.HeaderText = "Broj članova";
            this.BrojClanova.Name = "BrojClanova";
            this.BrojClanova.ReadOnly = true;
            // 
            // Uzrast
            // 
            this.Uzrast.DataPropertyName = "Uzrast";
            this.Uzrast.HeaderText = "Uzrast";
            this.Uzrast.Name = "Uzrast";
            this.Uzrast.ReadOnly = true;
            // 
            // frmGrupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnDodajGrupu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmGrupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grupe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGrupe_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Button btnDodajGrupu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGrupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivGrupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trener;
        private System.Windows.Forms.DataGridViewButtonColumn Plesaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojClanova;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzrast;
    }
}