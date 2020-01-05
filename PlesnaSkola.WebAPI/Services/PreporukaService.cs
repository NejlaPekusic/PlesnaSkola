using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlesnaSkola.Model;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class PreporukaService : IPreporukaService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public PreporukaService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Grupe Get(PreporukaRequest request)
        {
            var age = request.DatumRodjenja.GetAge();

            var grupaUzrast = Model.Grupe.GetUzrast(age);
            if (grupaUzrast == null)
                return null;

            int uzrast_clana = (int)grupaUzrast.Value;

            var odgovarajuce_grupe = _context.Grupe.Where(x => (int)x.GrupaUzrast == uzrast_clana).Include("Plesaci.Korisnik").ToList();

            var nova_grupa = odgovarajuce_grupe.OrderBy(
                    x => x.Plesaci.Count() *
                         x.Plesaci.Average(
                            y => (DateTime.Now - y.Korisnik.DatumRegistracije).TotalDays
                         )
                    ).FirstOrDefault();

            return _mapper.Map<Model.Grupe>(nova_grupa);
        }



    
    }
}
