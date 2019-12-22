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

        public ProfilPage ()
		{
			InitializeComponent ();
            BindingContext = VM = new ProfilViewModel();
		}

        private async void UrediProfilToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UrediProfilPage());
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }
    }
}