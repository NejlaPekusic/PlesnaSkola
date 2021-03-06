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
    [Migration("20191111195737_plesaci_roditeljid")]
    partial class plesaci_roditeljid
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
                    b.Property<int>("Id");

                    b.HasKey("Id");

                    b.ToTable("Asistenti");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Grupe", b =>
                {
                    b.Property<int>("GrupaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojClanova");

                    b.Property<string>("NazivGrupe");

                    b.HasKey("GrupaId");

                    b.ToTable("Grupe");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Koreografije", b =>
                {
                    b.Property<int>("KoreografijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivKoreografije");

                    b.Property<int>("VoditeljId");

                    b.HasKey("KoreografijaId");

                    b.HasIndex("VoditeljId");

                    b.ToTable("Koreografije");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Korisnici", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Aktivan");

                    b.Property<DateTime?>("DatumRodjenja");

                    b.Property<string>("Ime");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Muzika", b =>
                {
                    b.Property<int>("MuzikaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsistentId");

                    b.Property<int>("GrupaId");

                    b.Property<int>("KoreografijaId");

                    b.Property<string>("NazivPjesme");

                    b.Property<TimeSpan>("Trajanje");

                    b.HasKey("MuzikaId");

                    b.HasIndex("AsistentId");

                    b.HasIndex("GrupaId");

                    b.HasIndex("KoreografijaId");

                    b.ToTable("Muzika");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Obavijesti", b =>
                {
                    b.Property<int>("ObavijestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId");

                    b.Property<string>("Naslov");

                    b.Property<byte[]>("Prilog");

                    b.Property<string>("Sadrzaj");

                    b.HasKey("ObavijestId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Obavijesti");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Plesaci", b =>
                {
                    b.Property<int>("Id");

                    b.Property<bool?>("Aktivan");

                    b.Property<int?>("BrojObuce");

                    b.Property<int?>("BrojOdjece");

                    b.Property<int>("GrupaId");

                    b.Property<string>("NazivSkole");

                    b.Property<int?>("RoditeljId");

                    b.HasKey("Id");

                    b.HasIndex("GrupaId");

                    b.HasIndex("RoditeljId");

                    b.ToTable("Plesaci");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Pravdanja", b =>
                {
                    b.Property<int>("PravdanjeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumDo");

                    b.Property<DateTime>("DatumOd");

                    b.Property<string>("Ime");

                    b.Property<string>("NazivSkole");

                    b.Property<string>("Prezime");

                    b.Property<int>("VoditeljId");

                    b.HasKey("PravdanjeId");

                    b.HasIndex("VoditeljId");

                    b.ToTable("Pravdanja");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Radionice", b =>
                {
                    b.Property<int>("RadionicaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AsistentId");

                    b.Property<int>("BrojUcesnika");

                    b.Property<DateTime>("DatumOdrzavanja");

                    b.Property<string>("MjestoOdrzavanja");

                    b.Property<string>("NazivRadionice");

                    b.Property<string>("Opis");

                    b.Property<int>("RasporedId");

                    b.Property<TimeSpan>("VrijemeOdrzavanja");

                    b.HasKey("RadionicaId");

                    b.HasIndex("AsistentId");

                    b.HasIndex("RasporedId");

                    b.ToTable("Radionice");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Rasporedi", b =>
                {
                    b.Property<int>("RasporedId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumObjave");

                    b.Property<string>("NazivRasporeda");

                    b.Property<string>("Sadrzaj");

                    b.Property<int>("TrenerId");

                    b.HasKey("RasporedId");

                    b.HasIndex("TrenerId");

                    b.ToTable("Rasporedi");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Roditelji", b =>
                {
                    b.Property<int>("Id");

                    b.HasKey("Id");

                    b.ToTable("Roditelji");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treneri", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("BrojPasosa");

                    b.Property<string>("Funkcija");

                    b.Property<string>("Licenca");

                    b.HasKey("Id");

                    b.ToTable("Treneri");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treninzi", b =>
                {
                    b.Property<int>("TreningId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumOdrzavanja");

                    b.Property<int>("GrupaId");

                    b.Property<string>("Sala");

                    b.Property<TimeSpan>("Satnica");

                    b.Property<int>("TrenerId");

                    b.HasKey("TreningId");

                    b.HasIndex("GrupaId");

                    b.HasIndex("TrenerId");

                    b.ToTable("Treninzi");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Uplate", b =>
                {
                    b.Property<int>("UplataId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumUplate");

                    b.Property<double>("IznosUplate");

                    b.Property<int>("PlesacId");

                    b.Property<int>("VoditeljId");

                    b.HasKey("UplataId");

                    b.HasIndex("PlesacId");

                    b.HasIndex("VoditeljId");

                    b.ToTable("Uplate");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Voditelji", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("BrojPasosa");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.ToTable("Voditelji");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Asistenti", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Korisnici", "Korisnik")
                        .WithOne("Asistent")
                        .HasForeignKey("PlesnaSkola.WebAPI.Models.Asistenti", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Koreografije", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Voditelji", "Voditelj")
                        .WithMany("Koreografije")
                        .HasForeignKey("VoditeljId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Muzika", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Asistenti", "Asistent")
                        .WithMany("Muzika")
                        .HasForeignKey("AsistentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Grupe", "Grupa")
                        .WithMany("Muzika")
                        .HasForeignKey("GrupaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Koreografije", "Koreografija")
                        .WithMany("Muzika")
                        .HasForeignKey("KoreografijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Obavijesti", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Korisnici", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Plesaci", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Grupe", "Grupa")
                        .WithMany("Plesaci")
                        .HasForeignKey("GrupaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Korisnici", "Korisnik")
                        .WithOne("Plesac")
                        .HasForeignKey("PlesnaSkola.WebAPI.Models.Plesaci", "Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Roditelji", "Roditelj")
                        .WithMany("Plesaci")
                        .HasForeignKey("RoditeljId");
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Pravdanja", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Voditelji", "Voditelj")
                        .WithMany("Pravdanja")
                        .HasForeignKey("VoditeljId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Radionice", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Asistenti", "Asistent")
                        .WithMany("Radionice")
                        .HasForeignKey("AsistentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Rasporedi", "Raspored")
                        .WithMany("Radionice")
                        .HasForeignKey("RasporedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Rasporedi", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Treneri", "Trener")
                        .WithMany("Rasporedi")
                        .HasForeignKey("TrenerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Roditelji", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Korisnici", "Korisnik")
                        .WithOne("Roditelj")
                        .HasForeignKey("PlesnaSkola.WebAPI.Models.Roditelji", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treneri", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Korisnici", "Korisnik")
                        .WithOne("Trener")
                        .HasForeignKey("PlesnaSkola.WebAPI.Models.Treneri", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Treninzi", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Grupe", "Grupa")
                        .WithMany("Treninzi")
                        .HasForeignKey("GrupaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Treneri", "Trener")
                        .WithMany("Treninzi")
                        .HasForeignKey("TrenerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Uplate", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Plesaci", "Plesac")
                        .WithMany("Uplate")
                        .HasForeignKey("PlesacId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PlesnaSkola.WebAPI.Models.Voditelji", "Voditelj")
                        .WithMany("Uplate")
                        .HasForeignKey("VoditeljId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PlesnaSkola.WebAPI.Models.Voditelji", b =>
                {
                    b.HasOne("PlesnaSkola.WebAPI.Models.Korisnici", "Korisnik")
                        .WithOne("Voditelj")
                        .HasForeignKey("PlesnaSkola.WebAPI.Models.Voditelji", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
