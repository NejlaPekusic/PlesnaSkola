using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Pravdanja
    {
        [Key]
        public int PravdanjeId { get; set; }
        public string NazivSkole { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int VoditeljId { get; set; }

        public Voditelji Voditelj { get; set; }
    }
}
