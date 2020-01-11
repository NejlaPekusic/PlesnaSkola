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
    public class ObavijestiService:IObavijestiService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;
        private readonly IKorisniciService _korisniciService;

        public ObavijestiService(PlesnaSkolaContext context, IMapper mapper, IKorisniciService korisniciService)
        {
            _context = context;
            _mapper = mapper;
            _korisniciService = korisniciService;
        }

        public List<Model.Obavijesti> Get(ObavijestiSearchRequest request)
        {
            var query = _context.Obavijesti.AsQueryable();

            query = query.Include(x => x.Korisnik);

            if(!string.IsNullOrEmpty(request.Naslov))
            {
                query = query.Where(x => x.Naslov.Contains(request.Naslov));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Obavijesti>>(list);
        }

        public Model.Obavijesti GetById(int id)
        {
            var entity = _context.Obavijesti.Where(x => x.ObavijestId == id).Include(x=>x.Korisnik).FirstOrDefault();

            return _mapper.Map<Model.Obavijesti>(entity);
        }

        public Model.Obavijesti Insert(ObavijestiInsertRequest request)
        {
            var entity = _mapper.Map<Models.Obavijesti>(request);
            entity.KorisnikId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;
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
