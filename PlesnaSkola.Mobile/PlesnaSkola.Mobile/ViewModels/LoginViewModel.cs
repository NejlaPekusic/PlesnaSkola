using PlesnaSkola.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class LoginViewModel: BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            Title = "Login";
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                APIService.PrijavljeniKorisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");

                if (APIService.PrijavljeniKorisnik.Plesac == null && APIService.PrijavljeniKorisnik.Roditelj == null)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Nemate pravo pristupa ovoj aplikaciji.", "OK");
                    return;
                }
                
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception)
            {

            }
        }



        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


    }
}
