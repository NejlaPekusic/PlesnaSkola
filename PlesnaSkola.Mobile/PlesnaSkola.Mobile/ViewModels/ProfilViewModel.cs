using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlesnaSkola.Mobile.ViewModels
{
    class ProfilViewModel : BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        #region bindable properties

        private readonly int _korisnikId;
        private Model.Korisnici _korisnik;
        public Model.Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        public ObservableCollection<Model.Korisnici> DjecaList { get; set; } = new ObservableCollection<Model.Korisnici>();

        private bool _IsPlesac = false;
        public bool IsPlesac
        {
            get { return _IsPlesac; }
            set { SetProperty(ref _IsPlesac, value); }
        }

        private bool _IsRoditelj = false;
        public bool IsRoditelj
        {
            get { return _IsRoditelj; }
            set { SetProperty(ref _IsRoditelj, value); }
        }

        #endregion

        public ProfilViewModel(int korisnikId)
        {
            this._korisnikId = korisnikId;
        }

        public async Task Init()
        {
            await UcitajKorisnika();
        }

        private async Task UcitajKorisnika()
        {
            if (_korisnikId == 0)
                Korisnik = await _serviceKorisnici.Get<Model.Korisnici>(null, "MyProfile");
            else
                Korisnik = await _serviceKorisnici.GetById<Model.Korisnici>(_korisnikId);

            if (Korisnik.Slika.Length == 0)
            {
                Korisnik.Slika = File.ReadAllBytes("xamarin_logo.png");
            }

            if (Korisnik.Plesac != null)
                IsPlesac = true;
            if (Korisnik.Roditelj != null)
            {
                IsRoditelj = true;

                var request = new Model.Requests.KorisniciSearchRequest
                {
                    IncludeDjeca = true
                };

                var list = await _serviceKorisnici.Get<List<Model.Korisnici>>(request);
                DjecaList.Clear();
                foreach (var item in list)
                {
                    DjecaList.Add(item);
                }
            }
            
            Title = "Korisnički profil - " + Korisnik.Username;
        }




    }
}
