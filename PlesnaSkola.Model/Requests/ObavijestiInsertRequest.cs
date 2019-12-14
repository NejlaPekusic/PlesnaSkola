using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class ObavijestiInsertRequest
    {
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Prilog { get; set; }
        public string PrilogFileName { get; set; }

        public int KorisnikId { get; set; }

    }
}
