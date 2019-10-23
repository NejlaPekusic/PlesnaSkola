using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class RasporediInsertRequest
    {
        public string NazivRasporeda { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public int TrenerId { get; set; }
    }
}
