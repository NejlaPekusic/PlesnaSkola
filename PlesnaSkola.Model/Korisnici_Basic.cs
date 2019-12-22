using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model
{
    public class Korisnici_Basic
    {

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

        public string ImePrezime { get => Ime + " " + Prezime;  }
    }
}
