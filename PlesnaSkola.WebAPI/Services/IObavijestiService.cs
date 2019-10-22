using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IObavijestiService
    {
        List<Model.Obavijesti> Get(Model.Requests.ObavijestiSearchRequest request);
        Model.Obavijesti Insert(Model.Requests.ObavijestiInsertRequest request);
        Model.Obavijesti Update(int id, Model.Requests.ObavijestiInsertRequest request);
        Model.Obavijesti GetById(int id);
    }
}
