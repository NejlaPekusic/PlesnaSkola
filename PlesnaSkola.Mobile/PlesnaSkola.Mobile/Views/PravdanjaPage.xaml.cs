using PlesnaSkola.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlesnaSkola.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PravdanjaPage : ContentPage
    {
        private readonly PravdanjaViewModel VM;

        public PravdanjaPage()
        {
            InitializeComponent();
            BindingContext = VM = new PravdanjaViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await VM.LoadData();
        }

        private async void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            await VM.LoadData();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (APIService.PrijavljeniKorisnik.Plesac != null)
                await Navigation.PushAsync(new ZahtjevPage(APIService.PrijavljeniKorisnik.KorisnikId));
            else if (APIService.PrijavljeniKorisnik.Roditelj != null)
            {
                Model.Korisnici OdabranoDijete = VM.OdabranoDijete;
                if(OdabranoDijete == null)
                {
                    await DisplayAlert("Greška", "Dijete nije odabrano.", "OK");
                    return;
                }
                
                await Navigation.PushAsync(new ZahtjevPage(OdabranoDijete.KorisnikId));
            }
        }
    }
}