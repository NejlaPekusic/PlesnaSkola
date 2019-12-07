using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Asistenti
    {
        public int Id { get; set; }
        public Korisnici_Basic Korisnik { get; set; }
    }
}
