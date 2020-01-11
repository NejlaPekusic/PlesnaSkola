using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.Model
{
    public class Obavijesti
    {
        public int ObavijestId { get; set; }

        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Sazetak { get => Sadrzaj.Substring(0, 300) + "...";  }
        public byte[] Prilog { get; set; }
        public string PrilogFileName { get; set; }
        public bool PrilogPostoji { get => Prilog != null && Prilog.Length > 0 && !string.IsNullOrEmpty(PrilogFileName); }

        public int KorisnikId { get; set; }
        public Korisnici Korisnik { get; set; }

    }
}
