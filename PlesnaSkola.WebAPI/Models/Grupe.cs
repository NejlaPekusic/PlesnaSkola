using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Grupe
    {
        public Grupe()
        {
            Muzika = new HashSet<Muzika>();
            Plesaci = new HashSet<Plesaci>();
            Treninzi = new HashSet<Treninzi>();
        }

        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public int BrojClanova { get; set; }

        public ICollection<Muzika> Muzika { get; set; }
        public ICollection<Plesaci> Plesaci { get; set; }
        public ICollection<Treninzi> Treninzi { get; set; }
    }
}
