using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Voditelji
    {
        public Voditelji()
        {
            Koreografije = new HashSet<Koreografije>();
            Pravdanja = new HashSet<Pravdanja>();
            Uplate = new HashSet<Uplate>();
        }

        [ForeignKey("Korisnik")]
        [Required]
        public int Id { get; set; }
        public Korisnici Korisnik { get; set; }
        public string BrojPasosa { get; set; }
        public string Telefon { get; set; }

        public ICollection<Koreografije> Koreografije { get; set; }
        public ICollection<Pravdanja> Pravdanja { get; set; }
        public ICollection<Uplate> Uplate { get; set; }
    }
}
