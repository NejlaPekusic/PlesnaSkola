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
        public virtual DbSet<Muzika> Muzika { get; set; }
        public virtual DbSet<Plesaci> Plesaci { get; set; }
        public virtual DbSet<Pravdanja> Pravdanja { get; set; }
        public virtual DbSet<Radionice> Radionice { get; set; }
        public virtual DbSet<Rasporedi> Rasporedi { get; set; }
        public virtual DbSet<Roditelji> Roditelji { get; set; }
        public virtual DbSet<Treneri> Treneri { get; set; }
        public virtual DbSet<Treninzi> Treninzi { get; set; }
        public virtual DbSet<Uplate> Uplate { get; set; }
        public virtual DbSet<Voditelji> Voditelji { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asistenti>(entity =>
            {
                entity.HasKey(e => e.AsistentId);

                entity.Property(e => e.AsistentId)
                    .HasColumnName("AsistentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Grupe>(entity =>
            {
                entity.HasKey(e => e.GrupaId);

                entity.Property(e => e.GrupaId)
                    .HasColumnName("GrupaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazivGrupe)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Koreografije>(entity =>
            {
                entity.HasKey(e => e.KoreografijaId);

                entity.Property(e => e.KoreografijaId)
                    .HasColumnName("KoreografijaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NazivKoreografije)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.VoditeljId).HasColumnName("VoditeljID");

                entity.HasOne(d => d.Voditelj)
                    .WithMany(p => p.Koreografije)
                    .HasForeignKey(d => d.VoditeljId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Koreograf__Vodit__5AEE82B9");
            });

            modelBuilder.Entity<Muzika>(entity =>
            {
                entity.Property(e => e.MuzikaId)
                    .HasColumnName("MuzikaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AsistentId).HasColumnName("AsistentID");

                entity.Property(e => e.GrupaId).HasColumnName("GrupaID");

                entity.Property(e => e.KoreografijaId).HasColumnName("KoreografijaID");

                entity.Property(e => e.NazivPjesme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Asistent)
                    .WithMany(p => p.Muzika)
                    .HasForeignKey(d => d.AsistentId)
                    .HasConstraintName("FK__Muzika__Asistent__534D60F1");

                entity.HasOne(d => d.Grupa)
                    .WithMany(p => p.Muzika)
                    .HasForeignKey(d => d.GrupaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Muzika__Grupe_Gr__5535A963");

                entity.HasOne(d => d.Koreografija)
                    .WithMany(p => p.Muzika)
                    .HasForeignKey(d => d.KoreografijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Muzika__Koreogra__5441852A");
            });

            modelBuilder.Entity<Plesaci>(entity =>
            {
                entity.HasKey(e => e.PlesacId);

                entity.Property(e => e.PlesacId)
                    .HasColumnName("PlesacID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GrupaId).HasColumnName("GrupaID");

                entity.Property(e => e.NazivSkole).HasMaxLength(40);

                entity.Property(e => e.RoditeljId).HasColumnName("RoditeljID");

                entity.HasOne(d => d.Grupa)
                    .WithMany(p => p.Plesaci)
                    .HasForeignKey(d => d.GrupaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Plesaci__Grupe_G__4F7CD00D");

                entity.HasOne(d => d.Roditelj)
                    .WithMany(p => p.Plesaci)
                    .HasForeignKey(d => d.RoditeljId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Plesaci__Roditel__4E88ABD4");
            });

            modelBuilder.Entity<Pravdanja>(entity =>
            {
                entity.HasKey(e => e.PravdanjeId);

                entity.Property(e => e.PravdanjeId)
                    .HasColumnName("PravdanjeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumDo)
                    .HasColumnName("DatumDO")
                    .HasColumnType("date");

                entity.Property(e => e.DatumOd)
                    .HasColumnName("DatumOD")
                    .HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NazivSkole)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VoditeljId).HasColumnName("VoditeljID");

                entity.HasOne(d => d.Voditelj)
                    .WithMany(p => p.Pravdanja)
                    .HasForeignKey(d => d.VoditeljId)
                    .HasConstraintName("FK__Pravdanja__Vodit__5629CD9C");
            });

            modelBuilder.Entity<Radionice>(entity =>
            {
                entity.HasKey(e => e.RadionicaId);

                entity.Property(e => e.RadionicaId)
                    .HasColumnName("RadionicaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AsistentId).HasColumnName("AsistentID");

                entity.Property(e => e.DatumOdrzavanja).HasColumnType("date");

                entity.Property(e => e.MjestoOdrzavanja)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NazivRadionice)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.Property(e => e.RasporedId).HasColumnName("RasporedID");

                entity.HasOne(d => d.Asistent)
                    .WithMany(p => p.Radionice)
                    .HasForeignKey(d => d.AsistentId)
                    .HasConstraintName("FK__Radionice__Asist__59063A47");

                entity.HasOne(d => d.Raspored)
                    .WithMany(p => p.Radionice)
                    .HasForeignKey(d => d.RasporedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Radionice__Raspo__59FA5E80");
            });

            modelBuilder.Entity<Rasporedi>(entity =>
            {
                entity.HasKey(e => e.RasporedId);

                entity.Property(e => e.RasporedId)
                    .HasColumnName("RasporedID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumObjave).HasColumnType("date");

                entity.Property(e => e.NazivRasporeda)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Sadrzaj).HasMaxLength(200);

                entity.Property(e => e.TrenerId).HasColumnName("TrenerID");

                entity.HasOne(d => d.Trener)
                    .WithMany(p => p.Rasporedi)
                    .HasForeignKey(d => d.TrenerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rasporedi__Trene__52593CB8");
            });

            modelBuilder.Entity<Roditelji>(entity =>
            {
                entity.HasKey(e => e.RoditeljId);

                entity.Property(e => e.RoditeljId)
                    .HasColumnName("RoditeljID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Treneri>(entity =>
            {
                entity.HasKey(e => e.TrenerId);

                entity.Property(e => e.TrenerId)
                    .HasColumnName("TrenerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrojPasosa)
                    .HasColumnName("Broj_pasosa")
                    .HasMaxLength(8);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Funkcija)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Licenca).HasMaxLength(100);

                entity.Property(e => e.Mail).HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Treninzi>(entity =>
            {
                entity.HasKey(e => e.TreningId);

                entity.Property(e => e.TreningId)
                    .HasColumnName("TreningID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumOdrzavanja).HasColumnType("date");

                entity.Property(e => e.GrupaId).HasColumnName("GrupaID");

                entity.Property(e => e.Sala)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TrenerId).HasColumnName("TrenerID");

                entity.HasOne(d => d.Grupa)
                    .WithMany(p => p.Treninzi)
                    .HasForeignKey(d => d.GrupaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Treninzi__Grupe___5165187F");

                entity.HasOne(d => d.Trener)
                    .WithMany(p => p.Treninzi)
                    .HasForeignKey(d => d.TrenerId)
                    .HasConstraintName("FK__Treninzi__Trener__5070F446");
            });

            modelBuilder.Entity<Uplate>(entity =>
            {
                entity.HasKey(e => e.UplataId);

                entity.Property(e => e.UplataId)
                    .HasColumnName("UplataID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatumUplate).HasColumnType("date");

                entity.Property(e => e.PlesacId).HasColumnName("PlesacID");

                entity.Property(e => e.VoditeljId).HasColumnName("VoditeljID");

                entity.HasOne(d => d.Plesac)
                    .WithMany(p => p.Uplate)
                    .HasForeignKey(d => d.PlesacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uplate__Plesaci___5812160E");

                entity.HasOne(d => d.Voditelj)
                    .WithMany(p => p.Uplate)
                    .HasForeignKey(d => d.VoditeljId)
                    .HasConstraintName("FK__Uplate__Voditelj__571DF1D5");
            });

            modelBuilder.Entity<Voditelji>(entity =>
            {
                entity.HasKey(e => e.VoditeljId);

                entity.Property(e => e.VoditeljId)
                    .HasColumnName("VoditeljID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrojPasosa).HasMaxLength(8);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(100);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(15);
            });
        }
    }
}
