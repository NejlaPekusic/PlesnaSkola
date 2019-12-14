using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Clanovi
{
    public partial class frmPlesaciDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceGrupe = new APIService("Grupe");
        private int _korisnikId;

        public frmPlesaciDetails()
        {
            InitializeComponent();
        }

        public frmPlesaciDetails(int korisnikId)
        {
            InitializeComponent();
            _korisnikId = korisnikId;

            chbAktivan.Visible = true;
            btnDodaj.Text = "Snimi";
        }

        private async void frmPlesaciDetails_Load(object sender, EventArgs e)
        {
            await LoadComboboxes();
            if (_korisnikId != 0)
            {

                await UcitajPlesaca();
            }
        }



        private async Task LoadComboboxes()
        {
            await LoadRoditeljiCmb();

            await LoadGrupeCmb();
        }

        private async Task LoadGrupeCmb()
        {
            var listGrupe = await _serviceGrupe.Get<List<Model.Grupe>>(null);
            cmbGrupa.DataSource = listGrupe;
            cmbGrupa.DisplayMember = "NazivGrupe";
            cmbGrupa.ValueMember = "GrupaId";
        }

        private async Task LoadRoditeljiCmb()
        {
            var requestRoditelji = new Model.Requests.KorisniciSearchRequest
            {
                IncludeRoditelji = true
            };
            var listRoditelji = await _serviceKorisnici.Get<List<Model.Korisnici>>(requestRoditelji);
            listRoditelji.Insert(0, new Model.Korisnici { KorisnikId = 0, Ime = "", Prezime = "" });

            cmbRoditelj.DataSource = listRoditelji;
            cmbRoditelj.DisplayMember = "ImePrezime";
            cmbRoditelj.ValueMember = "KorisnikId";
        }

        private async Task UcitajPlesaca()
        {
            var entity = await _serviceKorisnici.GetById<Model.Korisnici>(_korisnikId);
            if (entity != null)
            {
                txtIme.Text = entity.Ime;
                txtPrezime.Text = entity.Prezime;
                txtKorisnickoIme.Text = entity.Username;
                txtMail.Text = entity.Mail;
                txtBrojPasosa.Text = entity.BrojPasosa;
                if (entity.DatumRodjenja.HasValue)
                    dtpDatumRodjenja.Value = entity.DatumRodjenja.Value;

                txtBrojObuce.Text = entity.Plesac.BrojObuce.ToString();
                txtBrojOdjece.Text = entity.Plesac.BrojOdjece.ToString();
                txtNazivSkole.Text = entity.Plesac.NazivSkole;

                chbAktivan.Checked = entity.Aktivan ?? false;

                foreach (Model.Grupe grupa in cmbGrupa.Items)
                {
                    if(grupa.GrupaId == entity.Plesac.GrupaId)
                    {
                        cmbGrupa.SelectedItem = grupa;
                    }
                }

                foreach (Model.Korisnici roditelj in cmbRoditelj.Items)
                {
                    if(roditelj.KorisnikId == entity.Plesac.RoditeljId)
                    {
                        cmbRoditelj.SelectedItem = roditelj;
                    }
                }
            }
        }

        private async void btnDodajRoditelja_Click(object sender, EventArgs e)
        {
            var frm = new frmRoditeljiDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await LoadRoditeljiCmb();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            int? RoditeljId = null;
            if (cmbRoditelj.SelectedIndex > 0)
            {
                RoditeljId = (cmbRoditelj.SelectedItem as Model.Korisnici).KorisnikId;
            }



            var request = new Model.Requests.KorisniciInsertRequest
            {
                Aktivan = chbAktivan.Checked,
                BrojPasosa = txtBrojPasosa.Text,
                DatumRodjenja = dtpDatumRodjenja.Value.Date,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Mail = txtMail.Text,
                Password = txtLozinka.Text,
                PasswordConfirmation = txtPotvrdaLozinke.Text,
                Username = txtKorisnickoIme.Text,
                Plesac = new Model.Plesaci()
                {
                    BrojObuce = int.Parse(txtBrojObuce.Text),
                    BrojOdjece = int.Parse(txtBrojOdjece.Text),
                    NazivSkole = txtNazivSkole.Text,
                    GrupaId = (cmbGrupa.SelectedItem as Model.Grupe).GrupaId,
                    RoditeljId = RoditeljId
                }
            };

            if(_korisnikId == 0)
            {
                var entity = await _serviceKorisnici.Insert<Model.Korisnici>(request);
                if (entity != null)
                {
                    MessageBox.Show("Plesač dodan.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceKorisnici.Update<Model.Korisnici>(_korisnikId, request);
                if (entity != null)
                {
                    MessageBox.Show("Plesač izmijenjen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            TextBox control = sender as TextBox;
            if(string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
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

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            TextBox control = sender as TextBox;
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(control.Text);
                    errorProvider1.SetError(control, null);
                }
                catch (Exception)
                {
                    errorProvider1.SetError(control, Properties.Resources.Validation_EmailInvalid);
                    e.Cancel = true;
                }

            }
        }

        private void txtBrojPasosa_Validating(object sender, CancelEventArgs e)
        {
            TextBox control = sender as TextBox;
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else
            {
                Regex expr = new Regex(@"[A-Z][0-9]{7}");
                if(expr.IsMatch(control.Text))
                {
                    errorProvider1.SetError(control, null);
                }
                else
                {
                    errorProvider1.SetError(control, Properties.Resources.Validation_PassportInvalid);
                    e.Cancel = true;
                }


            }
        }

        private void txtBrojOdjece_Validating(object sender, CancelEventArgs e)
        {
            TextBox control = sender as TextBox;
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                e.Cancel = true;
            }
            else if (!int.TryParse(control.Text, out int broj))
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_Number);
                e.Cancel = true;
            }
            else if (broj < 4 || broj > 44)
            {
                errorProvider1.SetError(control, "Unos mora biti u rasponu od 4 do 44.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private void cmbRoditelj_Validating(object sender, CancelEventArgs e)
        {
            ComboBox control = sender as ComboBox;
            if(control.SelectedIndex <= 0)
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
