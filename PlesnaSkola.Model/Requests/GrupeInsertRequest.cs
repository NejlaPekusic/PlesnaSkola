using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class GrupeInsertRequest
    {
        public string NazivGrupe { get; set; }
        public int TrenerId { get; set; }
        public GrupaUzrast GrupaUzrast { get; set; }
    }
}
