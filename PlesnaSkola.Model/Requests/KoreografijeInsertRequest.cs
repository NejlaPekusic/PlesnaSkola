using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class KoreografijeInsertRequest
    {
        public string NazivKoreografije { get; set; }
        public Stil Stil { get; set; }
        public Muzika Muzika { get; set; }
        public int GrupaId { get; set; }
        public int AsistentId { get; set; }
    }
}
