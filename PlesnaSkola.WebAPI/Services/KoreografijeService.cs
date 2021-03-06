﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
        private readonly IKorisniciService _korisniciService;

        public KoreografijeService(PlesnaSkolaContext context, IMapper mapper, IKorisniciService korisniciService)
        {
            _context = context;
            _mapper = mapper;
            _korisniciService = korisniciService;
        }

        public List<Model.Koreografije> Get(KoreografijeSearchRequest request)
        {
            var query = _context.Koreografije.AsQueryable();
            if (!string.IsNullOrEmpty(request.NazivKoreografije))
            {
                query = query.Where(x => x.NazivKoreografije.Contains(request.NazivKoreografije));
            }

            if (request.Stil == 1)
            {
                query = query.Where(x => x.Stil == Stil.Jazz);
            }
            else if (request.Stil == 2)
            {
                query = query.Where(x => x.Stil == Stil.Show);
            }
            else if (request.Stil == 3)
            {
                query = query.Where(x => x.Stil == Stil.Acro);
            }
            else if (request.Stil == 4)
            {
                query = query.Where(x => x.Stil == Stil.Contemporary);
            }
            else if (request.Stil == 5)
            {
                query = query.Where(x => x.Stil == Stil.Lyrical);
            }
            else if (request.Stil == 6)
            {
                query = query.Where(x => x.Stil == Stil.Street);
            }
            else if (request.Stil == 7)
            {
                query = query.Where(x => x.Stil == Stil.HipHop);
            }
            else if (request.Stil == 8)
            {
                query = query.Where(x => x.Stil == Stil.Freestyle);
            }
            else if (request.Stil == 9)
            {
                query = query.Where(x => x.Stil == Stil.Open);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Koreografije>>(list);
        }

        public Model.Koreografije GetById(int id)
        {
            var entity = _context.Koreografije.Where(x => x.KoreografijaId == id).Include(x=>x.Muzika).FirstOrDefault();

            return _mapper.Map<Model.Koreografije>(entity);
        }

        public Model.Koreografije Insert(KoreografijeInsertRequest request)
        {
            var entity = _mapper.Map<Models.Koreografije>(request);
            entity.VoditeljId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;
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
