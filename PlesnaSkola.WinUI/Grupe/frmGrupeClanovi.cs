using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Grupe
{
    public partial class frmGrupeClanovi : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private int _grupaId;


        public frmGrupeClanovi(int grupaId)
        {
            InitializeComponent();
            _grupaId = grupaId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void frmGrupeClanovi_Load(object sender, EventArgs e)
        {
            await UcitajListbox();
        }

        private async Task UcitajListbox()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                GrupaId = _grupaId,
                IncludePlesaci = true
            };
            var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
            lbClanovi.DisplayMember = "ImePrezime";
            lbClanovi.DataSource = list;
        }

        private async void lbClanovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbClanovi.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                int KorisnikId = (lbClanovi.Items[index] as Model.Korisnici).KorisnikId;
                var frm = new Clanovi.frmPlesaciDetails(KorisnikId);
                frm.ShowDialog();

                await UcitajListbox();
            }
        }
    }
}
