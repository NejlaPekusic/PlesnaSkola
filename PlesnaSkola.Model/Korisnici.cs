using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get => Ime + " " + Prezime;  }
        public string Username { get; set; }
        public string Mail { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string DatumRodjenjaPrikaz { get => DatumRodjenja.HasValue ? DatumRodjenja.Value.ToShortDateString() : "N/A"; }
        public bool? Aktivan { get; set; }
        public string BrojPasosa { get; set; }

        public Asistenti Asistent { get; set; }
        public Roditelji Roditelj { get; set; }
        public Plesaci Plesac { get; set; }
        public Treneri Trener { get; set; }
        public Voditelji Voditelj { get; set; }

        public byte[] Slika { get; set; }

        public override string ToString()
        {
            return ImePrezime;
        }


        public string Uloga { get
            {
                if (Asistent != null)
                    return "Asistent";
                if (Trener != null)
                    return "Trener";
                if (Voditelj != null)
                    return "Voditelj";
                if (Plesac != null)
                    return "Plesač";
                if (Roditelj != null)
                    return "Roditelj";
                return "Nepoznato";
            }

        }
    }
}
