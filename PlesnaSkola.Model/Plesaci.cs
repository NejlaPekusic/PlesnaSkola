using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Plesaci
    {
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }
        public int? BrojOdjece { get; set; }
        public int? BrojObuce { get; set; }
        public string NazivSkole { get; set; }
        public bool? Aktivan { get; set; }
        public int RoditeljId { get; set; }
        public int GrupaId { get; set; }

        public Grupe Grupa { get; set; }
        public Roditelji Roditelj { get; set; }
    }
}
