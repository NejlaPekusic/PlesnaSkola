using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Models
{
    public class Korisnici
    {
        [Key]
        public int KorisnikId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public bool? Aktivan { get; set; }
        public string BrojPasosa { get; set; }

        public Asistenti Asistent { get; set; }
        public Roditelji Roditelj { get; set; }
        public Plesaci Plesac { get; set; }
        public Treneri Trener { get; set; }
        public Voditelji Voditelj { get; set; }
        public byte[] Slika { get; set; }

    }
}
