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
    }
}
