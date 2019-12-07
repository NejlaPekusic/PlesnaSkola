using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Grupe
    {
        public Grupe()
        {
            Koreografije = new HashSet<Koreografije>();
            Plesaci = new HashSet<Plesaci>();
            Treninzi = new HashSet<Treninzi>();
        }
        [Key]

        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public int TrenerId { get; set; }
        public Treneri Trener { get; set; }
        public ICollection<Koreografije> Koreografije { get; set; }
        public ICollection<Plesaci> Plesaci { get; set; }
        public ICollection<Treninzi> Treninzi { get; set; }
    }
}
