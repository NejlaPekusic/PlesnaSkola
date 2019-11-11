using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PlesnaSkola.Model.Requests
{
    public class KorisniciInsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [EmailAddress]
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public bool? Aktivan { get; set; }
        public string BrojPasosa { get; set; }


        public Plesaci Plesac { get; set; }
        public Roditelji Roditelj { get; set; }
        public Asistenti Asistent { get; set; }
        public Treneri Trener { get; set; }
        public Voditelji Voditelj { get; set; }

    }
}
