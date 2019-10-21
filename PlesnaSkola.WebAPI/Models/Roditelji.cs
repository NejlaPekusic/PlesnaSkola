using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Roditelji
    {
        public Roditelji()
        {
            Plesaci = new HashSet<Plesaci>();
        }

        public int RoditeljId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }

        public ICollection<Plesaci> Plesaci { get; set; }
    }
}
