using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class RadioniceInsertRequest
    {
        public string NazivRadionice { get; set; }
        public string Opis { get; set; }
        public string MjestoOdrzavanja { get; set; }
        public TimeSpan VrijemeOdrzavanja { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int BrojUcesnika { get; set; }
        public int AsistentId { get; set; }


    }
}
