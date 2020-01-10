using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Treninzi
{
    public partial class frmTreninzi : Form
    {
        private APIService _serviceTreninzi = new APIService("Treninzi");
        private APIService _serviceGrupe = new APIService("Grupe");

        public frmTreninzi()
        {
            InitializeComponent();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.TreninziSearchRequest
            {
                GrupaId = (cmbGrupe.SelectedItem as Model.Grupe).GrupaId,
                //Sala=cmbSale.SelectedIndex
            };

            var list = await _serviceTreninzi.Get<List<Model.Treninzi>>(request);
            dgvTreninzi.AutoGenerateColumns = false;
            dgvTreninzi.DataSource = list;
        }

        private async void frmTreninzi_Load(object sender, EventArgs e)
        {
            //UcitajSale();
            await UcitajCmbGrupe();
            await UcitajDataGrid();
        }

        private async Task UcitajCmbGrupe()
        {
            var list = await _serviceGrupe.Get<List<Model.Grupe>>(null);
            list.Insert(0, new Model.Grupe { GrupaId = 0, NazivGrupe = "Sve grupe" });
            cmbGrupe.DataSource = list;
            cmbGrupe.DisplayMember = "NazivGrupe";
            cmbGrupe.ValueMember = "GrupaId";
        }

        //private void UcitajSale()
        //{
        //    var list = new List<string>
        //    {
        //        "Sve",
        //        "Sala 1",
        //        "Sala 2",
        //        "Sala 3"
        //    };

        //    cmbSale.DataSource = list;
        //}

        private async void dgvTreninzi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int TreningId = int.Parse(dgvTreninzi.SelectedRows[0].Cells["TreningId"].Value.ToString());
            var frm = new frmTreningDetails(TreningId);
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void btnDodajTrening_Click(object sender, EventArgs e)
        {
            var frm = new frmTreningDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void cmbGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        //private async void cmbSale_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    await UcitajDataGrid();
        //}
    }
}
