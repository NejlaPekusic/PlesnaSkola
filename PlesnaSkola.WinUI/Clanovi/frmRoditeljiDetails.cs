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
        public frmRoditeljiDetails()
        {
            InitializeComponent();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var request = new Model.Requests.KorisniciInsertRequest
            {
                Aktivan = true,
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

            var entity = await _serviceKorisnici.Insert<Model.Korisnici>(request);
            if(entity != null)
            {
                MessageBox.Show("Roditelj dodan.");
                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Roditelj nije dodan.");
            }
        }
    }
}
