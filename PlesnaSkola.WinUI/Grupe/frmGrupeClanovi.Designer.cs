namespace PlesnaSkola.WinUI.Grupe
{
    partial class frmGrupeClanovi
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
            this.lbClanovi = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClanovi
            // 
            this.lbClanovi.FormattingEnabled = true;
            this.lbClanovi.Location = new System.Drawing.Point(12, 12);
            this.lbClanovi.Name = "lbClanovi";
            this.lbClanovi.Size = new System.Drawing.Size(144, 251);
            this.lbClanovi.TabIndex = 1;
            this.lbClanovi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbClanovi_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGrupeClanovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbClanovi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrupeClanovi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plesači";
            this.Load += new System.EventHandler(this.frmGrupeClanovi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbClanovi;
        private System.Windows.Forms.Button button1;
    }
}