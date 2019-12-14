using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Obavijesti
{
    public partial class frmObavijesti : Form
    {
        private APIService _serviceObavijesti = new APIService("Obavijesti");

        public frmObavijesti()
        {
            InitializeComponent();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.ObavijestiSearchRequest
            {
                Naslov = txtPretraga.Text
            };

            var list = await _serviceObavijesti.Get<List<Model.Obavijesti>>(request);
            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = list;
        }

        private async void frmObavijesti_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private async void btnDodajObavijest_Click(object sender, EventArgs e)
        {
            var frm = new Obavijesti.frmObavijestiDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void dgvObavijesti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(dgvObavijesti.SelectedRows[0].Cells["ObavijestId"].Value.ToString());

            var frm = new frmObavijestiDetails(Id);
            frm.ShowDialog();
            await UcitajDataGrid();
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
