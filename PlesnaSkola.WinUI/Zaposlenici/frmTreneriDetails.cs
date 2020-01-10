using PlesnaSkola.Model;
using PlesnaSkola.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Zaposlenici
{
    public partial class frmTreneriDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private int _korisnikId;
        private byte[] Slika = new byte[0];


        public frmTreneriDetails()
        {
            InitializeComponent();
        }

        public frmTreneriDetails(int korisnikId)
        {
            InitializeComponent();
            _korisnikId = korisnikId;

            chbAktivan.Visible = true;
            btnDodaj.Text = "Snimi";
        }
        private void LoadComboboxes()
        {
            LoadFunkcijaCmb();
            
        }

        private void LoadFunkcijaCmb()
        {
            var list = Enum.GetValues(typeof(Funkcija));
            cmbFunkcija.DataSource = list;
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var request = new Model.Requests.KorisniciInsertRequest
            {
                Aktivan = chbAktivan.Checked,
                BrojPasosa = txtBrojPasosa.Text,
                DatumRodjenja = dtpDatumRodjenja.Value.Date,
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Mail = txtMail.Text,
                Slika = this.Slika,
                Password = txtLozinka.Text,
                PasswordConfirmation = txtPotvrdaLozinke.Text,
                Username = txtKorisnickoIme.Text,
                Trener = new Model.Treneri()
                {
                    Funkcija= (Funkcija)cmbFunkcija.SelectedItem,
                    Licenca=txtLicenca.Text
                }

            };

            if (_korisnikId == 0)
            {
                var entity = await _serviceKorisnici.Insert<Model.Korisnici>(request);
                if (entity != null)
                {
                    MessageBox.Show("Trener dodan.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceKorisnici.Update<Model.Korisnici>(_korisnikId, request);
                if (entity != null)
                {
                    MessageBox.Show("Trener izmijenjen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private async void frmTreneriDetails_Load(object sender, EventArgs e)
        {
            LoadComboboxes();

            if (_korisnikId != 0)
            {
                await UcitajTrenera();
            }
            
            
        }

        private async Task UcitajTrenera()
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

                chbAktivan.Checked = entity.Aktivan ?? false;
                txtLicenca.Text = entity.Trener.Licenca;

                foreach (Funkcija funkcija in cmbFunkcija.Items)
                {
                    if (funkcija == entity.Trener.Funkcija)
                    {
                        cmbFunkcija.SelectedItem = funkcija;
                    }
                }

                this.Slika = entity.Slika;
                if (this.Slika.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(entity.Slika);
                    pbSlika.Image = Image.FromStream(ms);
                }
                else
                {
                    MemoryStream ms = new MemoryStream(SlikaHelper.getDefaultSlika());
                    pbSlika.Image = Image.FromStream(ms);
                }

            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                Slika = File.ReadAllBytes(fileName);
                var stream = new MemoryStream(Slika);
                pbSlika.Image = Image.FromStream(stream);

            }
        }
        private void txtIme_Validating(object sender, CancelEventArgs e)
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
                if (expr.IsMatch(control.Text))
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

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            int minimumLength = 2;
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider1.SetError(txtKorisnickoIme, Properties.Resources.Validation_Required);
            }
            else if (txtKorisnickoIme.Text.Length < minimumLength)
            {
                errorProvider1.SetError(txtKorisnickoIme, "Korisničko ime mora sadržavati minimalno " + minimumLength + " karaktera.");
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
                return;
            }
            e.Cancel = true;
        }

        private void txtLozinka_Validating(object sender, CancelEventArgs e)
        {
            int minimumLength = 3;

            if (_korisnikId == 0 && string.IsNullOrEmpty(txtLozinka.Text))
            {
                errorProvider1.SetError(txtLozinka, Properties.Resources.Validation_Required);
            }
            else if ((_korisnikId == 0 || !string.IsNullOrEmpty(txtLozinka.Text)) && txtLozinka.Text.Length < minimumLength)
            {
                errorProvider1.SetError(txtLozinka, "Lozinka mora sadržavati minimalno " + minimumLength + " karaktera.");
            }
            else
            {
                errorProvider1.SetError(txtLozinka, null);
                return;
            }
            e.Cancel = true;
        }

        private void txtPotvrdaLozinke_Validating(object sender, CancelEventArgs e)
        {
            if ((_korisnikId == 0 || !string.IsNullOrEmpty(txtLozinka.Text)) && string.IsNullOrEmpty(txtPotvrdaLozinke.Text))
            {
                errorProvider1.SetError(txtPotvrdaLozinke, Properties.Resources.Validation_Required);
            }
            else if ((_korisnikId == 0 || !string.IsNullOrEmpty(txtLozinka.Text)) && txtLozinka.Text != txtPotvrdaLozinke.Text)
            {
                errorProvider1.SetError(txtPotvrdaLozinke, Properties.Resources.Validation_Password);
            }
            else
            {
                errorProvider1.SetError(txtPotvrdaLozinke, null);
                return;
            }
            e.Cancel = true;
        }
    }
}
