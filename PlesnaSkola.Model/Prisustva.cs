using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.Model
{
    public class Prisustva
    {
        public int Id { get; set; }
        public int PlesacId { get; set; }
        public Plesaci Plesac { get; set; }
        public int TreningId { get; set; }
        public Treninzi Trening { get; set; }
    }
}
