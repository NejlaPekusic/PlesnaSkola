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
        public int KoreografijaId { get; set; }
        public byte[] Pjesma { get; set; }
    }
}
