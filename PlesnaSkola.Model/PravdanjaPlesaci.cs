using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model
{
    public class PravdanjaPlesaci
    {
        public int Id { get; set; }
        public int PlesacId { get; set; }
        public Plesaci Plesac { get; set; }
        public int PravdanjeId { get; set; }
    }
}
