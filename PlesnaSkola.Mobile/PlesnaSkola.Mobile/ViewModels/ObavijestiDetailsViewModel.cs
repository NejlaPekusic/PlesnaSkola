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

        public ObavijestiDetailsViewModel(int ObavijestId)
        {
            _obavijestId = ObavijestId;
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

                Title = Obavijest.Naslov;

            }

        }


    }
}
