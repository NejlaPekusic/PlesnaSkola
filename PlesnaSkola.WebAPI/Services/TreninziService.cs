using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class TreninziService:ITreninziService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public TreninziService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Treninzi> Get(TreninziSearchRequest request)
        {
            var query = _context.Treninzi.AsQueryable();
            query = query.Include(x => x.Grupa).Include(x => x.Trener.Korisnik);

            if(request.GrupaId != 0)
            {
                query = query.Where(x => x.GrupaId == request.GrupaId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Treninzi>>(list);
        }

        public Model.Treninzi GetById(int id)
        {
            var entity = _context.Treninzi.Where(x => x.TreningId == id).Include(x=>x.Prisustva).FirstOrDefault();

            return _mapper.Map<Model.Treninzi>(entity);
        }

        public Model.Treninzi Insert(TreninziInsertRequest request)
        {
            var entity = _mapper.Map<Models.Treninzi>(request);
            _context.Treninzi.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Treninzi>(entity);
        }

        public Model.Treninzi Update(int id, TreninziInsertRequest request)
        {
            var entity = _context.Treninzi.Find(id);

            var listToDelete = _context.Prisustva.Where(x => x.TreningId == id).ToList();
            foreach (var item in listToDelete)
            {
                _context.Prisustva.Remove(item);
            }

            _context.Treninzi.Attach(entity);
            _context.Treninzi.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Treninzi>(entity);
        }
    }
}
