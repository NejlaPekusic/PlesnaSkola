using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class RadioniceService:IRadioniceService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public RadioniceService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Radionice> Get(RadioniceSearchRequest request)
        {
            var query = _context.Radionice.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Radionice>>(list);
        }

        public Model.Radionice GetById(int id)
        {
            var entity = _context.Radionice.Where(x => x.RadionicaId == id).FirstOrDefault();

            return _mapper.Map<Model.Radionice>(entity);
        }

        public Model.Radionice Insert(RadioniceInsertRequest request)
        {
            var entity = _mapper.Map<Models.Radionice>(request);
            _context.Radionice.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Radionice>(entity);
        }

        public Model.Radionice Update(int id, RadioniceInsertRequest request)
        {
            var entity = _context.Radionice.Find(id);

            _context.Radionice.Attach(entity);
            _context.Radionice.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Radionice>(entity);
        }
    }
}
