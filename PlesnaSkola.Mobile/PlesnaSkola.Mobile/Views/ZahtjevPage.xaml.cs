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
	public partial class ZahtjevPage : ContentPage
	{
        private readonly ZahtjevViewModel VM;

        public ZahtjevPage(int KorisnikId)
        {
            InitializeComponent();
            BindingContext = VM = new ZahtjevViewModel(KorisnikId);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await VM.UcitajKorisnika();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool uspjeh = await VM.SnimiZahtjev();
            if (uspjeh)
            {
                await Navigation.PopAsync();
            }
        }
    }
}