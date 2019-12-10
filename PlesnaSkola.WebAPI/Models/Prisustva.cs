using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Models
{
    public class Prisustva
    {
        public int Id { get; set; }
        public int PlesacId { get; set; }
        public int TreningId { get; set; }
    }
}
