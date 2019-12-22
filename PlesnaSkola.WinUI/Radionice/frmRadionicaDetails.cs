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

namespace PlesnaSkola.WinUI.Radionice
{
    public partial class frmRadionicaDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceRadionice = new APIService("Radionice");
        private int _radionicaId;

        public frmRadionicaDetails()
        {
            InitializeComponent();
        }

        public frmRadionicaDetails(int radionicaId)
        {
            InitializeComponent();
            _radionicaId = radionicaId;

            btnDodaj.Text = "Snimi";
        }

        private async void frmRadionicaDetails_Load(object sender, EventArgs e)
        {
            await LoadComboboxes();
            if (_radionicaId != 0)
            {
                await UcitajRadionicu();
            }
        }

        private async Task LoadComboboxes()
        {
            await LoadAsistentiCmb();

        }
        
        
        private async Task LoadAsistentiCmb()
        {
            var requestAsistenti = new Model.Requests.KorisniciSearchRequest
            {
                IncludeAsistenti = true
            };
            var listAsistenti = await _serviceKorisnici.Get<List<Model.Korisnici>>(requestAsistenti);
            listAsistenti.Insert(0, new Model.Korisnici { KorisnikId = 0, Ime = "", Prezime = "" });

            cmbAsistent.DataSource = listAsistenti;
            cmbAsistent.DisplayMember = "ImePrezime";
            cmbAsistent.ValueMember = "KorisnikId";
        }

        

        private async Task UcitajRadionicu()
        {
            var entity = await _serviceRadionice.GetById<Model.Radionice>(_radionicaId);
            if (entity != null)
            {
                dtpDatum.Value = entity.DatumOdrzavanja;

                dtpVrijeme.Value = DateTime.Now.Date.Add(entity.VrijemeOdrzavanja);

                foreach (Model.Korisnici asistent in cmbAsistent.Items)
                {
                    if (asistent.KorisnikId == entity.AsistentId)
                    {
                        cmbAsistent.SelectedItem = asistent;
                    }
                }
            }
        }


        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.RadioniceInsertRequest
            {
                VrijemeOdrzavanja = dtpVrijeme.Value.TimeOfDay,
                BrojUcesnika = Convert.ToInt32(txtBrojUcesnika.Text),
                MjestoOdrzavanja = txtMjestoOdrzavanja.Text,
                NazivRadionice = txtNazivRadionice.Text,
                Opis = txtOpis.Text,
                AsistentId = (cmbAsistent.SelectedItem as Model.Korisnici).KorisnikId
                
            };

            if (_radionicaId == 0)
            {
                var entity = await _serviceRadionice.Insert<Model.Radionice>(request);
                if (entity != null)
                {
                    MessageBox.Show("Radionica dodana.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceRadionice.Update<Model.Radionice>(_radionicaId, request);
                if (entity != null)
                {
                    MessageBox.Show("Radionica izmijenjena.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtNazivRadionice_Validating(object sender, CancelEventArgs e)
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

        private void txtMjestoOdrzavanja_Validating(object sender, CancelEventArgs e)
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

        private void txtBrojUcesnika_Validating(object sender, CancelEventArgs e)
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

        private void cmbAsistent_Validating(object sender, CancelEventArgs e)
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
