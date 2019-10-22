using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class PravdanjaService:IPravdanjaService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public PravdanjaService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Pravdanja> Get(PravdanjaSearchRequest request)
        {
            var query = _context.Pravdanja.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Pravdanja>>(list);
        }

        public Model.Pravdanja GetById(int id)
        {
            var entity = _context.Pravdanja.Where(x => x.PravdanjeId == id).FirstOrDefault();

            return _mapper.Map<Model.Pravdanja>(entity);
        }

        public Model.Pravdanja Insert(PravdanjaInsertRequest request)
        {
            var entity = _mapper.Map<Models.Pravdanja>(request);
            _context.Pravdanja.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Pravdanja>(entity);
        }

        public Model.Pravdanja Update(int id, PravdanjaInsertRequest request)
        {
            var entity = _context.Pravdanja.Find(id);

            _context.Pravdanja.Attach(entity);
            _context.Pravdanja.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Pravdanja>(entity);
        }
    }
}
