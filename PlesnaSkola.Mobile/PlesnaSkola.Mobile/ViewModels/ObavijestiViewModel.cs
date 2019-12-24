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

        public ObservableCollection<Model.Pravdanja> PravdanjaList { get; set; } = new ObservableCollection<Model.Pravdanja>();

        public PravdanjaViewModel()
        {
            Title = "Pravdanja";
        }

        public async Task LoadData(bool PrikaziZahtjeve = false)
        {
            var list = await _servicePravdanja.Get<List<Model.Pravdanja>>(null);

            PravdanjaList.Clear();
            foreach (var item in list)
            {
                if((PrikaziZahtjeve == true && item.DatumZahtjeva != null && item.DatumIzdavanja is null) ||
                    (PrikaziZahtjeve == false && item.DatumIzdavanja != null))
                {
                    PravdanjaList.Add(item);
                }
                
            }

        }
    }
}
