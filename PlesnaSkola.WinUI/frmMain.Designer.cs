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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.članoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiČlanoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPlesačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRoditeljaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiZaposlenikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voditeljToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiUplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUplatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.koreografijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiKoregrafijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKoreografiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiGrupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajGrupuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treninziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiTreningeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTreningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiObavijestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajObavijestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pravdanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiPravdanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPravdanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiRadioniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRadionicuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.članoviToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.uplateToolStripMenuItem,
            this.koreografijaToolStripMenuItem,
            this.grupeToolStripMenuItem,
            this.treninziToolStripMenuItem,
            this.obavijestiToolStripMenuItem,
            this.pravdanjaToolStripMenuItem,
            this.radioniceToolStripMenuItem,
            this.logoutToolStripMenuItem});
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
            this.prikažiČlanoveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prikažiČlanoveToolStripMenuItem.Text = "Prikaži članove";
            this.prikažiČlanoveToolStripMenuItem.Click += new System.EventHandler(this.prikažiČlanoveToolStripMenuItem_Click);
            // 
            // dodajPlesačaToolStripMenuItem
            // 
            this.dodajPlesačaToolStripMenuItem.Name = "dodajPlesačaToolStripMenuItem";
            this.dodajPlesačaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajPlesačaToolStripMenuItem.Text = "Dodaj plesača";
            this.dodajPlesačaToolStripMenuItem.Click += new System.EventHandler(this.dodajPlesačaToolStripMenuItem_Click);
            // 
            // dodajRoditeljaToolStripMenuItem
            // 
            this.dodajRoditeljaToolStripMenuItem.Name = "dodajRoditeljaToolStripMenuItem";
            this.dodajRoditeljaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajRoditeljaToolStripMenuItem.Text = "Dodaj roditelja";
            this.dodajRoditeljaToolStripMenuItem.Click += new System.EventHandler(this.dodajRoditeljaToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiZaposlenikeToolStripMenuItem,
            this.dodajZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // prikažiZaposlenikeToolStripMenuItem
            // 
            this.prikažiZaposlenikeToolStripMenuItem.Name = "prikažiZaposlenikeToolStripMenuItem";
            this.prikažiZaposlenikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikažiZaposlenikeToolStripMenuItem.Text = "Prikaži zaposlenike";
            this.prikažiZaposlenikeToolStripMenuItem.Click += new System.EventHandler(this.prikažiZaposlenikeToolStripMenuItem_Click);
            // 
            // dodajZaposlenikaToolStripMenuItem
            // 
            this.dodajZaposlenikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voditeljToolStripMenuItem,
            this.trenerToolStripMenuItem,
            this.asistentToolStripMenuItem});
            this.dodajZaposlenikaToolStripMenuItem.Name = "dodajZaposlenikaToolStripMenuItem";
            this.dodajZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajZaposlenikaToolStripMenuItem.Text = "Dodaj zaposlenika";
            // 
            // voditeljToolStripMenuItem
            // 
            this.voditeljToolStripMenuItem.Name = "voditeljToolStripMenuItem";
            this.voditeljToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voditeljToolStripMenuItem.Text = "Voditelj";
            this.voditeljToolStripMenuItem.Click += new System.EventHandler(this.voditeljToolStripMenuItem_Click);
            // 
            // trenerToolStripMenuItem
            // 
            this.trenerToolStripMenuItem.Name = "trenerToolStripMenuItem";
            this.trenerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trenerToolStripMenuItem.Text = "Trener";
            this.trenerToolStripMenuItem.Click += new System.EventHandler(this.trenerToolStripMenuItem_Click);
            // 
            // asistentToolStripMenuItem
            // 
            this.asistentToolStripMenuItem.Name = "asistentToolStripMenuItem";
            this.asistentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asistentToolStripMenuItem.Text = "Asistent";
            this.asistentToolStripMenuItem.Click += new System.EventHandler(this.asistentToolStripMenuItem_Click);
            // 
            // uplateToolStripMenuItem
            // 
            this.uplateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiUplateToolStripMenuItem,
            this.dodajUplatuToolStripMenuItem});
            this.uplateToolStripMenuItem.Name = "uplateToolStripMenuItem";
            this.uplateToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.uplateToolStripMenuItem.Text = "Uplate";
            // 
            // prikažiUplateToolStripMenuItem
            // 
            this.prikažiUplateToolStripMenuItem.Name = "prikažiUplateToolStripMenuItem";
            this.prikažiUplateToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.prikažiUplateToolStripMenuItem.Text = "Prikaži uplate";
            this.prikažiUplateToolStripMenuItem.Click += new System.EventHandler(this.prikažiUplateToolStripMenuItem_Click);
            // 
            // dodajUplatuToolStripMenuItem
            // 
            this.dodajUplatuToolStripMenuItem.Name = "dodajUplatuToolStripMenuItem";
            this.dodajUplatuToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dodajUplatuToolStripMenuItem.Text = "Dodaj uplatu";
            this.dodajUplatuToolStripMenuItem.Click += new System.EventHandler(this.dodajUplatuToolStripMenuItem_Click);
            // 
            // koreografijaToolStripMenuItem
            // 
            this.koreografijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiKoregrafijeToolStripMenuItem,
            this.dodajKoreografiuToolStripMenuItem});
            this.koreografijaToolStripMenuItem.Name = "koreografijaToolStripMenuItem";
            this.koreografijaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.koreografijaToolStripMenuItem.Text = "Koreografija";
            // 
            // prikažiKoregrafijeToolStripMenuItem
            // 
            this.prikažiKoregrafijeToolStripMenuItem.Name = "prikažiKoregrafijeToolStripMenuItem";
            this.prikažiKoregrafijeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.prikažiKoregrafijeToolStripMenuItem.Text = "Prikaži koregrafije";
            this.prikažiKoregrafijeToolStripMenuItem.Click += new System.EventHandler(this.prikažiKoregrafijeToolStripMenuItem_Click);
            // 
            // dodajKoreografiuToolStripMenuItem
            // 
            this.dodajKoreografiuToolStripMenuItem.Name = "dodajKoreografiuToolStripMenuItem";
            this.dodajKoreografiuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dodajKoreografiuToolStripMenuItem.Text = "Dodaj koreografiju";
            this.dodajKoreografiuToolStripMenuItem.Click += new System.EventHandler(this.dodajKoreografiuToolStripMenuItem_Click);
            // 
            // grupeToolStripMenuItem
            // 
            this.grupeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiGrupeToolStripMenuItem,
            this.dodajGrupuToolStripMenuItem});
            this.grupeToolStripMenuItem.Name = "grupeToolStripMenuItem";
            this.grupeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.grupeToolStripMenuItem.Text = "Grupe";
            // 
            // prikažiGrupeToolStripMenuItem
            // 
            this.prikažiGrupeToolStripMenuItem.Name = "prikažiGrupeToolStripMenuItem";
            this.prikažiGrupeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.prikažiGrupeToolStripMenuItem.Text = "Prikaži grupe";
            this.prikažiGrupeToolStripMenuItem.Click += new System.EventHandler(this.prikažiGrupeToolStripMenuItem_Click);
            // 
            // dodajGrupuToolStripMenuItem
            // 
            this.dodajGrupuToolStripMenuItem.Name = "dodajGrupuToolStripMenuItem";
            this.dodajGrupuToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dodajGrupuToolStripMenuItem.Text = "Dodaj grupu";
            this.dodajGrupuToolStripMenuItem.Click += new System.EventHandler(this.dodajGrupuToolStripMenuItem_Click);
            // 
            // treninziToolStripMenuItem
            // 
            this.treninziToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiTreningeToolStripMenuItem,
            this.dodajTreningToolStripMenuItem});
            this.treninziToolStripMenuItem.Name = "treninziToolStripMenuItem";
            this.treninziToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.treninziToolStripMenuItem.Text = "Treninzi";
            // 
            // prikažiTreningeToolStripMenuItem
            // 
            this.prikažiTreningeToolStripMenuItem.Name = "prikažiTreningeToolStripMenuItem";
            this.prikažiTreningeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.prikažiTreningeToolStripMenuItem.Text = "Prikaži treninge";
            this.prikažiTreningeToolStripMenuItem.Click += new System.EventHandler(this.prikažiTreningeToolStripMenuItem_Click);
            // 
            // dodajTreningToolStripMenuItem
            // 
            this.dodajTreningToolStripMenuItem.Name = "dodajTreningToolStripMenuItem";
            this.dodajTreningToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.dodajTreningToolStripMenuItem.Text = "Dodaj trening";
            this.dodajTreningToolStripMenuItem.Click += new System.EventHandler(this.dodajTreningToolStripMenuItem_Click);
            // 
            // obavijestiToolStripMenuItem
            // 
            this.obavijestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiObavijestiToolStripMenuItem,
            this.dodajObavijestToolStripMenuItem});
            this.obavijestiToolStripMenuItem.Name = "obavijestiToolStripMenuItem";
            this.obavijestiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.obavijestiToolStripMenuItem.Text = "Obavijesti";
            // 
            // prikažiObavijestiToolStripMenuItem
            // 
            this.prikažiObavijestiToolStripMenuItem.Name = "prikažiObavijestiToolStripMenuItem";
            this.prikažiObavijestiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.prikažiObavijestiToolStripMenuItem.Text = "Prikaži obavijesti";
            this.prikažiObavijestiToolStripMenuItem.Click += new System.EventHandler(this.prikažiObavijestiToolStripMenuItem_Click);
            // 
            // dodajObavijestToolStripMenuItem
            // 
            this.dodajObavijestToolStripMenuItem.Name = "dodajObavijestToolStripMenuItem";
            this.dodajObavijestToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.dodajObavijestToolStripMenuItem.Text = "Dodaj obavijest";
            this.dodajObavijestToolStripMenuItem.Click += new System.EventHandler(this.dodajObavijestToolStripMenuItem_Click);
            // 
            // pravdanjaToolStripMenuItem
            // 
            this.pravdanjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiPravdanjaToolStripMenuItem,
            this.dodajPravdanjeToolStripMenuItem});
            this.pravdanjaToolStripMenuItem.Name = "pravdanjaToolStripMenuItem";
            this.pravdanjaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.pravdanjaToolStripMenuItem.Text = "Pravdanja";
            // 
            // prikažiPravdanjaToolStripMenuItem
            // 
            this.prikažiPravdanjaToolStripMenuItem.Name = "prikažiPravdanjaToolStripMenuItem";
            this.prikažiPravdanjaToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.prikažiPravdanjaToolStripMenuItem.Text = "Prikaži pravdanja";
            this.prikažiPravdanjaToolStripMenuItem.Click += new System.EventHandler(this.prikažiPravdanjaToolStripMenuItem_Click);
            // 
            // dodajPravdanjeToolStripMenuItem
            // 
            this.dodajPravdanjeToolStripMenuItem.Name = "dodajPravdanjeToolStripMenuItem";
            this.dodajPravdanjeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.dodajPravdanjeToolStripMenuItem.Text = "Dodaj pravdanje";
            this.dodajPravdanjeToolStripMenuItem.Click += new System.EventHandler(this.dodajPravdanjeToolStripMenuItem_Click);
            // 
            // radioniceToolStripMenuItem
            // 
            this.radioniceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiRadioniceToolStripMenuItem,
            this.dodajRadionicuToolStripMenuItem});
            this.radioniceToolStripMenuItem.Name = "radioniceToolStripMenuItem";
            this.radioniceToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.radioniceToolStripMenuItem.Text = "Radionice";
            // 
            // prikažiRadioniceToolStripMenuItem
            // 
            this.prikažiRadioniceToolStripMenuItem.Name = "prikažiRadioniceToolStripMenuItem";
            this.prikažiRadioniceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.prikažiRadioniceToolStripMenuItem.Text = "Prikaži radionice";
            this.prikažiRadioniceToolStripMenuItem.Click += new System.EventHandler(this.prikažiRadioniceToolStripMenuItem_Click);
            // 
            // dodajRadionicuToolStripMenuItem
            // 
            this.dodajRadionicuToolStripMenuItem.Name = "dodajRadionicuToolStripMenuItem";
            this.dodajRadionicuToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.dodajRadionicuToolStripMenuItem.Text = "Dodaj radionicu";
            this.dodajRadionicuToolStripMenuItem.Click += new System.EventHandler(this.dodajRadionicuToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Imate 1 novi zahtjev.";
            this.notifyIcon1.BalloonTipTitle = "Obavijest";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon2.BalloonTipTitle = "Obavijest";
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.BalloonTipClicked += new System.EventHandler(this.notifyIcon2_BalloonTipClicked);
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
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem uplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiUplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUplatuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem koreografijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiKoregrafijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKoreografiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiGrupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajGrupuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treninziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiTreningeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTreningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiObavijestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajObavijestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pravdanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiPravdanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPravdanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiRadioniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRadionicuToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiZaposlenikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voditeljToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistentToolStripMenuItem;
    }
}