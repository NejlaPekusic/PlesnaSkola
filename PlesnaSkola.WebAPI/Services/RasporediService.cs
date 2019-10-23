using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class RasporediService:IRasporediService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public RasporediService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Rasporedi> Get(RasporediSearchRequest request)
        {
            var query = _context.Rasporedi.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Rasporedi>>(list);
        }

        public Model.Rasporedi GetById(int id)
        {
            var entity = _context.Rasporedi.Where(x => x.RasporedId == id).FirstOrDefault();

            return _mapper.Map<Model.Rasporedi>(entity);
        }

        public Model.Rasporedi Insert(RasporediInsertRequest request)
        {
            var entity = _mapper.Map<Models.Rasporedi>(request);
            _context.Rasporedi.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Rasporedi>(entity);
        }

        public Model.Rasporedi Update(int id, RasporediInsertRequest request)
        {
            var entity = _context.Rasporedi.Find(id);

            _context.Rasporedi.Attach(entity);
            _context.Rasporedi.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Rasporedi>(entity);
        }
    }
}
