using PlesnaSkola.WinUI.Helper;
using PlesnaSkola.Model;
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

namespace PlesnaSkola.WinUI.Clanovi
{
    public partial class frmPlesaciDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceGrupe = new APIService("Grupe");
        private APIService _servicePreporuka = new APIService("Preporuka");
        private int _korisnikId;
        private byte[] Slika = new byte[0];

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
            listGrupe.Insert(0, new Model.Grupe { NazivGrupe = "Odaberite" });
            cmbGrupa.DataSource = listGrupe;
            cmbGrupa.DisplayMember = "NazivGrupeIUzrast";
            cmbGrupa.ValueMember = "GrupaId";
        }

        private async Task LoadRoditeljiCmb()
        {
            var requestRoditelji = new Model.Requests.KorisniciSearchRequest
            {
                IncludeRoditelji = true
            };
            var listRoditelji = await _serviceKorisnici.Get<List<Model.Korisnici>>(requestRoditelji);
            listRoditelji.Insert(0, new Model.Korisnici { KorisnikId = 0, Ime = "Odaberite", Prezime = "" });

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

                foreach (Model.Grupe grupa in cmbGrupa.Items)
                {
                    if (grupa.GrupaId == entity.Plesac.GrupaId)
                    {
                        cmbGrupa.SelectedItem = grupa;
                    }
                }

                foreach (Model.Korisnici roditelj in cmbRoditelj.Items)
                {
                    if (roditelj.KorisnikId == entity.Plesac.RoditeljId)
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

            if(cmbGrupa.SelectedIndex <= 0)
            {
                MessageBox.Show("Greška", "Odabir grupe je obavezan.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                Slika = this.Slika,
                Plesac = new Model.Plesaci()
                {
                    BrojObuce = int.Parse(txtBrojObuce.Text),
                    BrojOdjece = int.Parse(txtBrojOdjece.Text),
                    NazivSkole = txtNazivSkole.Text,
                    GrupaId = (cmbGrupa.SelectedItem as Model.Grupe).GrupaId,
                    RoditeljId = RoditeljId
                }
            };

            if (_korisnikId == 0)
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

            var age = dtpDatumRodjenja.Value.GetAge();

            if (age >= 18)
            {
                errorProvider1.SetError(control, null);
                return;
            }

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

        private void txtBrojObuce_Validating(object sender, CancelEventArgs e)
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
            else if (broj < 20 || broj > 50)
            {
                errorProvider1.SetError(control, "Unos nije validan.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
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

        private async void dtpDatumRodjenja_ValueChanged(object sender, EventArgs e)
        {


            var request = new Model.Requests.PreporukaRequest
            {
                DatumRodjenja = dtpDatumRodjenja.Value.Date
            };

            var preporucena_grupa = await _servicePreporuka.Get<Model.Grupe>(request);
            if (preporucena_grupa != null)
            {
                lblGrupaNePostoji.Visible = false;

                foreach (Model.Grupe grupa in cmbGrupa.Items)
                {
                    if (grupa.GrupaId == preporucena_grupa.GrupaId)
                    {
                        cmbGrupa.SelectedItem = grupa;
                        break;
                    }
                }
            }
            else
            {
                cmbGrupa.SelectedIndex = 0;
                lblGrupaNePostoji.Visible = true;

            }
        }

        private void cmbGrupa_Validating(object sender, CancelEventArgs e)
        {
            ComboBox control = sender as ComboBox;

            var age = dtpDatumRodjenja.Value.GetAge();
            var uzrast_clana = Model.Grupe.GetUzrast(age);

            if (control.SelectedIndex <= 0)
            {
                if(lblGrupaNePostoji.Visible || uzrast_clana == null)
                {
                    errorProvider1.SetError(control, null);
                }
                else
                {
                    errorProvider1.SetError(control, Properties.Resources.Validation_Required);
                    e.Cancel = true;
                }
                return;
            }

            if (uzrast_clana != null)
            {
                var uzrast_grupe = (control.SelectedItem as Model.Grupe).GrupaUzrast;

                if (uzrast_clana != uzrast_grupe)
                {
                    errorProvider1.SetError(control, Properties.Resources.Validation_UzrastGrupe);
                    e.Cancel = true;
                    return;
                }
            }

            errorProvider1.SetError(control, null);
        }

        private void dtpDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as DateTimePicker;

            var age = control.Value.GetAge();
            var uzrast_clana = Model.Grupe.GetUzrast(age);

            if (uzrast_clana == null)
            {
                errorProvider1.SetError(control, Properties.Resources.Validation_UzrastClana);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, null);
            }
        }

        private async void btnDodajGrupu_Click(object sender, EventArgs e)
        {
            var frm = new Grupe.frmGrupeDetails();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                await LoadGrupeCmb();
                cmbGrupa.SelectedIndex = cmbGrupa.Items.Count - 1;
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
