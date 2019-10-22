using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IMuzikaService
    {
        List<Model.Muzika> Get(Model.Requests.MuzikaSearchRequest request);
        Model.Muzika Insert(Model.Requests.MuzikaInsertRequest request);
        Model.Muzika Update(int id, Model.Requests.MuzikaInsertRequest request);
        Model.Muzika GetById(int id);
    }
}
