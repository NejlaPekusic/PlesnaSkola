using PlesnaSkola.Mobile.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class ObavijestiDetailsViewModel : BaseViewModel
    {
        private readonly APIService _serviceObavijesti = new APIService("Obavijesti");
        private readonly int _obavijestId;
        private Model.Obavijesti _obavijest;

        public Model.Obavijesti Obavijest
        {
            get { return _obavijest; }
            set { SetProperty(ref _obavijest, value); }
        }



        public ObavijestiDetailsViewModel(int ObavijestId, IDownloadService downloadService)
        {
            _obavijestId = ObavijestId;

            _downloadService = downloadService;
            StartDownloadCommand = new Command(async () => await StartDownloadAsync());
        }

        public async Task Init()
        {
            await UcitajObavijest();
        }

        private async Task UcitajObavijest()
        {
            if (Obavijest == null)
            {
                Obavijest = await _serviceObavijesti.GetById<Model.Obavijesti>(_obavijestId);

                //if (Obavijest.Slika.Length == 0)
                //{
                //    Obavijest.Slika = File.ReadAllBytes("xamarin_logo.png");
                //}
                //if (Obavijest.Plesac != null)
                //    IsPlesac = true;

                Title = Obavijest.Naslov;

            }

        }

        private double _progressValue;
        /// <summary>
        /// Gets or sets the progress value.
        /// </summary>
        /// <value>The progress value.</value>
        public double ProgressValue
        {
            get { return _progressValue; }
            set { SetProperty(ref _progressValue, value); }
        }

        private bool _isDownloading;
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:XFDownloadProject.ViewModels.DownloadViewModel"/>
        /// is downloading.
        /// </summary>
        /// <value><c>true</c> if is downloading; otherwise, <c>false</c>.</value>
        public bool IsDownloading
        {
            get { return _isDownloading; }
            set { SetProperty(ref _isDownloading, value); }
        }

        /// <summary>
        /// The download service.
        /// </summary>
        private readonly IDownloadService _downloadService;

        /// <summary>
        /// Gets the start download command.
        /// </summary>
        /// <value>The start download command.</value>
        public ICommand StartDownloadCommand { get; }


        /// <summary>
        /// Starts the download async.
        /// </summary>
        /// <returns>The download async.</returns>
        public async Task StartDownloadAsync()
        {
            var progressIndicator = new Progress<double>(ReportProgress);
            var cts = new CancellationTokenSource();
            try
            {
                IsDownloading = true;

                var url = "https://github.com/damienaicheh/XamarinAndroidParcelable/archive/master.zip";

                await _downloadService.DownloadFileAsync(url, progressIndicator, cts.Token);
            }
            catch (OperationCanceledException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                //Manage cancellation here
            }
            finally
            {
                IsDownloading = false;
            }
        }

        /// <summary>
        /// Reports the progress status for the downlaod.
        /// </summary>
        /// <param name="value">Value.</param>
        internal void ReportProgress(double value)
        {
            ProgressValue = value;
        }

    }
}
