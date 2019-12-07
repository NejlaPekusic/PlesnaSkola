using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Uplate
    {
        [Key]
        public int UplataId { get; set; }
        public double IznosUplate { get; set; }
        public DateTime DatumUplate { get; set; }
        public int VoditeljId { get; set; }
        public int PlesacId { get; set; }
        public VrstaUplate VrstaUplate { get; set; }
        public string Opis { get; set; }

        public Plesaci Plesac { get; set; }
        public Voditelji Voditelj { get; set; }
    }

    public enum VrstaUplate
    {
        Članarina, Upisnina, Kostim, Kotizacija, Prevoz, Smještaj, Ostalo
    }
}
