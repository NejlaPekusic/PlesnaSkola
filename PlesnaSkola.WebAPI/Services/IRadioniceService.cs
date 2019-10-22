using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IRadioniceService
    {
        List<Model.Radionice> Get(Model.Requests.RadioniceSearchRequest request);
        Model.Radionice Insert(Model.Requests.RadioniceInsertRequest request);
        Model.Radionice Update(int id, Model.Requests.RadioniceInsertRequest request);
        Model.Radionice GetById(int id);
    }
}
