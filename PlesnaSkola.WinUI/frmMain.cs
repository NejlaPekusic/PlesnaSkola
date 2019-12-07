using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void prikažiČlanoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Clanovi.frmClanovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajPlesačaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Clanovi.frmPlesaciDetails();
            frm.ShowDialog();
        }

        private void dodajRoditeljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Clanovi.frmRoditeljiDetails();
            frm.ShowDialog();
        }

        private void prikažiUplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Uplate.frmUplate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajUplatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Uplate.frmUplateDetails();
            frm.ShowDialog();
        }

        private void prikažiKoregrafijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Koreografije.frmKoreografije();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajKoreografiuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Koreografije.frmKoreografijeDetails();
            frm.ShowDialog();
        }
    }
}
