using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Pravdanja
    {
        public Pravdanja()
        {
            Plesaci = new List<PravdanjaPlesaci>();
        }

        [Key]
        public int PravdanjeId { get; set; }
        public string Opis { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int VoditeljId { get; set; }
        public Voditelji Voditelj { get; set; }
        public IEnumerable<PravdanjaPlesaci> Plesaci { get; set; }
    }
}
