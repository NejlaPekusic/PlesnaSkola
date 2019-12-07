using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Asistenti
    {
        public Asistenti()
        {
            Radionice = new HashSet<Radionice>();
        }
        
        [ForeignKey("Korisnik")]
        [Required]
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }

        public ICollection<Radionice> Radionice { get; set; }
    }
}
