using PlesnaSkola.Mobile.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlesnaSkola.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UrediProfilPage : ContentPage
	{
		public UrediProfilPage ()
		{
			InitializeComponent ();
            BindingContext = VM = new UrediProfilViewModel();

        }

        private async void Uslikaj_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":(No Camera available.)", "OK");
                return;
            }
            else
            {
                _mediaFile = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "myImage.jpg",
                    PhotoSize = PhotoSize.MaxWidthHeight
                });

                if (_mediaFile == null) return;

                Stream stream1 = _mediaFile.GetStream();
                Stream stream2 = _mediaFile.GetStream();
                byte[] resizedImage1 = null;
                byte[] resizedImage2 = null;

                resizedImage1 = ResizeImage(stream1);
                resizedImage2 = ResizeImage(stream2);

                imageView.Source = ImageSource.FromStream(() => new MemoryStream(resizedImage1));
                VM.Korisnik.Slika = resizedImage2;

            }
        }

        private async void OdaberiSliku_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("", "Greška", "OK");
                return;
            }
            else
            {
                var mediaOption = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.MaxWidthHeight
                };
                _mediaFile = await CrossMedia.Current.PickPhotoAsync();
                if (_mediaFile == null) return;

                Stream stream1 = _mediaFile.GetStream();
                Stream stream2 = _mediaFile.GetStream();
                byte[] resizedImage1 = null;
                byte[] resizedImage2 = null;

                resizedImage1 = ResizeImage(stream1);
                resizedImage2 = ResizeImage(stream2);

                imageView.Source = ImageSource.FromStream(() => new MemoryStream(resizedImage1));
                VM.Korisnik.Slika = resizedImage2;
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await VM.Init();
        }

        private MediaFile _mediaFile;
        private readonly UrediProfilViewModel VM;

        protected byte[] ResizeImage(Stream stream)
        {
            byte[] resizedImage = null;
            using (MemoryStream ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                resizedImage = ms.ToArray();
            }

            return resizedImage;

        }
    }
}