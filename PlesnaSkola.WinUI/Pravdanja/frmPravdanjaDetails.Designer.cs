namespace PlesnaSkola.WinUI.Pravdanja
{
    partial class frmPravdanjeDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trvPlesaci = new System.Windows.Forms.TreeView();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(421, 192);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 16;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trvPlesaci);
            this.groupBox1.Location = new System.Drawing.Point(292, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 174);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plesači";
            // 
            // trvPlesaci
            // 
            this.trvPlesaci.CheckBoxes = true;
            this.trvPlesaci.Location = new System.Drawing.Point(6, 19);
            this.trvPlesaci.Name = "trvPlesaci";
            this.trvPlesaci.Size = new System.Drawing.Size(192, 146);
            this.trvPlesaci.TabIndex = 41;
            this.trvPlesaci.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.trvPlesaci_AfterCheck);
            // 
            // dtpDo
            // 
            this.dtpDo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDo.Location = new System.Drawing.Point(102, 59);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(149, 20);
            this.dtpDo.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Do";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOpis);
            this.groupBox2.Controls.Add(this.dtpOd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpDo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 175);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o pravdanju";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(102, 97);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(149, 69);
            this.txtOpis.TabIndex = 35;
            // 
            // dtpOd
            // 
            this.dtpOd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOd.Location = new System.Drawing.Point(102, 22);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(149, 20);
            this.dtpOd.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Opis";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Od";
            // 
            // frmPravdanjeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPravdanjeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji pravdanja";
            this.Load += new System.EventHandler(this.frmPravdanjeDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView trvPlesaci;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOpis;
    }
}