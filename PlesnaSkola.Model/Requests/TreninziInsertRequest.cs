using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class TreninziInsertRequest
    {
        public TimeSpan SatnicaOd { get; set; }
        public TimeSpan SatnicaDo { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public Sala Sala { get; set; }
        public int TrenerId { get; set; }
        public int GrupaId { get; set; }

        public List<Prisustva> Prisustva { get; set; }
    }
}
