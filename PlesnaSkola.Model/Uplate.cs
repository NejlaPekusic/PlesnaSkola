using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Uplate
    {
        public int UplataId { get; set; }
        public double IznosUplate { get; set; }
        public string IznosUplateText { get => IznosUplate.ToString("0.00 KM"); }
        public DateTime DatumUplate { get; set; }
        public int VoditeljId { get; set; }
        public int PlesacId { get; set; }
        public string Opis { get; set; }
        public VrstaUplate VrstaUplate { get; set; }
        public string ImePlesaca { get; set; }

        public Plesaci Plesac { get; set; }
        public Voditelji Voditelj { get; set; }

        public string VrstaUplateText { get
            {
                if (VrstaUplate == VrstaUplate.Ostalo)
                    return Opis;
                return VrstaUplate.ToString();
            }
        }
    }
    public enum VrstaUplate
    {
        Članarina, Upisnina, Kostim, Kotizacija, Prevoz, Smještaj, Ostalo
    }
}
