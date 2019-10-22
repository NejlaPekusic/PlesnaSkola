using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class MuzikaInsertRequest
    {
        public string NazivPjesme { get; set; }
        public TimeSpan Trajanje { get; set; }
        public int AsistentId { get; set; }
        public int KoreografijaId { get; set; }
        public int GrupaId { get; set; }

    }
}
