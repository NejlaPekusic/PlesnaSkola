using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class KoreografijeSearchRequest
    {
        public string NazivKoreografije { get; set; }
        public int Stil { get; set; }
    }
}
