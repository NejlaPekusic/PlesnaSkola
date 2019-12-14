using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class PravdanjaInsertRequest
    {
        public string Opis { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public List<PravdanjaPlesaci> Plesaci { get; set; }

    }
}
