using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Treninzi
    {
        public Treninzi()
        {
            Prisustva = new List<Prisustva>();
        }

        [Key]
        public int TreningId { get; set; }
        public TimeSpan SatnicaOd { get; set; }
        public TimeSpan SatnicaDo { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public Sala Sala { get; set; }
        public int TrenerId { get; set; }
        public int GrupaId { get; set; }

        public Grupe Grupa { get; set; }
        public Treneri Trener { get; set; }

        public IEnumerable<Prisustva> Prisustva { get; set; }
    }

    public enum Sala { Sala_1, Sala_2, Sala_3 }

}
