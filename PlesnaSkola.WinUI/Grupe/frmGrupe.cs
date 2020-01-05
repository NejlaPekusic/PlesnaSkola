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
    public partial class frmGrupe : Form
    {
        private APIService _serviceGrupe = new APIService("Grupe");

        public frmGrupe()
        {
            InitializeComponent();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.GrupeSearchRequest
            {
                NazivGrupe = txtPretraga.Text,
                Status = cmbStatus.SelectedIndex
            };

            var list = await _serviceGrupe.Get<List<Model.Grupe>>(request);
            dgvGrupe.AutoGenerateColumns = false;
            dgvGrupe.DataSource = list;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await UcitajDataGrid();

        }
        private void UcitajStatuse()
        {
            var list = new List<string>
            {
                "Sve",
                "Aktivne",
                "Neaktivne"
            };

            cmbStatus.DataSource = list;
        }
        private void dgvGrupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int GrupaId = int.Parse(dgvGrupe.Rows[e.RowIndex].Cells["GrupaId"].Value.ToString());
                var frm = new frmGrupeClanovi(GrupaId);
                frm.ShowDialog();
            }
        }

        private async void frmGrupe_Load(object sender, EventArgs e)
        {
            UcitajStatuse();
            await UcitajDataGrid();
        }

        private async void dgvGrupe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int GrupaId = int.Parse(dgvGrupe.SelectedRows[0].Cells["GrupaId"].Value.ToString());
            var frm = new frmGrupeDetails(GrupaId);
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void btnDodajGrupu_Click(object sender, EventArgs e)
        {
            var frm = new frmGrupeDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await UcitajDataGrid();

        }

        private async void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
