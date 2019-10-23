using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Grupe
    {
        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public int BrojClanova { get; set; }
    }
}
