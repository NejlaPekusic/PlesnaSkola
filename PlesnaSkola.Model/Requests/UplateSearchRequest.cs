using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class UplateSearchRequest
    {
        public bool IncludeClanovi { get; set; }
        public string ImePrezime { get; set; }

    }
}
