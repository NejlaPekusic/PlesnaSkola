using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Grupe
    {
        public Grupe()
        {
            Koreografije = new HashSet<Koreografije>();
            Plesaci = new HashSet<Plesaci>();
            Treninzi = new HashSet<Treninzi>();
        }
        [Key]

        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public int TrenerId { get; set; }
        public Treneri Trener { get; set; }
        public GrupaUzrast GrupaUzrast { get; set; }

        public ICollection<Koreografije> Koreografije { get; set; }
        public ICollection<Plesaci> Plesaci { get; set; }
        public ICollection<Treninzi> Treninzi { get; set; }
    }

    public enum GrupaUzrast
    {
        [Description("3 - 5")]
        OD_3_DO_5 = 1,
        [Description("6 - 8")]
        OD_6_DO_8 = 2,
        [Description("9 - 11")]
        OD_9_DO_11 = 3,
        [Description("12 - 15")]
        OD_12_DO_15 = 4,
        [Description("15 +")]
        PREKO_15 = 5
    }
}
