using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class KorisniciService: IKorisniciService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == id).FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Models.Korisnici>(request);
            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _context.Korisnici.Find(id);

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);
         
            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

    }
}
