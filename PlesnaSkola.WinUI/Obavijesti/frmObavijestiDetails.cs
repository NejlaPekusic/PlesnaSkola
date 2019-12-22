using PlesnaSkola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Obavijesti
{
    public partial class frmObavijestiDetails : Form
    {
        private APIService _serviceObavijesti = new APIService("Obavijesti");
        private int _obavijestId;

        public string PrilogFileName { get; set; }

        private byte[] Prilog;

        public frmObavijestiDetails()
        {
            InitializeComponent();
        }

        public frmObavijestiDetails(int obavijestId)
        {
            InitializeComponent();
            _obavijestId = obavijestId;

            btnDodaj.Text = "Snimi";
        }

        private async void frmObavijestiDetails_Load(object sender, EventArgs e)
        {
            if (_obavijestId != 0)
            {
                await UcitajObavijest();
            }
        }


        private async Task UcitajObavijest()
        {
            var entity = await _serviceObavijesti.GetById<Model.Obavijesti>(_obavijestId);
            if (entity != null)
            {
                txtNaslov.Text = entity.Naslov;
                txtSadrzaj.Text = entity.Sadrzaj;

                Prilog = entity.Prilog;
            }
        }


        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var request = new Model.Requests.ObavijestiInsertRequest
            {
                Naslov = txtNaslov.Text,
                Sadrzaj = txtSadrzaj.Text,
                Prilog = Prilog,
                PrilogFileName = PrilogFileName
            };

            if (_obavijestId == 0)
            {
                var entity = await _serviceObavijesti.Insert<Model.Obavijesti>(request);
                if (entity != null)
                {
                    MessageBox.Show("Obavijest dodana.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceObavijesti.Update<Model.Obavijesti>(_obavijestId, request);
                if (entity != null)
                {
                    MessageBox.Show("Obavijest izmijenjena.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                lblFileName.Text = Path.GetFileName(fileName);

                PrilogFileName = lblFileName.Text;
                Prilog = File.ReadAllBytes(fileName);

            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            TextBox control = sender as TextBox;
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }
    }
}
