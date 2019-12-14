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

        private async Task UcitajDataGrid()
        {
            var list = await _servicePravdanja.Get<List<Model.Pravdanja>>(null);
            dgvPravdanja.AutoGenerateColumns = false;
            dgvPravdanja.DataSource = list;
        }

        private async void frmPravdanja_Load(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }


        private async void dgvPravdanja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int PravdanjeId = int.Parse(dgvPravdanja.SelectedRows[0].Cells["PravdanjeId"].Value.ToString());
            var frm = new frmPravdanjeDetails(PravdanjeId);
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void btnDodajPravdanje_Click(object sender, EventArgs e)
        {
            var frm = new frmPravdanjeDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void cmbGrupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
