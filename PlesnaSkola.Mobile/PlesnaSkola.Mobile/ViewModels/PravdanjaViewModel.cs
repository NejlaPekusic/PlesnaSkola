using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class PravdanjaViewModel : BaseViewModel
    {
        private readonly APIService _servicePravdanja = new APIService("Pravdanja");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        #region bindable properties
        public ObservableCollection<Model.Pravdanja> PravdanjaList { get; set; } = new ObservableCollection<Model.Pravdanja>();
        public ObservableCollection<Model.Korisnici> DjecaList { get; set; } = new ObservableCollection<Model.Korisnici>();


        private bool _IsRoditelj = false;
        public bool IsRoditelj
        {
            get { return _IsRoditelj; }
            set { SetProperty(ref _IsRoditelj, value); }
        }

        private Model.Korisnici _odabranoDijete;

        public Model.Korisnici OdabranoDijete
        {
            get { return _odabranoDijete; }
            set { SetProperty(ref _odabranoDijete, value); }
        }

        private bool _switch_IsToggled;

        public bool Switch_IsToggled
        {
            get { return _switch_IsToggled; }
            set { SetProperty(ref _switch_IsToggled, value); }
        }


        #endregion

        public PravdanjaViewModel()
        {
            Title = "Pravdanja";
        }

        public async Task LoadData()
        {
            var list = await _servicePravdanja.Get<List<Model.Pravdanja>>(null);

            PravdanjaList.Clear();
            foreach (var item in list)
            {
                if ((Switch_IsToggled == true && item.DatumZahtjeva != null && item.DatumIzdavanja is null) ||
                    (Switch_IsToggled == false && item.DatumIzdavanja != null))
                {
                    PravdanjaList.Add(item);
                }

            }

            if(APIService.PrijavljeniKorisnik.Roditelj != null)
            {
                IsRoditelj = true;

                var request = new Model.Requests.KorisniciSearchRequest
                {
                    IncludeDjeca = true
                };

                var list1 = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
                DjecaList.Clear();
                foreach (var item in list1)
                {
                    DjecaList.Add(item);
                }
            }

        }
    }
}


