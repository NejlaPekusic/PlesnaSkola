using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace PlesnaSkola.Mobile.ViewModels
{
    public class ObavijestiViewModel : BaseViewModel
    {
        private readonly APIService _serviceObavijesti = new APIService("Obavijesti");

        public ObservableCollection<Model.Obavijesti> ObavijestiList { get; set; } = new ObservableCollection<Model.Obavijesti>();

        public ObavijestiViewModel()
        {
            Title = "Obavijesti";
        }

        public async Task LoadData()
        {
            var list = await _serviceObavijesti.Get<List<Model.Obavijesti>>(null);

            ObavijestiList.Clear();
            foreach (var item in list)
            {
                ObavijestiList.Add(item);
            }

        }
    }
}
