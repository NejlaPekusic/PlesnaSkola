using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Asistenti
    {
        public Asistenti()
        {
            Muzika = new HashSet<Muzika>();
            Radionice = new HashSet<Radionice>();
        }

        public int AsistentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public bool? Aktivan { get; set; }
        public string Mail { get; set; }

        public ICollection<Muzika> Muzika { get; set; }
        public ICollection<Radionice> Radionice { get; set; }
    }
}
