﻿using System;
using System.Collections.Generic;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class Treninzi
    {
        public int TreningId { get; set; }
        public TimeSpan Satnica { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string Sala { get; set; }
        public int TrenerId { get; set; }
        public int GrupaId { get; set; }

        public Grupe Grupa { get; set; }
        public Treneri Trener { get; set; }
    }
}