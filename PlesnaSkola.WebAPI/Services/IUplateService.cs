using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IUplateService
    {
        List<Model.Uplate> Get(Model.Requests.UplateSearchRequest request);
        Model.Uplate Insert(Model.Requests.UplateInsertRequest request);
        Model.Uplate Update(int id, Model.Requests.UplateInsertRequest request);
        Model.Uplate GetById(int id);
    }
}
