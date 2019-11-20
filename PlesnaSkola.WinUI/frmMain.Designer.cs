namespace PlesnaSkola.WinUI
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiČlanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPlesačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRoditeljaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članoviToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // članoviToolStripMenuItem
            // 
            this.članoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiČlanoveToolStripMenuItem,
            this.dodajPlesačaToolStripMenuItem,
            this.dodajRoditeljaToolStripMenuItem});
            this.članoviToolStripMenuItem.Name = "članoviToolStripMenuItem";
            this.članoviToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.članoviToolStripMenuItem.Text = "Članovi";
            // 
            // prikažiČlanoveToolStripMenuItem
            // 
            this.prikažiČlanoveToolStripMenuItem.Name = "prikažiČlanoveToolStripMenuItem";
            this.prikažiČlanoveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikažiČlanoveToolStripMenuItem.Text = "Prikaži članove";
            this.prikažiČlanoveToolStripMenuItem.Click += new System.EventHandler(this.prikažiČlanoveToolStripMenuItem_Click);
            // 
            // dodajPlesačaToolStripMenuItem
            // 
            this.dodajPlesačaToolStripMenuItem.Name = "dodajPlesačaToolStripMenuItem";
            this.dodajPlesačaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajPlesačaToolStripMenuItem.Text = "Dodaj plesača";
            this.dodajPlesačaToolStripMenuItem.Click += new System.EventHandler(this.dodajPlesačaToolStripMenuItem_Click);
            // 
            // dodajRoditeljaToolStripMenuItem
            // 
            this.dodajRoditeljaToolStripMenuItem.Name = "dodajRoditeljaToolStripMenuItem";
            this.dodajRoditeljaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajRoditeljaToolStripMenuItem.Text = "Dodaj roditelja";
            this.dodajRoditeljaToolStripMenuItem.Click += new System.EventHandler(this.dodajRoditeljaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Plesna škola";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem članoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiČlanoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPlesačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRoditeljaToolStripMenuItem;
    }
}