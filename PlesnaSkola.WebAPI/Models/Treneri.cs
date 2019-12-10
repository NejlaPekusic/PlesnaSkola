using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Treneri
    {
        public Treneri()
        {
            Treninzi = new HashSet<Treninzi>();
        }

        [ForeignKey("Korisnik")]
        [Required]
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }
        public string Licenca { get; set; }
        public string Funkcija { get; set; }
        
        public ICollection<Treninzi> Treninzi { get; set; }
    }
}
