using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IGrupeService
    {
        List<Model.Grupe> Get(Model.Requests.GrupeSearchRequest request);
        Model.Grupe Insert(Model.Requests.GrupeInsertRequest request);
        Model.Grupe Update(int id, Model.Requests.GrupeInsertRequest request);
        Model.Grupe GetById(int id);
    }
}
