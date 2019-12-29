using PlesnaSkola.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Zaposlenici
{
    public partial class frmTreneriDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private int _korisnikId;

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

            }
        }

    }
}
