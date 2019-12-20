using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Radionice
    {
        [Key]
        public int RadionicaId { get; set; }
        public string NazivRadionice { get; set; }
        public string Opis { get; set; }
        public string MjestoOdrzavanja { get; set; }
        public TimeSpan VrijemeOdrzavanja { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int BrojUcesnika { get; set; }
        public int AsistentId { get; set; }

        public Asistenti Asistent { get; set; }
    }
}
