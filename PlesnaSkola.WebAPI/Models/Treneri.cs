using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Treneri
    {
        public Treneri()
        {
            Rasporedi = new HashSet<Rasporedi>();
            Treninzi = new HashSet<Treninzi>();
        }

        public int TrenerId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public string BrojPasosa { get; set; }
        public string Licenca { get; set; }
        public string Funkcija { get; set; }

        public ICollection<Rasporedi> Rasporedi { get; set; }
        public ICollection<Treninzi> Treninzi { get; set; }
    }
}
