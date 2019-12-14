using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlesnaSkola.WebAPI.Models
{
    public partial class PlesnaSkolaContext : DbContext
    {
        public PlesnaSkolaContext(DbContextOptions<PlesnaSkolaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asistenti> Asistenti { get; set; }
        public virtual DbSet<Grupe> Grupe { get; set; }
        public virtual DbSet<Koreografije> Koreografije { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<Muzika> Muzika { get; set; }
        public virtual DbSet<Obavijesti> Obavijesti { get; set; }
        public virtual DbSet<Plesaci> Plesaci { get; set; }
        public virtual DbSet<Pravdanja> Pravdanja { get; set; }
        public virtual DbSet<Radionice> Radionice { get; set; }
        public virtual DbSet<Roditelji> Roditelji { get; set; }
        public virtual DbSet<Treneri> Treneri { get; set; }
        public virtual DbSet<Treninzi> Treninzi { get; set; }
        public virtual DbSet<Uplate> Uplate { get; set; }
        public virtual DbSet<Voditelji> Voditelji { get; set; }
        public virtual DbSet<Prisustva> Prisustva { get; set; }
        public virtual DbSet<PravdanjaPlesaci> PravdanjaPlesaci { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
