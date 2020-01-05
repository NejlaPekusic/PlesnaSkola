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
    public partial class ProfilPage : ContentPage
    {
        private readonly ProfilViewModel VM;

        public ProfilPage(int KorisnikId = 0)
        {
            InitializeComponent();
            BindingContext = VM = new ProfilViewModel(KorisnikId);

            if (KorisnikId == 0)
            {
                UrediProfilToolbarItem.Icon = ImageSource.FromFile("edit.png") as FileImageSource;
            }
            else
            {
                UrediProfilToolbarItem.Icon = null;
            }
        }

        private async void UrediProfilToolbarItem_Clicked(object sender, EventArgs e)
        {
            if (VM.Korisnik?.KorisnikId == APIService.PrijavljeniKorisnik.KorisnikId)
                await Navigation.PushAsync(new UrediProfilPage());
            else
                await DisplayAlert("Greška", "Izmjene nisu dozvoljene.", "OK");
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                Model.Korisnici korisnik = e.Item as Model.Korisnici;
                await Navigation.PushAsync(new ProfilPage(korisnik.KorisnikId));
            }
        }
    }
}