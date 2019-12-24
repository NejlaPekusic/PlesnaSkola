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

namespace PlesnaSkola.WinUI.Pravdanja
{
    public partial class frmPravdanjeDetails : Form
    {
        private APIService _servicePravdanja = new APIService("Pravdanja");
        private APIService _serviceKorisnici = new APIService("Korisnici");
        private APIService _serviceGrupe = new APIService("Grupe");
        private int _PravdanjeId;

        public frmPravdanjeDetails()
        {
            InitializeComponent();
        }

        public frmPravdanjeDetails(int grupaId)
        {
            InitializeComponent();
            _PravdanjeId = grupaId;

            btnDodaj.Text = "Izdaj";
        }

        private async void frmPravdanjeDetails_Load(object sender, EventArgs e)
        {
            await LoadComboboxes();
            if (_PravdanjeId != 0)
            {
                await UcitajPravdanje();
            }
        }

        private async Task LoadComboboxes()
        {
            await LoadPlesaci();
        }

        private async Task LoadPlesaci()
        {
            var request = new Model.Requests.KorisniciSearchRequest
            {
                IncludePlesaci = true
            };
            var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);

            List<Model.Grupe> grupe = list.Select(x => x.Plesac.Grupa).GroupBy(x=> new { x.GrupaId }).Select(x=>x.First()).ToList();

            foreach (var grupa in grupe)
            {
                TreeNode nodeGrupa = trvPlesaci.Nodes.Add(grupa.NazivGrupe);
                nodeGrupa.Tag = grupa;

                foreach (var plesac in list)
                {
                    if(plesac.Plesac.GrupaId == grupa.GrupaId)
                    {
                        TreeNode nodePlesac = nodeGrupa.Nodes.Add(plesac.ImePrezime);
                        nodePlesac.Tag = plesac;
                    }
                }
            }
        }

        private async Task UcitajPravdanje()
        {
            var entity = await _servicePravdanja.GetById<Model.Pravdanja>(_PravdanjeId);
            if (entity != null)
            {
                dtpDo.Value = entity.DatumDo.Date;
                dtpOd.Value = entity.DatumOd.Date;
                txtOpis.Text = entity.Opis;

                foreach (TreeNode groupNode in trvPlesaci.Nodes)
                {
                    int totalNodes = groupNode.Nodes.Count;
                    int checkedNodes = 0;
                    foreach (TreeNode plesacNode in groupNode.Nodes)
                    {
                        foreach (var plesac in entity.Plesaci)
                        {
                            if(plesac.PlesacId == (plesacNode.Tag as Model.Korisnici).Plesac.Id)
                            {
                                plesacNode.Checked = true;
                                checkedNodes++;
                            }
                        }
                    }

                    if (totalNodes != 0 && totalNodes == checkedNodes)
                        groupNode.Checked = true;
                }

            }
        }

       
        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            List<PravdanjaPlesaci> plesaci = new List<PravdanjaPlesaci>();
            foreach (TreeNode groupNode in trvPlesaci.Nodes)
            {
                foreach (TreeNode plesacNode in groupNode.Nodes)
                {
                    if (plesacNode.Checked)
                    {
                        plesaci.Add(new PravdanjaPlesaci
                        {
                            PlesacId = (plesacNode.Tag as Korisnici).Plesac.Id
                        });
                    }
                }
            }

            var request = new Model.Requests.PravdanjaInsertRequest
            {
                DatumDo = dtpDo.Value.Date,
                DatumOd = dtpOd.Value.Date,
                Opis = txtOpis.Text,
                Plesaci = plesaci
            };

            if (_PravdanjeId == 0)
            {
                var entity = await _servicePravdanja.Insert<Model.Pravdanja>(request);
                if (entity != null)
                {
                    MessageBox.Show("Pravdanje dodano.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                var entity = await _servicePravdanja.Update<Model.Pravdanja>(_PravdanjeId, request);
                if (entity != null)
                {
                    MessageBox.Show("Pravdanje izmijenjeno.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void trvPlesaci_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Tag is Model.Grupe)
            {
                foreach (TreeNode plesacNode in e.Node.Nodes)
                {
                    plesacNode.Checked = e.Node.Checked;
                }
            }
        }

        
    }
}
