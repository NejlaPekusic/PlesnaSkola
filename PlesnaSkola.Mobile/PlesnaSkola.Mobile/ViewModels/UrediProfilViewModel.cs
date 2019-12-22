using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class UrediProfilViewModel: BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");


        private Model.Requests.KorisniciUpdateRequest _korisnik;

        public Model.Requests.KorisniciUpdateRequest Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        public ICommand SnimiProfilCommand { get; set; }


        public UrediProfilViewModel()
        {
            SnimiProfilCommand = new Command(async () => await SnimiProfil());
        }

        public async Task Init()
        {
            await UcitajProfil();

        }

        private async Task UcitajProfil()
        {
            if (Korisnik == null)
            {
                Korisnik = await _serviceKorisnici.Get<Model.Requests.KorisniciUpdateRequest>(null, "MyProfile");

                if (Korisnik.Slika.Length == 0)
                {
                    Korisnik.Slika = File.ReadAllBytes("xamarin_logo.png");
                }
                Title = "Uredi Profil - " + Korisnik.Username;
            }

        }

        private async Task SnimiProfil()
        {
            var entity = await _serviceKorisnici.Update<Model.Korisnici>(APIService.PrijavljeniKorisnik.KorisnikId, Korisnik);
            if (entity != null)
            {
                APIService.Username = Korisnik.Username;
                if (!string.IsNullOrWhiteSpace(Korisnik.Password))
                {
                    APIService.Password = Korisnik.Password;
                }
                await Application.Current.MainPage.DisplayAlert("", "Profil je uspješno izmijenjen.", "OK");
            }
        }


    }
}
