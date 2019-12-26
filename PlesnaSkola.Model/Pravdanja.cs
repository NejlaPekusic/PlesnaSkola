using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Pravdanja
    {
        public int PravdanjeId { get; set; }
        public string Opis { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public DateTime? DatumZahtjeva { get; set; }
        public DateTime? DatumIzdavanja { get; set; }
        public int? VoditeljId { get; set; }

        public string DatumOdText { get => DatumOd.ToShortDateString(); }
        public string DatumDoText { get => DatumDo.ToShortDateString(); }

        public bool IsZahtjev { get => DatumZahtjeva != null && DatumIzdavanja is null; }
        public bool IsIzdano { get => !(DatumIzdavanja is null); }

        public Voditelji Voditelj { get; set; }
        public List<PravdanjaPlesaci> Plesaci { get; set; }

        public string ImenaPlesaca
        {
            get
            {
                if (Plesaci is null)
                    return "??";

                string imena = "";
                foreach (var pravdanjePlesac in Plesaci)
                {
                    if (imena != "")
                        imena += "\n";
                    imena += pravdanjePlesac?.Plesac?.Korisnik?.ImePrezime;
                }
                return imena;
            }
        }
    }
}
