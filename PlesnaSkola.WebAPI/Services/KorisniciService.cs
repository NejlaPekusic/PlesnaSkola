using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlesnaSkola.Model.Requests;
using PlesnaSkola.WebAPI.Exceptions;
using PlesnaSkola.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly PlesnaSkolaContext _context;
        private readonly IMapper _mapper;

        private Model.Korisnici _prijavljeniKorisnik;

        public KorisniciService(PlesnaSkolaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Korisnici> Get(KorisniciSearchRequest request)
        {
            var query = _context.Korisnici.AsQueryable();

            if (request.IncludeDjeca)
            {
                query = query.Where(x => x.Plesac != null).Include(x => x.Plesac.Grupa);
                query = query.Where(x => x.Plesac.RoditeljId == _prijavljeniKorisnik.KorisnikId);
            }

            if (request.IncludeClanovi || request.IncludeUposlenici || request.IncludeRoditelji || request.IncludePlesaci || request.IncludeAsistenti || request.IncludeTreneri || request.IncludeVoditelji)
            {
                if (request.IncludeClanovi)
                    query = query.Where(x => x.Roditelj != null || x.Plesac != null);
                else if (request.IncludePlesaci)
                    query = query.Where(x => x.Plesac != null).Include(x => x.Plesac.Grupa);
                else if (request.IncludeAsistenti)
                    query = query.Where(x => x.Asistent != null);
                else if (request.IncludeUposlenici)
                    query = query.Where(x => x.Asistent != null || x.Trener != null || x.Voditelj != null);
                else if (request.IncludeRoditelji)
                    query = query.Where(x => x.Roditelj != null);
                else if (request.IncludeTreneri)
                    query = query.Where(x => x.Trener != null);
                else if (request.IncludeVoditelji)
                    query = query.Where(x => x.Voditelj != null);
            }

            if (request.GrupaId != 0)
            {
                query = query.Where(x => x.Plesac.GrupaId == request.GrupaId);
            }

            if (!string.IsNullOrEmpty(request.ImePrezime))
            {
                query = query.Where(x =>
                    x.Ime.Contains(request.ImePrezime)
                    || x.Prezime.Contains(request.ImePrezime)
                    || (x.Ime + " " + x.Prezime).Contains(request.ImePrezime)
                    || (x.Prezime + " " + x.Ime).Contains(request.ImePrezime));
            }

            query = query.Include(x => x.Asistent)
                .Include(x => x.Plesac)
                .Include(x => x.Voditelj)
                .Include(x => x.Roditelj)
                .Include(x => x.Trener);

            var list = query.ToList();

            return _mapper.Map<List<Model.Korisnici>>(list);
        }

        public Model.Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == id)
                .Include(x => x.Asistent)
                .Include(x => x.Plesac.Roditelj.Korisnik)
                .Include(x => x.Plesac.Grupa)
                .Include(x => x.Voditelj)
                .Include(x => x.Roditelj)
                .Include(x => x.Trener)
            .FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(entity);
        }
        public Model.Korisnici GetMyProfile()
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == _prijavljeniKorisnik.KorisnikId)
                .Include(x => x.Asistent)
                .Include(x => x.Plesac.Roditelj.Korisnik)
                .Include(x => x.Plesac.Grupa)
                .Include(x => x.Voditelj)
                .Include(x => x.Roditelj)
                .Include(x => x.Trener)
            .FirstOrDefault();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Insert(KorisniciInsertRequest request)
        {
            var entity = _mapper.Map<Models.Korisnici>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Lozinke se ne podudaraju");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public Model.Korisnici Update(int id, KorisniciUpdateRequest request)
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == id)
                .Include(x => x.Asistent)
                .Include(x => x.Plesac)
                .Include(x => x.Voditelj)
                .Include(x => x.Roditelj)
                .Include(x => x.Trener)
                .FirstOrDefault();

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new UserException("Lozinke se ne podudaraju");
                }

                entity.PasswordSalt = GenerateSalt();
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            //_mapper.Map(request, entity);

            entity.Ime = request.Ime;
            entity.Prezime = request.Prezime;
            entity.Username = request.Username;
            entity.Aktivan = request.Aktivan;
            entity.Mail = request.Mail;
            entity.BrojPasosa = request.BrojPasosa;
            entity.DatumRodjenja = request.DatumRodjenja;
            if (request.Slika?.Length > 0)
                entity.Slika = request.Slika;

            if (request.Plesac != null)
            {
                entity.Plesac.BrojObuce = request.Plesac.BrojObuce;
                entity.Plesac.BrojOdjece = request.Plesac.BrojOdjece;
                entity.Plesac.NazivSkole = request.Plesac.NazivSkole;
                entity.Plesac.GrupaId = request.Plesac.GrupaId;
                entity.Plesac.RoditeljId = request.Plesac.RoditeljId;
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Korisnici>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public Model.Korisnici Autentifikacija(string username, string pass)
        {
            var korisnik = _context.Korisnici
                .Include(x => x.Asistent)
                .Include(x => x.Trener)
                .Include(x => x.Voditelj)
                .Include(x => x.Plesac)
                .Include(x => x.Roditelj)
                .FirstOrDefault(x => x.Username == username);

            if (korisnik != null)
            {
                var newHash = GenerateHash(korisnik.PasswordSalt, pass);

                if (newHash == korisnik.PasswordHash)
                {
                    return _mapper.Map<Model.Korisnici>(korisnik);
                }
            }
            return null;
        }

        public void SetPrijavljeniKorisnik(Model.Korisnici korisnik)
        {
            _prijavljeniKorisnik = korisnik;
        }
        public Model.Korisnici GetPrijavljeniKorisnik()
        {
            return _prijavljeniKorisnik;
        }
    }
}
