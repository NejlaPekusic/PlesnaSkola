using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class ZahtjevViewModel : BaseViewModel
    {
        private readonly APIService _servicePravdanja = new APIService("Pravdanja");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");

        #region bindable properties

        private readonly int _korisnikId;
        private Model.Korisnici _korisnik;
        public Model.Korisnici Korisnik
        {
            get { return _korisnik; }
            set { SetProperty(ref _korisnik, value); }
        }

        private DateTime _datumOd = DateTime.Now;
        public DateTime DatumOd
        {
            get { return _datumOd; }
            set { SetProperty(ref _datumOd, value); }
        }

        private DateTime _datumDo = DateTime.Now;
        public DateTime DatumDo
        {
            get { return _datumDo; }
            set { SetProperty(ref _datumDo, value); }
        }

        private string _opis;

        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        #endregion

        public ZahtjevViewModel(int KorisnikId)
        {
            Title = "Zahtjev za pravdanje";
            _korisnikId = KorisnikId;
        }

        public async Task<bool> SnimiZahtjev()
        {
            if (!ValidirajFormu())
                return false;

            var zahtjev = new Model.Requests.PravdanjaInsertRequest
            {
                DatumOd = _datumOd,
                DatumDo = _datumDo,
                Opis = _opis,
                Plesaci = new List<Model.PravdanjaPlesaci>
                {
                    new Model.PravdanjaPlesaci
                    {
                        PlesacId = _korisnikId
                    }
                }
            };

            var entity = await _servicePravdanja.Insert<Model.Pravdanja>(zahtjev);
            if (entity != null)
            {
                await Application.Current.MainPage.DisplayAlert("", "Zahtjev je uspješno poslan.", "OK");
                return true;
            }

            await Application.Current.MainPage.DisplayAlert("", "Došlo je do greške.", "OK");
            return false;
        }

        private bool ValidirajFormu()
        {
            if (string.IsNullOrWhiteSpace(Opis))
            {
                Application.Current.MainPage.DisplayAlert("", "Svrha je obavezna.", "OK");
                return false;
            }
            if (DatumOd < DateTime.Now.Date.AddDays(-30) || DatumDo < DateTime.Now.Date.AddDays(-30))
            {
                Application.Current.MainPage.DisplayAlert("", "Datum važenja ne može biti više od 30 dana u prošlosti.", "OK");
                return false;
            }
            if (DatumOd > DatumDo)
            {
                Application.Current.MainPage.DisplayAlert("", "Početak važenja mora biti prije kraja važenja.", "OK");
                return false;
            }
            return true;
        }

        public async Task UcitajKorisnika()
        {
            Korisnik = await _serviceKorisnici.GetById<Model.Korisnici>(_korisnikId);
        }
    }
}


