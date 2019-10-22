using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IPravdanjaService
    {
        List<Model.Pravdanja> Get(Model.Requests.PravdanjaSearchRequest request);
        Model.Pravdanja Insert(Model.Requests.PravdanjaInsertRequest request);
        Model.Pravdanja Update(int id, Model.Requests.PravdanjaInsertRequest request);
        Model.Pravdanja GetById(int id);
    }
}
