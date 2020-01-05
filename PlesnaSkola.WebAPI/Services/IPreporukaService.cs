using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public interface IPreporukaService
    {
        Model.Grupe Get(Model.Requests.PreporukaRequest request);
    }
}
