using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class UplateService:IUplateService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public UplateService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Uplate> Get(UplateSearchRequest request)
        {
            var query = _context.Uplate.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Uplate>>(list);
        }

        public Model.Uplate GetById(int id)
        {
            var entity = _context.Uplate.Where(x => x.UplataId == id).FirstOrDefault();

            return _mapper.Map<Model.Uplate>(entity);
        }

        public Model.Uplate Insert(UplateInsertRequest request)
        {
            var entity = _mapper.Map<Models.Uplate>(request);
            _context.Uplate.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Uplate>(entity);
        }

        public Model.Uplate Update(int id, UplateInsertRequest request)
        {
            var entity = _context.Uplate.Find(id);

            _context.Uplate.Attach(entity);
            _context.Uplate.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Uplate>(entity);
        }
    }
}
