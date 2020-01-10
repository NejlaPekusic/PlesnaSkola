using PlesnaSkola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Uplate
{
    public partial class frmUplateDetails : Form
    {
        private APIService _serviceUplate = new APIService("Uplate");
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private int _uplataId;

        public frmUplateDetails()
        {
            InitializeComponent();
        }

        public frmUplateDetails(int uplataId)
        {
            InitializeComponent();
            _uplataId = uplataId;
            btnDodaj.Text = "Snimi";
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var request = new Model.Requests.UplateInsertRequest
            {
                PlesacId = (cmbPlesaci.SelectedItem as Model.Korisnici).KorisnikId,
                DatumUplate = dtpDatumUplate.Value,
                IznosUplate = double.Parse(txtIznos.Text),
                VrstaUplate = (VrstaUplate)cmbVrstaUplate.SelectedItem
            };
            if (request.VrstaUplate == VrstaUplate.Ostalo)
                request.Opis = txtOpis.Text;

            if(_uplataId != 0)
            {
                var entity = await _serviceUplate.Update<Model.Uplate>(_uplataId, request);
                if (entity != null)
                {
                    MessageBox.Show("Uplata izmijenjena.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceUplate.Insert<Model.Uplate>(request);
                if (entity != null)
                {
                    MessageBox.Show("Uplata dodana.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private async void frmUplateDetails_Load(object sender, EventArgs e)
        {
            await UcitajPlesace();
            UcitajVrsteUplata();

            if (_uplataId != 0)
            {
                await UcitajUplatu();
            }
        }

        private async Task UcitajUplatu()
        {
            var entity = await _serviceUplate.GetById<Model.Uplate>(_uplataId);
            if (entity != null)
            {
                txtOpis.Text = entity.Opis;
                txtIznos.Text = entity.IznosUplate.ToString("0.00");
                dtpDatumUplate.Value = entity.DatumUplate;

                foreach (Model.Korisnici korisnik in cmbPlesaci.Items)
                {
                    if (korisnik.KorisnikId == entity.PlesacId)
                    {
                        cmbPlesaci.SelectedItem = korisnik;
                    }
                }

                foreach (VrstaUplate vrstaUplate in cmbVrstaUplate.Items)
                {
                    if (vrstaUplate == entity.VrstaUplate)
                    {
                        cmbVrstaUplate.SelectedItem = vrstaUplate;
                    }
                }
            }
        }

        private void UcitajVrsteUplata()
        {
            cmbVrstaUplate.DataSource = Enum.GetValues(typeof(VrstaUplate));
        }

        private async Task UcitajPlesace()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                IncludePlesaci = true
            };

            var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
            cmbPlesaci.DataSource = list;
            cmbPlesaci.ValueMember = "KorisnikId";
            cmbPlesaci.DisplayMember = "ImePrezime";
        }

        private void cmbVrstaUplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((VrstaUplate)cmbVrstaUplate.SelectedItem == VrstaUplate.Ostalo)
            {
                groupBox2.Height = 241;
                btnDodaj.Location = new Point(114, 265);
                this.Height = 340;
                txtOpis.Visible = true;
                lblOpis.Visible = true;
            }
            else
            {
                groupBox2.Height = 159;
                btnDodaj.Location = new Point(114, 182);
                this.Height = 255;
                txtOpis.Visible = false;
                txtOpis.Text = "";
                lblOpis.Visible = false;

            }
        }

        private void cmbPlesaci_Validating(object sender, CancelEventArgs e)
        {
            ComboBox control = sender as ComboBox;
            if (control.SelectedIndex <= 0)
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }


        //ovo prepraviti za cijenu
        private void txtIznos_Validating(object sender, CancelEventArgs e)
        {
            TextBox control = sender as TextBox;
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                Regex expr = new Regex(@"[0-9]");
                if (expr.IsMatch(control.Text))
                {
                    errorProvider1.SetError(control, null);
                }
                else
                {
                    errorProvider1.SetError(control, Properties.Resources.Validation_Number);
                    e.Cancel = true;
                }


            }
        }

        private void cmbVrstaUplate_Validating(object sender, CancelEventArgs e)
        {
            ComboBox control = sender as ComboBox;
            if (control.SelectedIndex < 0)
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
