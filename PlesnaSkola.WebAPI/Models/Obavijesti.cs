using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Models
{
    public class Obavijesti
    {
        [Key]
        public int ObavijestId { get; set; }

        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Prilog { get; set; }

    }
}
