using PlesnaSkola.WinUI.Helper;
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

namespace PlesnaSkola.WinUI.Zaposlenici
{
    public partial class frmVoditeljiDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private int _korisnikId;
        private byte[] Slika = new byte[0];

        public frmVoditeljiDetails()
        {
            InitializeComponent();
        }

        public frmVoditeljiDetails(int korisnikId)
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
                Slika = this.Slika,
                PasswordConfirmation = txtPotvrdaLozinke.Text,
                Username = txtKorisnickoIme.Text,
                Voditelj = new Model.Voditelji()
                {
                    Telefon=txtTelefon.Text
                }
            };


            if (_korisnikId == 0)
            {
                var entity = await _serviceKorisnici.Insert<Model.Korisnici>(request);
                if (entity != null)
                {
                    MessageBox.Show("Voditelj dodan.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceKorisnici.Update<Model.Korisnici>(_korisnikId, request);
                if (entity != null)
                {
                    MessageBox.Show("Voditelj izmijenjen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private async void frmVoditeljiDetails_Load(object sender, EventArgs e)
        {
            if (_korisnikId != 0)
            {
                await UcitajVoditelja();
            }
        }

        private async Task UcitajVoditelja()
        {
            var entity = await _serviceKorisnici.GetById<Model.Korisnici>(_korisnikId);
            if (entity != null)
            {
                txtIme.Text = entity.Ime;
                txtPrezime.Text = entity.Prezime;
                txtKorisnickoIme.Text = entity.Username;
                txtMail.Text = entity.Mail;
                txtBrojPasosa.Text = entity.BrojPasosa;
                txtTelefon.Text = entity.Voditelj.Telefon;
                if (entity.DatumRodjenja.HasValue)
                    dtpDatumRodjenja.Value = entity.DatumRodjenja.Value;

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
    }
}
