using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlesnaSkola.Mobile.ViewModels
{
    class ProfilViewModel: BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        private Model.Korisnici _korisnik;
        public Model.Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        public ProfilViewModel()
        {
        }

        public async Task Init()
        {
            await UcitajKorisnika();
        }

        private async Task UcitajKorisnika()
        {
            Korisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");
            if (Korisnik.Slika.Length == 0)
            {
                Korisnik.Slika = File.ReadAllBytes("xamarin_logo.png");
            }

            Title = "Korisnički profil - " + Korisnik.Username;
        }

     
        

    }
}
