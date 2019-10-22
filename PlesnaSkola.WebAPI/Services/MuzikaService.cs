using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class MuzikaService:IMuzikaService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public MuzikaService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Muzika> Get(MuzikaSearchRequest request)
        {
            var query = _context.Muzika.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Muzika>>(list);
        }

        public Model.Muzika GetById(int id)
        {
            var entity = _context.Muzika.Where(x => x.MuzikaId == id).FirstOrDefault();

            return _mapper.Map<Model.Muzika>(entity);
        }

        public Model.Muzika Insert(MuzikaInsertRequest request)
        {
            var entity = _mapper.Map<Models.Muzika>(request);
            _context.Muzika.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Muzika>(entity);
        }

        public Model.Muzika Update(int id, MuzikaInsertRequest request)
        {
            var entity = _context.Muzika.Find(id);

            _context.Muzika.Attach(entity);
            _context.Muzika.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Muzika>(entity);
        }
    }
}
