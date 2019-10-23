using AutoMapper;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class KoreografijeService:IKoreografijeService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public KoreografijeService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Koreografije> Get(KoreografijeSearchRequest request)
        {
            var query = _context.Koreografije.AsQueryable();

            var list = query.ToList();

            return _mapper.Map<List<Model.Koreografije>>(list);
        }

        public Model.Koreografije GetById(int id)
        {
            var entity = _context.Koreografije.Where(x => x.KoreografijaId == id).FirstOrDefault();

            return _mapper.Map<Model.Koreografije>(entity);
        }

        public Model.Koreografije Insert(KoreografijeInsertRequest request)
        {
            var entity = _mapper.Map<Models.Koreografije>(request);
            _context.Koreografije.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Koreografije>(entity);
        }

        public Model.Koreografije Update(int id, KoreografijeInsertRequest request)
        {
            var entity = _context.Koreografije.Find(id);

            _context.Koreografije.Attach(entity);
            _context.Koreografije.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Koreografije>(entity);
        }
    }
}
