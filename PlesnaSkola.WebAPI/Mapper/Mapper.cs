using AutoMapper;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Asistenti, Model.Asistenti>();
            CreateMap<Grupe, Model.Grupe>();
            CreateMap<Koreografije, Model.Koreografije>();
            CreateMap<Korisnici, Model.Korisnici>();
            CreateMap<Muzika, Model.Muzika>();
            CreateMap<Obavijesti, Model.Obavijesti>();
            CreateMap<Plesaci, Model.Plesaci>();
            CreateMap<Pravdanja, Model.Pravdanja>();
            CreateMap<Radionice, Model.Radionice>();
            CreateMap<Rasporedi, Model.Rasporedi>();
            CreateMap<Roditelji, Model.Roditelji>();
            CreateMap<Treneri, Model.Treneri>();
            CreateMap<Treninzi, Model.Treninzi>();
            CreateMap<Uplate, Model.Uplate>();
            CreateMap<Voditelji, Model.Voditelji>();

            CreateMap<Korisnici, Model.Requests.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Korisnici, Model.Requests.KorisniciUpdateRequest>().ReverseMap();
        }
    }
}
