using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Roditelji
    {
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }
    }
}
