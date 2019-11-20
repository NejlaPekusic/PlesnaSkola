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

namespace PlesnaSkola.WinUI.Clanovi
{
    public partial class frmClanovi : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");

        public frmClanovi()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private async void frmClanovi_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();

        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                IncludeClanovi = true,
                ImePrezime = txtPretraga.Text
            };

            var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
            dgvClanovi.AutoGenerateColumns = false;
            dgvClanovi.DataSource = list;
        }

        private async void btnDodajClana_Click(object sender, EventArgs e)
        {
            var frm = new frmPlesaciDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }


        private async void dgvClanovi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int KorisnikId = int.Parse(dgvClanovi.SelectedRows[0].Cells["KorisnikId"].Value.ToString());
            Model.Korisnici Korisnik = dgvClanovi.SelectedRows[0].DataBoundItem as Model.Korisnici;

            if (Korisnik.Plesac != null)
            {
                var frm = new frmPlesaciDetails(KorisnikId);
                frm.ShowDialog();
                await UcitajDataGrid();
            }
            else if (Korisnik.Roditelj != null)
            {
                var frm = new frmRoditeljiDetails(KorisnikId);
                frm.ShowDialog();
                await UcitajDataGrid();
            }
        }
    }
}
