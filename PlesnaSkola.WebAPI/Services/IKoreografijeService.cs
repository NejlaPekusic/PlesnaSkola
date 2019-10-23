using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IKoreografijeService
    {
        List<Model.Koreografije> Get(Model.Requests.KoreografijeSearchRequest request);
        Model.Koreografije Insert(Model.Requests.KoreografijeInsertRequest request);
        Model.Koreografije Update(int id, Model.Requests.KoreografijeInsertRequest request);
        Model.Koreografije GetById(int id);
    }
}
