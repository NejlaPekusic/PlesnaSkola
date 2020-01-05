using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PlesnaSkola.Model
{
    public partial class Grupe
    {
        public int GrupaId { get; set; }
        public string NazivGrupe { get; set; }
        public int TrenerId { get; set; }
        public Treneri Trener { get; set; }
        public int BrojClanova { get; set; }
        public GrupaUzrast GrupaUzrast { get; set; }
        public string Uzrast { get => GrupaUzrast.DescriptionAttr(); }
        public string NazivGrupeIUzrast
        {
            get {
                if (NazivGrupe == "Odaberite")
                    return NazivGrupe;

                return NazivGrupe + " (" + Uzrast + " / Čl: " + BrojClanova + ")";
            }
        }

        public string Aktivna { get => BrojClanova >= 4 ? "DA" : "NE"; }

        public override string ToString()
        {
            return NazivGrupe;
        }

        public static GrupaUzrast? GetUzrast(int godine)
        {
            if (godine >= 3 && godine <= 5)
                return GrupaUzrast.OD_3_DO_5;
            if (godine >= 6 && godine <= 8)
                return GrupaUzrast.OD_6_DO_8;
            if (godine >= 9 && godine <= 11)
                return GrupaUzrast.OD_9_DO_11;
            if (godine >= 12 && godine <= 15)
                return GrupaUzrast.OD_12_DO_15;
            if (godine >= 16)
                return GrupaUzrast.OD_16;

            return null;
        }
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
        [Description("16 +")]
        OD_16 = 5
    }




}
