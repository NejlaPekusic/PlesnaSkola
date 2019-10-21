using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Rasporedi
    {
        public Rasporedi()
        {
            Radionice = new HashSet<Radionice>();
        }

        [Key]
        public int RasporedId { get; set; }
        public string NazivRasporeda { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public int TrenerId { get; set; }

        public Treneri Trener { get; set; }
        public ICollection<Radionice> Radionice { get; set; }
    }
}
