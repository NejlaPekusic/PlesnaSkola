using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Treneri
    {
        public int Id { get; set; }
        public Korisnici_Basic Korisnik { get; set; }
        public string Licenca { get; set; }
        public string Funkcija { get; set; }

    }
}
