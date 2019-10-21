using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Roditelji
    {
        public Roditelji()
        {
            Plesaci = new HashSet<Plesaci>();
        }

        [ForeignKey("Korisnik")]
        [Required]
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }

        public ICollection<Plesaci> Plesaci { get; set; }
    }
}
