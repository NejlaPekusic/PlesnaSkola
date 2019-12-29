using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using PlesnaSkola.WinUI.Clanovi;

namespace PlesnaSkola.WinUI.Zaposlenici
{
    public partial class frmZaposlenici : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");

        public frmZaposlenici()
        {
            InitializeComponent();
        }


        private async void frmZaposlenici_Load(object sender, EventArgs e)
        {
            UcitajUloge();

            await UcitajDataGrid();

        }

        private void UcitajUloge()
        {
            var list = new List<string>
            {
                "Sve",
                "Asistenti",
                "Treneri",
                "Voditelji"
            };

            cmbUloga.DataSource = list;
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                ImePrezime = txtPretraga.Text
            };

            int OdabranaUloga = cmbUloga.SelectedIndex;
            if (OdabranaUloga == 1)
                request.IncludeAsistenti = true;
            else if (OdabranaUloga == 2)
                request.IncludeTreneri = true;
            else if (OdabranaUloga == 3)
                request.IncludeVoditelji = true;
            else
                request.IncludeUposlenici = true;

            var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = list;
        }

        private async void btnDodajVoditelja_Click(object sender, EventArgs e)
        {
            var frm = new frmVoditeljiDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void btnDodajTrenera_Click(object sender, EventArgs e)
        {
            var frm = new frmTreneriDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void btnDodajAsistenta_Click(object sender, EventArgs e)
        {
            var frm = new frmAsistentiDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        
        private async void dgvZaposlenici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int KorisnikId = int.Parse(dgvZaposlenici.SelectedRows[0].Cells["KorisnikId"].Value.ToString());
            Model.Korisnici Korisnik = dgvZaposlenici.SelectedRows[0].DataBoundItem as Model.Korisnici;

            if (Korisnik.Voditelj != null)
            {
                var frm = new frmVoditeljiDetails(KorisnikId);
                frm.ShowDialog();
                await UcitajDataGrid();
            }
            else if (Korisnik.Trener != null)
            {
                var frm = new frmTreneriDetails(KorisnikId);
                frm.ShowDialog();
                await UcitajDataGrid();
            }
            else if (Korisnik.Asistent != null)
            {
                var frm = new frmAsistentiDetails(KorisnikId);
                frm.ShowDialog();
                await UcitajDataGrid();
            }
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await UcitajDataGrid();

        }

        private async void cmbUloga_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
