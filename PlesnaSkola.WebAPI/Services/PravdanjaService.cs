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
    public class PravdanjaService : IPravdanjaService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;
        private readonly IKorisniciService _korisniciService;

        public PravdanjaService(PlesnaSkolaContext context, IMapper mapper, IKorisniciService korisniciService)
        {
            _context = context;
            _mapper = mapper;
            _korisniciService = korisniciService;
        }

        public List<Model.Pravdanja> Get(PravdanjaSearchRequest request)
        {
            var query = _context.Pravdanja.AsQueryable();

            if (_korisniciService.GetPrijavljeniKorisnik().Voditelj != null)
            {
                if (request.Filter == 0)
                {
                    query = query.Where(x => x.DatumZahtjeva != null && x.DatumIzdavanja == null);
                }
                else if (request.Filter == 1)
                {
                    query = query.Where(x => x.DatumIzdavanja != null);
                }
            }

            if (_korisniciService.GetPrijavljeniKorisnik().Roditelj != null)
            {
                int RoditeljId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;

                query = query.Where(x => x.Plesaci.Any(y => y.Plesac.RoditeljId.Value == RoditeljId));
            }

            if (_korisniciService.GetPrijavljeniKorisnik().Plesac != null)
            {
                int PlesacId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;

                query = query.Where(x => x.Plesaci.Any(y => y.PlesacId == PlesacId));
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Pravdanja>>(list);
        }

        public Model.Pravdanja GetById(int id)
        {
            var entity = _context.Pravdanja.Where(x => x.PravdanjeId == id).Include(x => x.Plesaci).FirstOrDefault();

            return _mapper.Map<Model.Pravdanja>(entity);
        }

        public Model.Pravdanja Insert(PravdanjaInsertRequest request)
        {
            var entity = _mapper.Map<Models.Pravdanja>(request);
            if (_korisniciService.GetPrijavljeniKorisnik().Voditelj != null)
            {
                entity.VoditeljId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;
                entity.DatumIzdavanja = DateTime.Now;
            }
            else if(_korisniciService.GetPrijavljeniKorisnik().Roditelj != null || _korisniciService.GetPrijavljeniKorisnik().Plesac != null)
            {
                entity.DatumZahtjeva = DateTime.Now;
            }
            _context.Pravdanja.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Pravdanja>(entity);
        }

        public Model.Pravdanja Update(int id, PravdanjaInsertRequest request)
        {
            var entity = _context.Pravdanja.Find(id);

            if(entity.DatumIzdavanja is null)
            {
                entity.DatumIzdavanja = DateTime.Now;
                entity.VoditeljId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;
            }

            var listToDelete = _context.PravdanjaPlesaci.Where(x => x.PravdanjeId == id).ToList();
            foreach (var item in listToDelete)
            {
                _context.PravdanjaPlesaci.Remove(item);
            }

            _context.Pravdanja.Attach(entity);
            _context.Pravdanja.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Pravdanja>(entity);
        }
    }
}
