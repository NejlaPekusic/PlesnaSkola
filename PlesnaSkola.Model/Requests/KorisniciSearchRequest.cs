using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public bool IncludeClanovi { get; set; }
        public bool IncludeUposlenici { get; set; }
        public bool IncludeRoditelji { get; set; }
        public string ImePrezime { get; set; }
    }
}
