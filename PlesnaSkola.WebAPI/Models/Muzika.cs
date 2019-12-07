using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Muzika
    {
        [Key]
        public int MuzikaId { get; set; }
        public string NazivPjesme { get; set; }
        public TimeSpan Trajanje { get; set; }
        public int KoreografijaId { get; set; }
        public byte[] Pjesma { get; set; }
        public Koreografije Koreografija { get; set; }
    }
}
