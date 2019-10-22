using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class PravdanjaInsertRequest
    {
        public string NazivSkole { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public int VoditeljId { get; set; }
    }
}
