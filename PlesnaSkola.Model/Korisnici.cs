﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public bool? Aktivan { get; set; }

        public Asistenti Asistent { get; set; }
        public Roditelji Roditelj { get; set; }
        public Plesaci Plesac { get; set; }
        public Treneri Trener { get; set; }
        public Voditelji Voditelj { get; set; }
    }
}