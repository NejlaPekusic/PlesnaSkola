using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class KoreografijeInsertRequest
    {
        public string NazivKoreografije { get; set; }
        public int VoditeljId { get; set; }
    }
}
