using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(Model.Requests.KorisniciSearchRequest request);
        Model.Korisnici Insert(Model.Requests.KorisniciInsertRequest request);
        Model.Korisnici Update(int id, Model.Requests.KorisniciUpdateRequest request);
        Model.Korisnici GetById(int id);
    }
}
