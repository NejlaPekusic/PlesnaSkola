using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlesnaSkola.WebAPI.Models
{
    public class PravdanjaPlesaci
    {
        public int Id { get; set; }
        public int PlesacId { get; set; }
        public Plesaci Plesac { get; set; }
        public int PravdanjeId { get; set; }
        public Pravdanja Pravdanje { get; set; }
    }
}
