using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Plesaci
    {
        public int Id { get; set; }
        [Required]
        public int BrojOdjece { get; set; }
        [Required]
        public int BrojObuce { get; set; }
        public string NazivSkole { get; set; }
        public int? RoditeljId { get; set; }
        [Required]
        public int GrupaId { get; set; }

        public Grupe Grupa { get; set; }
        public Roditelji Roditelj { get; set; }
    }
}
