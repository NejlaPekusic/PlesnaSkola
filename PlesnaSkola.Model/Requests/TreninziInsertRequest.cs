using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class TreninziInsertRequest
    {
        public TimeSpan Satnica { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string Sala { get; set; }
        public int TrenerId { get; set; }
        public int GrupaId { get; set; }
    }
}
