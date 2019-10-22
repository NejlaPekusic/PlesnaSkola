using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class ObavijestiService:IObavijestiService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public ObavijestiService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Obavijesti> Get(ObavijestiSearchRequest request)
        {
            var query = _context.Obavijesti.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Obavijesti>>(list);
        }

        public Model.Obavijesti GetById(int id)
        {
            var entity = _context.Obavijesti.Where(x => x.ObavijestId == id).FirstOrDefault();

            return _mapper.Map<Model.Obavijesti>(entity);
        }

        public Model.Obavijesti Insert(ObavijestiInsertRequest request)
        {
            var entity = _mapper.Map<Models.Obavijesti>(request);
            _context.Obavijesti.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Obavijesti>(entity);
        }

        public Model.Obavijesti Update(int id, ObavijestiInsertRequest request)
        {
            var entity = _context.Obavijesti.Find(id);

            _context.Obavijesti.Attach(entity);
            _context.Obavijesti.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Obavijesti>(entity);
        }
    }
}
