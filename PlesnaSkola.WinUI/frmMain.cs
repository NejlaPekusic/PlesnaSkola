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
        private static Timer myTimer = new Timer();
        private readonly APIService _servicePravdanja = new APIService("Pravdanja");
        private DateTime DatumNajnovijegZahtjeva = DateTime.Now;

        public frmMain()
        {
            InitializeComponent();

            if (APIService.PrijavljeniKorisnik.Voditelj != null)
            {
                myTimer.Tick += new EventHandler(TimerEventProcessor);
                myTimer.Interval = 5000;
                myTimer.Start();
            }
        }

        private async void TimerEventProcessor(object sender, EventArgs e)
        {
            myTimer.Stop();

            var zahtjev = await _servicePravdanja.Get<Model.Pravdanja>(null, "GetNajnovijiZahtjev");
            if (zahtjev != null && zahtjev.DatumZahtjeva > DatumNajnovijegZahtjeva)
            {
                DatumNajnovijegZahtjeva = zahtjev.DatumZahtjeva.Value;

                notifyIcon1.ShowBalloonTip(10);
                notifyIcon1.Tag = zahtjev;

                foreach (var child in this.MdiChildren)
                {
                    if(child is Pravdanja.frmPravdanja forma)
                    {
                        forma.UcitajDataGrid();
                    }
                }
            }

            myTimer.Enabled = true;
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

        private void prikažiGrupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Grupe.frmGrupe();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Grupe.frmGrupeDetails();
            frm.ShowDialog();
        }

        private void prikažiTreningeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Treninzi.frmTreninzi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajTreningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Treninzi.frmTreningDetails();
            frm.ShowDialog();
        }

        private void prikažiObavijestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Obavijesti.frmObavijesti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajObavijestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Obavijesti.frmObavijestiDetails();
            frm.ShowDialog();
        }

        private void prikažiPravdanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Pravdanja.frmPravdanja();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajPravdanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Pravdanja.frmPravdanjeDetails();
            frm.ShowDialog();
        }

        private void prikažiRadioniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Radionice.frmRadionice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dodajRadionicuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Radionice.frmRadionicaDetails();
            frm.ShowDialog();
        }


        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (notifyIcon1.Tag is Model.Pravdanja entity)
            {
                var frm = new Pravdanja.frmPravdanjeDetails(entity.PravdanjeId);
                frm.ShowDialog();
            }
        }

        private void notifyIcon2_BalloonTipClicked(object sender, EventArgs e)
        {
            var frm = new Pravdanja.frmPravdanja();
            frm.MdiParent = this;
            frm.Show();
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            UpdateDostupneMenije();

            if (APIService.PrijavljeniKorisnik.Voditelj != null)
            {
                int brojZahtjeva = await _servicePravdanja.Get<int>(null, "GetBrojZahtjeva");
                if (brojZahtjeva > 0)
                {
                    notifyIcon2.BalloonTipText = "Imate " + brojZahtjeva + " zahtjeva na čekanju. Kliknite ovdje da ih pregledate.";
                    notifyIcon2.ShowBalloonTip(10);
                }
            }
        }

        private void UpdateDostupneMenije()
        {
            var IsVoditelj = APIService.PrijavljeniKorisnik.Voditelj != null;
            var IsTrener = APIService.PrijavljeniKorisnik.Trener != null;
            var IsAsistent = APIService.PrijavljeniKorisnik.Asistent != null;

            članoviToolStripMenuItem.Visible = IsVoditelj;
            uplateToolStripMenuItem.Visible = IsVoditelj;
            grupeToolStripMenuItem.Visible = IsVoditelj || IsTrener;
            treninziToolStripMenuItem.Visible = IsVoditelj || IsTrener;
            pravdanjaToolStripMenuItem.Visible = IsVoditelj;
            radioniceToolStripMenuItem.Visible = IsVoditelj || IsAsistent;

            if (IsVoditelj)
                myTimer.Enabled = true;

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            myTimer.Stop();

            foreach (var child in this.MdiChildren)
            {
                child.Close();
            }

            var frm = new frmLogin();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                UpdateDostupneMenije();
            }
            else
            {
                Close();
            }
        }

        private void prikažiZaposlenikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Zaposlenici.frmZaposlenici();
            frm.MdiParent = this;
            frm.Show();
        }

        private void voditeljToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Zaposlenici.frmVoditeljiDetails();
            frm.ShowDialog();
        }

        private void trenerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Zaposlenici.frmTreneriDetails();
            frm.ShowDialog();
        }

        private void asistentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Zaposlenici.frmAsistentiDetails();
            frm.ShowDialog();
        }
    }
}
