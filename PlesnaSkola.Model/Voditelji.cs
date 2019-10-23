using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Voditelji
    {
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }
        public string BrojPasosa { get; set; }
        public string Telefon { get; set; }
    }
}
