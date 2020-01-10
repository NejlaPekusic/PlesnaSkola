using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Uplate
{
    public partial class frmUplate : Form
    {
        private APIService _serviceUplate = new APIService("Uplate");

        public frmUplate()
        {
            InitializeComponent();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.UplateSearchRequest
            {
                IncludeClanovi = true,
                ImePrezime = txtPretraga.Text,
                VrstaUplate=cmbVrsteUplata.SelectedIndex
            };
            
            var list = await _serviceUplate.Get<List<Model.Uplate>>(request);
            dgvUplate.AutoGenerateColumns = false;
            dgvUplate.DataSource = list;
        }

        private void UcitajVrsteUplata()
        {
            var list = new List<string>
            {
                "Sve",
                "Članarina",
                "Upisnina",
                "Kostim",
                "Kotizacija",
                "Prevoz",
                "Smještaj",
                "Ostalo"
            };

            cmbVrsteUplata.DataSource = list;
            cmbVrsteUplata.SelectedIndex = 0;

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private async void frmUplate_Load(object sender, EventArgs e)
        {
            UcitajVrsteUplata();
            await UcitajDataGrid();
        }

        private async void btnDodajUplatu_Click(object sender, EventArgs e)
        {
            var frm = new frmUplateDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void dgvUplate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(dgvUplate.SelectedRows[0].Cells["UplataId"].Value.ToString());

            var frm = new frmUplateDetails(Id);
            frm.ShowDialog();
            await UcitajDataGrid();
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await UcitajDataGrid();

        }

        private async void cmbVrsteUplata_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
