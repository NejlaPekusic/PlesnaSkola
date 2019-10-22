using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class UplateInsertRequest
    {
        public double IznosUplate { get; set; }
        public DateTime DatumUplate { get; set; }
        public int VoditeljId { get; set; }
        public int PlesacId { get; set; }

    }
}
