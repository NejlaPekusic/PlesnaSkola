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

namespace PlesnaSkola.WinUI.Treninzi
{
    public partial class frmTreningDetails : Form
    {
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceTreninzi = new APIService("Treninzi");
        private APIService _serviceGrupe = new APIService("Grupe");
        private int _treningId;

        public frmTreningDetails()
        {
            InitializeComponent();
        }

        public frmTreningDetails(int grupaId)
        {
            InitializeComponent();
            _treningId = grupaId;

            btnDodaj.Text = "Snimi";
        }

        private async void frmTreningDetails_Load(object sender, EventArgs e)
        {
            await LoadComboboxes();
            if (_treningId != 0)
            {
                await UcitajTrening();
            }
        }

        private async Task LoadComboboxes()
        {
            LoadSaleCmb();
            await LoadTreneriCmb();
            await LoadGrupeCmb();
            await LoadPlesaci();
        }

        private async Task LoadPlesaci()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                IncludePlesaci = true
            };
            var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);

            clbPrisustvo.DisplayMember = "ImePrezime";
            clbPrisustvo.DataSource = list;
        }

        private void LoadSaleCmb()
        {
            var list = Enum.GetValues(typeof(Sala));
            cmbSala.DataSource = list;
        }

        private async Task LoadGrupeCmb()
        {
            var list = await _serviceGrupe.Get<List<Model.Grupe>>(null);
            list.Insert(0, new Model.Grupe { GrupaId = 0, NazivGrupe = "" });

            cmbGrupa.DataSource = list;
            cmbGrupa.DisplayMember = "NazivGrupe";
            cmbGrupa.ValueMember = "GrupaId";
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

        private async Task UcitajTrening()
        {
            var entity = await _serviceTreninzi.GetById<Model.Treninzi>(_treningId);
            if (entity != null)
            {
                dtpDatum.Value = entity.DatumOdrzavanja;

                dtpSatnicaOd.Value = DateTime.Now.Date.Add(entity.SatnicaOd);
                dtpSatnicaDo.Value = DateTime.Now.Date.Add(entity.SatnicaDo);

                foreach (Model.Korisnici trener in cmbTrener.Items)
                {
                    if (trener.KorisnikId == entity.TrenerId)
                    {
                        cmbTrener.SelectedItem = trener;
                    }
                }
                foreach (Model.Grupe grupa in cmbGrupa.Items)
                {
                    if (grupa.GrupaId == entity.GrupaId)
                    {
                        cmbGrupa.SelectedItem = grupa;
                    }
                }
                foreach (Sala sala in cmbSala.Items)
                {
                    if (sala == entity.Sala)
                    {
                        cmbSala.SelectedItem = sala;
                    }
                }
                for (int i = 0; i < clbPrisustvo.Items.Count; i++)
                {
                    foreach (var prisustvo in entity.Prisustva)
                    {
                        if(prisustvo.PlesacId == (clbPrisustvo.Items[i] as Model.Korisnici).KorisnikId)
                        {
                            clbPrisustvo.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
        }

       
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var request = new Model.Requests.TreninziInsertRequest
            {
                GrupaId = (cmbGrupa.SelectedItem as Model.Grupe).GrupaId,
                TrenerId = (cmbTrener.SelectedItem as Model.Korisnici).KorisnikId,
                Sala = (Sala)cmbSala.SelectedItem,
                DatumOdrzavanja = dtpDatum.Value.Date,
                SatnicaDo = dtpSatnicaDo.Value.TimeOfDay,
                SatnicaOd = dtpSatnicaOd.Value.TimeOfDay,
                Prisustva = clbPrisustvo.CheckedItems.Cast<Model.Korisnici>().Select(x => new Prisustva
                {
                    PlesacId = x.KorisnikId
                }).ToList()
            };

            if (_treningId == 0)
            {
                var entity = await _serviceTreninzi.Insert<Model.Treninzi>(request);
                if (entity != null)
                {
                    MessageBox.Show("Trening dodan.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _serviceTreninzi.Update<Model.Treninzi>(_treningId, request);
                if (entity != null)
                {
                    MessageBox.Show("Trening izmijenjen.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
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

        private void cmbSala_Validating(object sender, CancelEventArgs e)
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
