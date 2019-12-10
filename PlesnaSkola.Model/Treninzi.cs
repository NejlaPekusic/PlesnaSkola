using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Treninzi
    {
        public int TreningId { get; set; }
        public TimeSpan SatnicaOd { get; set; }
        public TimeSpan SatnicaDo { get; set; }
        public string Satnica => SatnicaOd.ToString(@"hh\:mm") + " - " + SatnicaDo.ToString(@"hh\:mm");
        public DateTime DatumOdrzavanja { get; set; }
        public Sala Sala { get; set; }
        public string ImeSale => Sala.ToString().Replace("_", " ");
        public int TrenerId { get; set; }
        public int GrupaId { get; set; }

        public Grupe Grupa { get; set; }
        public Treneri Trener { get; set; }

        public List<Prisustva> Prisustva { get; set; }

    }

    public enum Sala { Sala_1, Sala_2, Sala_3}
}
