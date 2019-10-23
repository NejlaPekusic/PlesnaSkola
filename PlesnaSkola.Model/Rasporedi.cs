using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Rasporedi
    {
        public int RasporedId { get; set; }
        public string NazivRasporeda { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public int TrenerId { get; set; }

        public Treneri Trener { get; set; }
    }
}
