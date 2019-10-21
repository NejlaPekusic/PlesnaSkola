using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlesnaSkola.Model
{
    public partial class Asistenti
    {
        public Asistenti()
        {
            Muzika = new HashSet<Muzika>();
            Radionice = new HashSet<Radionice>();
        }
        
        public int Id { get; set; }

        public ICollection<Muzika> Muzika { get; set; }
        public ICollection<Radionice> Radionice { get; set; }
    }
}
