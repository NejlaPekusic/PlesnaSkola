using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IRasporediService
    {
        List<Model.Rasporedi> Get(Model.Requests.RasporediSearchRequest request);
        Model.Rasporedi Insert(Model.Requests.RasporediInsertRequest request);
        Model.Rasporedi Update(int id, Model.Requests.RasporediInsertRequest request);
        Model.Rasporedi GetById(int id);
    }
}
