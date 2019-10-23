﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Uplate
    {
        public int UplataId { get; set; }
        public double IznosUplate { get; set; }
        public DateTime DatumUplate { get; set; }
        public int VoditeljId { get; set; }
        public int PlesacId { get; set; }

        public Plesaci Plesac { get; set; }
        public Voditelji Voditelj { get; set; }
    }
}
