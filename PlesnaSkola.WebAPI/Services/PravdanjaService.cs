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
    public class PravdanjaService:IPravdanjaService
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

            var list = query.ToList();

            return _mapper.Map<List<Model.Pravdanja>>(list);
        }

        public Model.Pravdanja GetById(int id)
        {
            var entity = _context.Pravdanja.Where(x => x.PravdanjeId == id).Include(x=>x.Plesaci).FirstOrDefault();

            return _mapper.Map<Model.Pravdanja>(entity);
        }

        public Model.Pravdanja Insert(PravdanjaInsertRequest request)
        {
            var entity = _mapper.Map<Models.Pravdanja>(request);
            entity.VoditeljId = _korisniciService.GetPrijavljeniKorisnik().KorisnikId;
            entity.DatumIzdavanja = DateTime.Now;
            _context.Pravdanja.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Pravdanja>(entity);
        }

        public Model.Pravdanja Update(int id, PravdanjaInsertRequest request)
        {
            var entity = _context.Pravdanja.Find(id);

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
