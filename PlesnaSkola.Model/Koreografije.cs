using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Koreografije
    {
        public int KoreografijaId { get; set; }
        public string NazivKoreografije { get; set; }
        public Stil Stil { get; set; }
        public int VoditeljId { get; set; }
        public Voditelji Voditelj { get; set; }
        public int MuzikaId { get; set; }
        public Muzika Muzika { get; set; }
        public int GrupaId { get; set; }
        public Grupe Grupa { get; set; }
        public int AsistentId { get; set; }
        public Asistenti Asistent { get; set; }
    }

    public enum Stil
    {
        Jazz, Show, Acro, Contemporary, Lyrical, Street, HipHop, Freestyle, Open 
    }
}
