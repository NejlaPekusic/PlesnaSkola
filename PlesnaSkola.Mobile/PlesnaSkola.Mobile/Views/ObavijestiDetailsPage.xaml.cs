using PlesnaSkola.Mobile.Services;
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
	public partial class ObavijestiDetailsPage : ContentPage
	{
        private readonly ObavijestiDetailsViewModel VM;

        public ObavijestiDetailsPage(int ObavijestId, IDownloadService downloadService)
        {
            InitializeComponent();
            BindingContext = VM = new ObavijestiDetailsViewModel(ObavijestId, downloadService);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await VM.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}