using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Plesaci
    {
        public Plesaci()
        {
            Uplate = new HashSet<Uplate>();
        }

        public int PlesacId { get; set; }
        public int? BrojOdjece { get; set; }
        public int? BrojObuce { get; set; }
        public string NazivSkole { get; set; }
        public bool? Aktivan { get; set; }
        public int RoditeljId { get; set; }
        public int GrupaId { get; set; }

        public Grupe Grupa { get; set; }
        public Roditelji Roditelj { get; set; }
        public ICollection<Uplate> Uplate { get; set; }
    }
}
