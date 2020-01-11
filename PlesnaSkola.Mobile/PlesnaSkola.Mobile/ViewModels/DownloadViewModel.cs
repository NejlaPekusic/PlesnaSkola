using GalaSoft.MvvmLight.Command;
using PlesnaSkola.Mobile.Services;
using PlesnaSkola.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class DownloadViewModel : BaseViewModel
    {
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

        public void Init(Obavijesti obavijest)
        {
            StartDownloadCommand.Execute(obavijest);
        }

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

        public APIService _service = new APIService("Obavijesti");

        public DownloadViewModel(IDownloadService downloadService)
        {
            _downloadService = downloadService;
            StartDownloadCommand = new RelayCommand<Obavijesti>(async (obavijest) => await StartDownloadAsync(obavijest));
        }

        /// <summary>
        /// Starts the download async.
        /// </summary>
        /// <returns>The download async.</returns>
        public async Task StartDownloadAsync(Obavijesti obavijest)
        {
            var progressIndicator = new Progress<double>(ReportProgress);
            var cts = new CancellationTokenSource();
            try
            {
                IsDownloading = true;

                var url = _service.getApiURL() + "/Obavijesti/DownloadAttachment/" + obavijest.ObavijestId;

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
