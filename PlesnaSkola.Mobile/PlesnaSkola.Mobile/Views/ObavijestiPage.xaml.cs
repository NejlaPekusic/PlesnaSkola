using PlesnaSkola.Mobile.ViewModels;
using PlesnaSkola.Model;
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
	public partial class ObavijestiPage : ContentPage
	{
        private readonly ObavijestiViewModel VM;

        public ObavijestiPage ()
		{
			InitializeComponent ();
            BindingContext = VM = new ObavijestiViewModel();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await VM.LoadData();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Obavijest = e.Item as Obavijesti;
            await Navigation.PushAsync(new ObavijestiDetailsPage(Obavijest.ObavijestId));
        }
    }
}