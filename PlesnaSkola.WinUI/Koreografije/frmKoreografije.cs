﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Koreografije
{
    public partial class frmKoreografije : Form
    {
        private APIService _serviceKoreografije = new APIService("Koreografije");

        public frmKoreografije()
        {
            InitializeComponent();
        }

        private async Task UcitajDataGrid()
        {
            var request = new Model.Requests.KoreografijeSearchRequest
            {
                NazivKoreografije = txtPretraga.Text,
                Stil = cmbStil.SelectedIndex

            };

            var list = await _serviceKoreografije.Get<List<Model.Koreografije>>(request);
            dgvKoreografije.AutoGenerateColumns = false;
            dgvKoreografije.DataSource = list;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }

        private async void frmKoreografije_Load(object sender, EventArgs e)
        {
            UcitajStilove();
            await UcitajDataGrid();
        }

        private void UcitajStilove()
        {
            var list = new List<string>
            {
                "Svi",
                "Jazz",
                "Show",
                "Acro",
                "Contemporary",
                "Lyrical",
                "Street",
                "HipHop",
                "Freestyle",
                "Open",
            };

            cmbStil.DataSource = list;
        }

        private async void btnDodajKoreografiju_Click(object sender, EventArgs e)
        {
            var frm = new Koreografije.frmKoreografijeDetails();
            frm.ShowDialog();

            await UcitajDataGrid();
        }

        private async void dgvKoreografije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = int.Parse(dgvKoreografije.SelectedRows[0].Cells["KoreografijaId"].Value.ToString());

            var frm = new frmKoreografijeDetails(Id);
            frm.ShowDialog();
            await UcitajDataGrid();
        }

        private async void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            await UcitajDataGrid();
        }

        private async void cmbStil_SelectedIndexChanged(object sender, EventArgs e)
        {
            await UcitajDataGrid();
        }
    }
}
