using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI.Clanovi
{
    public partial class frmRoditeljiDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private int _korisnikId;

        public frmRoditeljiDetails()
        {
            InitializeComponent();
        }

        public frmRoditeljiDetails(int korisnikId)
        {
            InitializeComponent();
            _korisnikId = korisnikId;

            chbAktivan.Visible = true;
            btnDodaj.Text = "Snimi";
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
                Roditelj = new Model.Roditelji()
            };


            if (_korisnikId == 0)
            {
                var entity = await _serviceKorisnici.Insert<Model.Korisnici>(request);
                if (entity != null)
                {
                    MessageBox.Show("Roditelj dodan.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceKorisnici.Update<Model.Korisnici>(_korisnikId, request);
                if (entity != null)
                {
                    MessageBox.Show("Roditelj izmijenjen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private async void frmRoditeljiDetails_Load(object sender, EventArgs e)
        {
            if (_korisnikId != 0)
            {
                await UcitajRoditelja();
            }
        }

        private async Task UcitajRoditelja()
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

            }
        }
    }
}
