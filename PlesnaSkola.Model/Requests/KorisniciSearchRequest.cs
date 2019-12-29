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
        public bool IncludeTreneri { get; set; }
        public bool IncludePlesaci { get; set; }
        public int GrupaId { get; set; }
        public string ImePrezime { get; set; }
        public bool IncludeAsistenti { get; set; }
        public bool IncludeDjeca { get; set; }
        public bool IncludeVoditelji { get; set; }
    }
}
