using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Koreografije
    {
        public Koreografije()
        {
            Muzika = new HashSet<Muzika>();
        }

        public int KoreografijaId { get; set; }
        public string NazivKoreografije { get; set; }
        public int VoditeljId { get; set; }

        public Voditelji Voditelj { get; set; }
        public ICollection<Muzika> Muzika { get; set; }
    }
}
