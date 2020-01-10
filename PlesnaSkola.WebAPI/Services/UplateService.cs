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
    public class UplateService:IUplateService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;
        private readonly IKorisniciService _korisniciService;

        public UplateService(PlesnaSkolaContext context, IMapper mapper, IKorisniciService korisniciService)
        {
            _context = context;
            _mapper = mapper;
            _korisniciService = korisniciService;
        }

        public List<Model.Uplate> Get(UplateSearchRequest request)
        {
            var query = _context.Uplate.AsQueryable();

            if(request.IncludeClanovi)
            {
                query = query.Include(x => x.Plesac.Korisnik);
            }

            if(!string.IsNullOrWhiteSpace(request.ImePrezime))
            {
                query = query.Where(x =>
                    x.Plesac.Korisnik.Ime.Contains(request.ImePrezime)
                    || x.Plesac.Korisnik.Prezime.Contains(request.ImePrezime)
                    || (x.Plesac.Korisnik.Ime + " " + x.Plesac.Korisnik.Prezime).Contains(request.ImePrezime)
                    || (x.Plesac.Korisnik.Prezime + " " + x.Plesac.Korisnik.Ime).Contains(request.ImePrezime));
            }

            if (request.VrstaUplate == 1)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Članarina);
            }
            else if (request.VrstaUplate == 2)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Upisnina);
            }
            else if (request.VrstaUplate == 3)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Kostim);
            }
            else if (request.VrstaUplate == 4)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Kotizacija);
            }
            else if (request.VrstaUplate == 5)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Prevoz);
            }
            else if (request.VrstaUplate == 6)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Smještaj);
            }
            else if (request.VrstaUplate == 7)
            {
                query = query.Where(x => x.VrstaUplate == VrstaUplate.Ostalo);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Uplate>>(list);
        }

        public Model.Uplate GetById(int id)
        {
            var entity = _context.Uplate.Include(x => x.Plesac.Korisnik).Where(x => x.UplataId == id).FirstOrDefault();

            return _mapper.Map<Model.Uplate>(entity);
        }

        public Model.Uplate Insert(UplateInsertRequest request)
        {
            var entity = _mapper.Map<Models.Uplate>(request);
            entity.VoditeljId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;
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
