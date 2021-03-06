﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Pravdanja
{
    public partial class frmPravdanja : Form
    {
        private APIService _servicePravdanja = new APIService("Pravdanja");
        private APIService _serviceGrupe = new APIService("Grupe");

        public frmPravdanja()
        {
            InitializeComponent();
        }

        public async Task UcitajDataGrid()
        {
            var request = new Model.Requests.PravdanjaSearchRequest
            {
                Filter = cmbFilter.SelectedIndex
            };
            var list = await _servicePravdanja.Get<List<Model.Pravdanja>>(request);
            dgvPravdanja.AutoGenerateColumns = false;
            dgvPravdanja.DataSource = list;
        }

        private void frmPravdanja_Load(object sender, EventArgs e)
        {
            UcitajFilterDropdown();
        }

        private void UcitajFilterDropdown()
        {
            var list = new List<string>()
            {
                "Zahtjevi", "Izdano", "Sve"
            };
            cmbFilter.DataSource = list;
            cmbFilter.SelectedIndex = 0;
        }

        private async void dgvPravdanja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int PravdanjeId = int.Parse(dgvPravdanja.SelectedRows[0].Cells["PravdanjeId"].Value.ToString());
            var frm = new frmPravdanjeDetails(PravdanjeId);

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                if (frm.Tag is Model.Pravdanja pravdanje)
                {
                    var frmPrint = new frmPravdanjePrint(pravdanje);
                    frmPrint.ShowDialog();
                }
            }

            await UcitajDataGrid();
        }

        private async void btnDodajPravdanje_Click(object sender, EventArgs e)
        {
            var frm = new frmPravdanjeDetails();

            if (frm.ShowDialog() == DialogResult.Yes)
            {
                if(frm.Tag is Model.Pravdanja pravdanje)
                {
                    var frmPrint = new frmPravdanjePrint(pravdanje);
                    frmPrint.ShowDialog();
                }
            }

            await UcitajDataGrid();
        }


        private async void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
