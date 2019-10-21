using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Voditelji
    {
        public Voditelji()
        {
            Koreografije = new HashSet<Koreografije>();
            Pravdanja = new HashSet<Pravdanja>();
            Uplate = new HashSet<Uplate>();
        }

        public int VoditeljId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public bool Aktivan { get; set; }
        public string BrojPasosa { get; set; }
        public string Telefon { get; set; }

        public ICollection<Koreografije> Koreografije { get; set; }
        public ICollection<Pravdanja> Pravdanja { get; set; }
        public ICollection<Uplate> Uplate { get; set; }
    }
}
