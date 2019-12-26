using PlesnaSkola.Model;
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

namespace PlesnaSkola.WinUI.Koreografije
{
    public partial class frmKoreografijeDetails : Form
    {
        private APIService _serviceKoreografije = new APIService("Koreografije");
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceGrupe = new APIService("Grupe");
        private int _koreografijaId;

        private byte[] Pjesma;

        public frmKoreografijeDetails()
        {
            InitializeComponent();
        }

        public frmKoreografijeDetails(int koreografijaId)
        {
            InitializeComponent();
            _koreografijaId = koreografijaId;

            btnDodaj.Text = "Snimi";
        }

        private async void frmKoreografijeDetails_Load(object sender, EventArgs e)
        {
            await LoadComboboxes();
            if (_koreografijaId != 0)
            {
                await UcitajKoreografiju();
            }
        }

        private async Task LoadComboboxes()
        {
            LoadStilCmb();

            await LoadGrupeCmb();
            await LoadAsistentiCmb();
        }

        private void LoadStilCmb()
        {
            cmbStil.DataSource = Enum.GetValues(typeof(Stil));
        }
        private async Task LoadAsistentiCmb()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                IncludeAsistenti = true
            };
            var listAsistenti = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
            listAsistenti.Insert(0, new Korisnici { KorisnikId = 0, Ime = "Odaberite" });
            cmbAsistenti.DataSource = listAsistenti;
            cmbAsistenti.DisplayMember = "ImePrezime";
            cmbAsistenti.ValueMember = "KorisnikId";
        }


        private async Task LoadGrupeCmb()
        {
            var listGrupe = await _serviceGrupe.Get<List<Model.Grupe>>(null);
            listGrupe.Insert(0, new Model.Grupe { GrupaId = 0, NazivGrupe = "Odaberite" });

            cmbGrupa.DataSource = listGrupe;
            cmbGrupa.DisplayMember = "NazivGrupe";
            cmbGrupa.ValueMember = "GrupaId";
        }

        private async Task UcitajKoreografiju()
        {
            var entity = await _serviceKoreografije.GetById<Model.Koreografije>(_koreografijaId);
            if (entity != null)
            {
                txtNaziv.Text = entity.NazivKoreografije;
                txtNazivPjesme.Text = entity.Muzika.NazivPjesme;

                dtpTrajanje.Value = DateTime.Now.Date.Add(entity.Muzika.Trajanje);

                Pjesma = entity.Muzika.Pjesma;

                foreach (Model.Grupe grupa in cmbGrupa.Items)
                {
                    if (grupa.GrupaId == entity.GrupaId)
                    {
                        cmbGrupa.SelectedItem = grupa;
                    }
                }

                foreach (Model.Korisnici korisnik in cmbAsistenti.Items)
                {
                    if (korisnik.KorisnikId == entity.AsistentId)
                    {
                        cmbAsistenti.SelectedItem = korisnik;
                    }
                }

                foreach (Stil stil in cmbStil.Items)
                {
                    if (stil == entity.Stil)
                    {
                        cmbStil.SelectedItem = stil;
                    }
                }

            }
        }


        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var request = new Model.Requests.KoreografijeInsertRequest
            {
                NazivKoreografije = txtNaziv.Text,
                Stil = (Stil)cmbStil.SelectedItem,
                AsistentId = (cmbAsistenti.SelectedItem as Model.Korisnici).KorisnikId,
                GrupaId = (cmbGrupa.SelectedItem as Model.Grupe).GrupaId,
                Muzika = new Muzika
                {
                    NazivPjesme = txtNazivPjesme.Text,
                    Pjesma = Pjesma,
                    Trajanje = dtpTrajanje.Value.TimeOfDay
                }
            };

            if (_koreografijaId == 0)
            {
                var entity = await _serviceKoreografije.Insert<Model.Koreografije>(request);
                if (entity != null)
                {
                    MessageBox.Show("Koreografija dodana.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceKoreografije.Update<Model.Koreografije>(_koreografijaId, request);
                if (entity != null)
                {
                    MessageBox.Show("Koreografija izmijenjena.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                lblFileName.Text = Path.GetFileName(fileName);

                Pjesma = File.ReadAllBytes(fileName);

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

        private void cmbStil_Validating(object sender, CancelEventArgs e)
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

        private void cmbGrupa_Validating(object sender, CancelEventArgs e)
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

        private void cmbAsistenti_Validating(object sender, CancelEventArgs e)
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

        private void txtNazivPjesme_Validating(object sender, CancelEventArgs e)
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

        //private void dtpTrajanje_Validating(object sender, CancelEventArgs e)
        //{

        //}
    }
}
