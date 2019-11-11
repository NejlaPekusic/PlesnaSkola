using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Clanovi
{
    public partial class frmPlesaciDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceGrupe = new APIService("Grupe");
        public frmPlesaciDetails()
        {
            InitializeComponent();
        }


        private async void LoadComboboxes()
        {
            await LoadRoditeljiCmb();

            await LoadGrupeCmb();
        }

        private async Task LoadGrupeCmb()
        {
            var requestGrupe = new Model.Requests.GrupeSearchRequest
            {
            };
            var listGrupe = await _serviceGrupe.Get<List<Model.Grupe>>(requestGrupe);
            cmbGrupa.DataSource = listGrupe;
            cmbGrupa.DisplayMember = "NazivGrupe";
            cmbGrupa.ValueMember = "GrupaId";
        }

        private async Task LoadRoditeljiCmb()
        {
            var requestRoditelji = new Model.Requests.KorisniciSearchRequest
            {
                IncludeRoditelji = true
            };
            var listRoditelji = await _serviceKorisnici.Get<List<Model.Korisnici>>(requestRoditelji);
            cmbRoditelj.DataSource = listRoditelji;
            cmbRoditelj.DisplayMember = "ImePrezime";
            cmbRoditelj.ValueMember = "KorisnikId";
        }

        private async void btnDodajRoditelja_Click(object sender, EventArgs e)
        {
            var frm = new frmRoditeljiDetails();
            frm.ShowDialog();

            await LoadRoditeljiCmb();
        }
    }
}
