using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Radionice
{
    public partial class frmRadionice : Form
    {
        private APIService _serviceRadionice = new APIService("Radionice");

        public frmRadionice()
        {
            InitializeComponent();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.RadioniceSearchRequest
            {
                NazivRadionice = txtPretraga.Text
            };

            var list = await _serviceRadionice.Get<List<Model.Radionice>>(request);
            dgvRadionice.AutoGenerateColumns = false;
            dgvRadionice.DataSource = list;
        }

        private async void frmRadionice_Load(object sender, EventArgs e)
        {

            await UcitajDataGrid();
        }



        private async void dgvRadionice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RadionicaId = int.Parse(dgvRadionice.SelectedRows[0].Cells["RadionicaId"].Value.ToString());
            var frm = new frmRadionicaDetails(RadionicaId);
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void btnDodajRadionicu_Click(object sender, EventArgs e)
        {
            var frm = new frmRadionicaDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await UcitajDataGrid();
        }
        
    }
}
