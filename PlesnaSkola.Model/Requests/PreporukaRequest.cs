using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class PreporukaRequest
    {
        [Required]
        public DateTime DatumRodjenja { get; set; }
    }
}
