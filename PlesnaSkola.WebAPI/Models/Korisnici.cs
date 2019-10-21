using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Models
{
    public class Korisnici
    {
        [Key]
        public int KorisnikId { get; set; }
    }
}
