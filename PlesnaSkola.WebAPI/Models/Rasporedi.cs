using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Rasporedi
    {
        public Rasporedi()
        {
            Radionice = new HashSet<Radionice>();
        }

        public int RasporedId { get; set; }
        public string NazivRasporeda { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public int TrenerId { get; set; }

        public Treneri Trener { get; set; }
        public ICollection<Radionice> Radionice { get; set; }
    }
}
