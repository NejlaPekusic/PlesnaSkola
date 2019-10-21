﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlesnaSkola.WebAPI.Models;

namespace PlesnaSkola.WebAPI.Migrations
{
    [DbContext(typeof(PlesnaSkolaContext))]
    [Migration("20191021193356_Inicijalna")]
    partial class Inicijalna
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Asistenti", b =>
                {
                    b.Property<int>("AsistentId")
                        .HasColumnName("AsistentID");

                    b.Property<bool?>("Aktivan");

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mail")
                        .HasMaxLength(100);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("AsistentId");

                    b.ToTable("Asistenti");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Grupe", b =>
                {
                    b.Property<int>("GrupaId")
                        .HasColumnName("GrupaID");

                    b.Property<int>("BrojClanova");

                    b.Property<string>("NazivGrupe")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("GrupaId");

                    b.ToTable("Grupe");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Koreografije", b =>
                {
                    b.Property<int>("KoreografijaId")
                        .HasColumnName("KoreografijaID");

                    b.Property<string>("NazivKoreografije")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("VoditeljId")
                        .HasColumnName("VoditeljID");

                    b.HasKey("KoreografijaId");

                    b.HasIndex("VoditeljId");

                    b.ToTable("Koreografije");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Muzika", b =>
                {
                    b.Property<int>("MuzikaId")
                        .HasColumnName("MuzikaID");

                    b.Property<int>("AsistentId")
                        .HasColumnName("AsistentID");

                    b.Property<int>("GrupaId")
                        .HasColumnName("GrupaID");

                    b.Property<int>("KoreografijaId")
                        .HasColumnName("KoreografijaID");

                    b.Property<string>("NazivPjesme")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<TimeSpan>("Trajanje");

                    b.HasKey("MuzikaId");

                    b.HasIndex("AsistentId");

                    b.HasIndex("GrupaId");

                    b.HasIndex("KoreografijaId");

                    b.ToTable("Muzika");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Plesaci", b =>
                {
                    b.Property<int>("PlesacId")
                        .HasColumnName("PlesacID");

                    b.Property<bool?>("Aktivan");

                    b.Property<int?>("BrojObuce");

                    b.Property<int?>("BrojOdjece");

                    b.Property<int>("GrupaId")
                        .HasColumnName("GrupaID");

                    b.Property<string>("NazivSkole")
                        .HasMaxLength(40);

                    b.Property<int>("RoditeljId")
                        .HasColumnName("RoditeljID");

                    b.HasKey("PlesacId");

                    b.HasIndex("GrupaId");

                    b.HasIndex("RoditeljId");

                    b.ToTable("Plesaci");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Pravdanja", b =>
                {
                    b.Property<int>("PravdanjeId")
                        .HasColumnName("PravdanjeID");

                    b.Property<DateTime>("DatumDo")
                        .HasColumnName("DatumDO")
                        .HasColumnType("date");

                    b.Property<DateTime>("DatumOd")
                        .HasColumnName("DatumOD")
                        .HasColumnType("date");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NazivSkole")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("VoditeljId")
                        .HasColumnName("VoditeljID");

                    b.HasKey("PravdanjeId");

                    b.HasIndex("VoditeljId");

                    b.ToTable("Pravdanja");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Radionice", b =>
                {
                    b.Property<int>("RadionicaId")
                        .HasColumnName("RadionicaID");

                    b.Property<int>("AsistentId")
                        .HasColumnName("AsistentID");

                    b.Property<int>("BrojUcesnika");

                    b.Property<DateTime>("DatumOdrzavanja")
                        .HasColumnType("date");

                    b.Property<string>("MjestoOdrzavanja")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("NazivRadionice")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Opis")
                        .HasMaxLength(200);

                    b.Property<int>("RasporedId")
                        .HasColumnName("RasporedID");

                    b.Property<TimeSpan>("VrijemeOdrzavanja");

                    b.HasKey("RadionicaId");

                    b.HasIndex("AsistentId");

                    b.HasIndex("RasporedId");

                    b.ToTable("Radionice");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Rasporedi", b =>
                {
                    b.Property<int>("RasporedId")
                        .HasColumnName("RasporedID");

                    b.Property<DateTime>("DatumObjave")
                        .HasColumnType("date");

                    b.Property<string>("NazivRasporeda")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Sadrzaj")
                        .HasMaxLength(200);

                    b.Property<int>("TrenerId")
                        .HasColumnName("TrenerID");

                    b.HasKey("RasporedId");

                    b.HasIndex("TrenerId");

                    b.ToTable("Rasporedi");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Roditelji", b =>
                {
                    b.Property<int>("RoditeljId")
                        .HasColumnName("RoditeljID");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mail")
                        .HasMaxLength(100);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("RoditeljId");

                    b.ToTable("Roditelji");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treneri", b =>
                {
                    b.Property<int>("TrenerId")
                        .HasColumnName("TrenerID");

                    b.Property<bool>("Aktivan");

                    b.Property<string>("BrojPasosa")
                        .HasColumnName("Broj_pasosa")
                        .HasMaxLength(8);

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("date");

                    b.Property<string>("Funkcija")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Licenca")
                        .HasMaxLength(100);

                    b.Property<string>("Mail")
                        .HasMaxLength(100);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("TrenerId");

                    b.ToTable("Treneri");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treninzi", b =>
                {
                    b.Property<int>("TreningId")
                        .HasColumnName("TreningID");

                    b.Property<DateTime>("DatumOdrzavanja")
                        .HasColumnType("date");

                    b.Property<int>("GrupaId")
                        .HasColumnName("GrupaID");

                    b.Property<string>("Sala")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<TimeSpan>("Satnica");

                    b.Property<int>("TrenerId")
                        .HasColumnName("TrenerID");

                    b.HasKey("TreningId");

                    b.HasIndex("GrupaId");

                    b.HasIndex("TrenerId");

                    b.ToTable("Treninzi");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Uplate", b =>
                {
                    b.Property<int>("UplataId")
                        .HasColumnName("UplataID");

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("date");

                    b.Property<double>("IznosUplate");

                    b.Property<int>("PlesacId")
                        .HasColumnName("PlesacID");

                    b.Property<int>("VoditeljId")
                        .HasColumnName("VoditeljID");

                    b.HasKey("UplataId");

                    b.HasIndex("PlesacId");

                    b.HasIndex("VoditeljId");

                    b.ToTable("Uplate");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Voditelji", b =>
                {
                    b.Property<int>("VoditeljId")
                        .HasColumnName("VoditeljID");

                    b.Property<bool>("Aktivan");

                    b.Property<string>("BrojPasosa")
                        .HasMaxLength(8);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mail")
                        .HasMaxLength(100);

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Telefon")
                        .HasMaxLength(15);

                    b.HasKey("VoditeljId");

                    b.ToTable("Voditelji");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Koreografije", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Voditelji", "Voditelj")
                        .WithMany("Koreografije")
                        .HasForeignKey("VoditeljId")
                        .HasConstraintName("FK__Koreograf__Vodit__5AEE82B9");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Muzika", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Asistenti", "Asistent")
                        .WithMany("Muzika")
                        .HasForeignKey("AsistentId")
                        .HasConstraintName("FK__Muzika__Asistent__534D60F1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Grupe", "Grupa")
                        .WithMany("Muzika")
                        .HasForeignKey("GrupaId")
                        .HasConstraintName("FK__Muzika__Grupe_Gr__5535A963");

                    b.HasOne("PlesnaSkola.WebAPI.Models.Koreografije", "Koreografija")
                        .WithMany("Muzika")
                        .HasForeignKey("KoreografijaId")
                        .HasConstraintName("FK__Muzika__Koreogra__5441852A");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Plesaci", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Grupe", "Grupa")
                        .WithMany("Plesaci")
                        .HasForeignKey("GrupaId")
                        .HasConstraintName("FK__Plesaci__Grupe_G__4F7CD00D");

                    b.HasOne("PlesnaSkola.WebAPI.Models.Roditelji", "Roditelj")
                        .WithMany("Plesaci")
                        .HasForeignKey("RoditeljId")
                        .HasConstraintName("FK__Plesaci__Roditel__4E88ABD4");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Pravdanja", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Voditelji", "Voditelj")
                        .WithMany("Pravdanja")
                        .HasForeignKey("VoditeljId")
                        .HasConstraintName("FK__Pravdanja__Vodit__5629CD9C")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Radionice", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Asistenti", "Asistent")
                        .WithMany("Radionice")
                        .HasForeignKey("AsistentId")
                        .HasConstraintName("FK__Radionice__Asist__59063A47")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Rasporedi", "Raspored")
                        .WithMany("Radionice")
                        .HasForeignKey("RasporedId")
                        .HasConstraintName("FK__Radionice__Raspo__59FA5E80");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Rasporedi", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Treneri", "Trener")
                        .WithMany("Rasporedi")
                        .HasForeignKey("TrenerId")
                        .HasConstraintName("FK__Rasporedi__Trene__52593CB8");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treninzi", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Grupe", "Grupa")
                        .WithMany("Treninzi")
                        .HasForeignKey("GrupaId")
                        .HasConstraintName("FK__Treninzi__Grupe___5165187F");

                    b.HasOne("PlesnaSkola.WebAPI.Models.Treneri", "Trener")
                        .WithMany("Treninzi")
                        .HasForeignKey("TrenerId")
                        .HasConstraintName("FK__Treninzi__Trener__5070F446")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Uplate", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Plesaci", "Plesac")
                        .WithMany("Uplate")
                        .HasForeignKey("PlesacId")
                        .HasConstraintName("FK__Uplate__Plesaci___5812160E");

                    b.HasOne("PlesnaSkola.WebAPI.Models.Voditelji", "Voditelj")
                        .WithMany("Uplate")
                        .HasForeignKey("VoditeljId")
                        .HasConstraintName("FK__Uplate__Voditelj__571DF1D5")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
