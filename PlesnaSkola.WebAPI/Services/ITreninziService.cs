using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface ITreninziService
    {
        List<Model.Treninzi> Get(Model.Requests.TreninziSearchRequest request);
        Model.Treninzi Insert(Model.Requests.TreninziInsertRequest request);
        Model.Treninzi Update(int id, Model.Requests.TreninziInsertRequest request);
        Model.Treninzi GetById(int id);
    }
}
