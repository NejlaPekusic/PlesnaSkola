using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class UplateInsertRequest
    {
        public double IznosUplate { get; set; }
        public DateTime DatumUplate { get; set; }
        public int PlesacId { get; set; }
        public VrstaUplate VrstaUplate { get; set; }
        public string Opis { get; set; }

    }
}
