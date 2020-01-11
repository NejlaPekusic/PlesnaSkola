using GalaSoft.MvvmLight.Ioc;
using PlesnaSkola.Mobile.Services;
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
	public partial class DownloadPage : ContentPage
	{
        private readonly DownloadViewModel VM;
        private readonly Obavijesti obavijest;

        public DownloadPage(Obavijesti obavijest)
        {
            InitializeComponent();
            this.BindingContext = VM = SimpleIoc.Default.GetInstance<DownloadViewModel>();
            this.obavijest = obavijest;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            VM.Init(obavijest);

            Navigation.PopAsync();
        }
   
    }
}