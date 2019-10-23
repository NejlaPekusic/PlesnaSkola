using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Muzika
    {
        public int MuzikaId { get; set; }
        public string NazivPjesme { get; set; }
        public TimeSpan Trajanje { get; set; }
        public int AsistentId { get; set; }
        public int KoreografijaId { get; set; }
        public int GrupaId { get; set; }

        public Asistenti Asistent { get; set; }
        public Grupe Grupa { get; set; }
        public Koreografije Koreografija { get; set; }
    }
}
