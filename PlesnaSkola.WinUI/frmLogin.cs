using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlesnaSkola.WinUI
{
    public partial class frmLogin : Form
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Text = "nejla";
            txtLozinka.Text = "123";
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUsername.Text;
            APIService.Password = txtLozinka.Text;
            try
            {
                APIService.PrijavljeniKorisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");
                if (APIService.PrijavljeniKorisnik.Asistent == null && APIService.PrijavljeniKorisnik.Voditelj == null && APIService.PrijavljeniKorisnik.Trener == null)
                {
                    MessageBox.Show("Greška", "Nemate pravo pristupa ovoj aplikaciji.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

            }
            catch (Exception)
            {
                
            }
        }
    }
}
