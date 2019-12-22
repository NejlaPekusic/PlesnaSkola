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
    public partial class frmGrupeDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceGrupe = new APIService("Grupe");
        private int _grupaId;

        public frmGrupeDetails()
        {
            InitializeComponent();
        }

        public frmGrupeDetails(int grupaId)
        {
            InitializeComponent();
            _grupaId = grupaId;

            btnDodaj.Text = "Snimi";
        }

        private async void frmGrupeDetails_Load(object sender, EventArgs e)
        {
            await LoadComboboxes();
            if (_grupaId != 0)
            {
                await UcitajGrupu();
            }
        }

        private async Task LoadComboboxes()
        {

            await LoadTreneriCmb();
        }


        private async Task LoadTreneriCmb()
        {
            var requestTreneri = new Model.Requests.KorisniciSearchRequest
            {
                IncludeTreneri = true
            };
            var listTreneri = await _serviceKorisnici.Get<List<Model.Korisnici>>(requestTreneri);
            listTreneri.Insert(0, new Model.Korisnici { KorisnikId = 0, Ime = "", Prezime = "" });

            cmbTrener.DataSource = listTreneri;
            cmbTrener.DisplayMember = "ImePrezime";
            cmbTrener.ValueMember = "KorisnikId";
        }

        private async Task UcitajGrupu()
        {
            var entity = await _serviceGrupe.GetById<Model.Grupe>(_grupaId);
            if (entity != null)
            {
                txtNaziv.Text = entity.NazivGrupe;

                foreach (Model.Korisnici trener in cmbTrener.Items)
                {
                    if (trener.KorisnikId == entity.TrenerId)
                    {
                        cmbTrener.SelectedItem = trener;
                    }
                }
            }
        }

       
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.GrupeInsertRequest
            {
                NazivGrupe = txtNaziv.Text,
                TrenerId = (cmbTrener.SelectedItem as Model.Korisnici).KorisnikId
            };

            if (_grupaId == 0)
            {
                var entity = await _serviceGrupe.Insert<Model.Grupe>(request);
                if (entity != null)
                {
                    MessageBox.Show("Grupa dodana.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceGrupe.Update<Model.Grupe>(_grupaId, request);
                if (entity != null)
                {
                    MessageBox.Show("Grupa izmijenjena.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
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

        private void cmbTrener_Validating(object sender, CancelEventArgs e)
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
    }
}
