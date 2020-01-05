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
    public class GrupeService : IGrupeService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        public GrupeService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Grupe> Get(GrupeSearchRequest request)
        {
            var query = _context.Grupe.AsQueryable();
            query = query.Include(x => x.Trener.Korisnik);

            if(!string.IsNullOrWhiteSpace(request.NazivGrupe))
            {
                query = query.Where(x => x.NazivGrupe.Contains(request.NazivGrupe));
            }
            
            if(request.Status == 1)
            {
                query = query.Where(x => x.Plesaci.Count() >= 4);
            }
            else if(request.Status == 2)
            {
                query = query.Where(x => x.Plesaci.Count() < 4);
            }

            var list = query.ToList();

            var model = _mapper.Map<List<Model.Grupe>>(list);
            foreach (var grupa in model)
            {
                grupa.BrojClanova = _context.Plesaci.Count(x => x.GrupaId == grupa.GrupaId);
            }

            return model;
        }

        public Model.Grupe GetById(int id)
        {
            var entity = _context.Grupe.Where(x => x.GrupaId == id).FirstOrDefault();
            var model = _mapper.Map<Model.Grupe>(entity);
            model.BrojClanova = _context.Plesaci.Count(x => x.GrupaId == id);
            return model;
        }

        public Model.Grupe Insert(GrupeInsertRequest request)
        {
            var entity = _mapper.Map<Models.Grupe>(request);
            _context.Grupe.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Grupe>(entity);
        }

        public Model.Grupe Update(int id, GrupeInsertRequest request)
        {
            var entity = _context.Grupe.Find(id);

            _context.Grupe.Attach(entity);
            _context.Grupe.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Grupe>(entity);
        }
    }
}
