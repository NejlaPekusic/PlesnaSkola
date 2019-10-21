using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupe",
                columns: table => new
                {
                    GrupaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivGrupe = table.Column<string>(nullable: true),
                    BrojClanova = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupe", x => x.GrupaId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: true),
                    Aktivan = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Asistenti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asistenti_Korisnici_Id",
                        column: x => x.Id,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    ObavijestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    Prilog = table.Column<byte[]>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.ObavijestId);
                    table.ForeignKey(
                        name: "FK_Obavijesti_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roditelji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roditelji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roditelji_Korisnici_Id",
                        column: x => x.Id,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treneri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BrojPasosa = table.Column<string>(nullable: true),
                    Licenca = table.Column<string>(nullable: true),
                    Funkcija = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treneri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treneri_Korisnici_Id",
                        column: x => x.Id,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voditelji",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BrojPasosa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voditelji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voditelji_Korisnici_Id",
                        column: x => x.Id,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plesaci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BrojOdjece = table.Column<int>(nullable: true),
                    BrojObuce = table.Column<int>(nullable: true),
                    NazivSkole = table.Column<string>(nullable: true),
                    Aktivan = table.Column<bool>(nullable: true),
                    RoditeljId = table.Column<int>(nullable: false),
                    GrupaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plesaci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plesaci_Grupe_GrupaId",
                        column: x => x.GrupaId,
                        principalTable: "Grupe",
                        principalColumn: "GrupaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plesaci_Korisnici_Id",
                        column: x => x.Id,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plesaci_Roditelji_RoditeljId",
                        column: x => x.RoditeljId,
                        principalTable: "Roditelji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rasporedi",
                columns: table => new
                {
                    RasporedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivRasporeda = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    TrenerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rasporedi", x => x.RasporedId);
                    table.ForeignKey(
                        name: "FK_Rasporedi_Treneri_TrenerId",
                        column: x => x.TrenerId,
                        principalTable: "Treneri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treninzi",
                columns: table => new
                {
                    TreningId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Satnica = table.Column<TimeSpan>(nullable: false),
                    DatumOdrzavanja = table.Column<DateTime>(nullable: false),
                    Sala = table.Column<string>(nullable: true),
                    TrenerId = table.Column<int>(nullable: false),
                    GrupaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treninzi", x => x.TreningId);
                    table.ForeignKey(
                        name: "FK_Treninzi_Grupe_GrupaId",
                        column: x => x.GrupaId,
                        principalTable: "Grupe",
                        principalColumn: "GrupaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treninzi_Treneri_TrenerId",
                        column: x => x.TrenerId,
                        principalTable: "Treneri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Koreografije",
                columns: table => new
                {
                    KoreografijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivKoreografije = table.Column<string>(nullable: true),
                    VoditeljId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koreografije", x => x.KoreografijaId);
                    table.ForeignKey(
                        name: "FK_Koreografije_Voditelji_VoditeljId",
                        column: x => x.VoditeljId,
                        principalTable: "Voditelji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pravdanja",
                columns: table => new
                {
                    PravdanjeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivSkole = table.Column<string>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumOd = table.Column<DateTime>(nullable: false),
                    DatumDo = table.Column<DateTime>(nullable: false),
                    VoditeljId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pravdanja", x => x.PravdanjeId);
                    table.ForeignKey(
                        name: "FK_Pravdanja_Voditelji_VoditeljId",
                        column: x => x.VoditeljId,
                        principalTable: "Voditelji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IznosUplate = table.Column<double>(nullable: false),
                    DatumUplate = table.Column<DateTime>(nullable: false),
                    VoditeljId = table.Column<int>(nullable: false),
                    PlesacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.UplataId);
                    table.ForeignKey(
                        name: "FK_Uplate_Plesaci_PlesacId",
                        column: x => x.PlesacId,
                        principalTable: "Plesaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplate_Voditelji_VoditeljId",
                        column: x => x.VoditeljId,
                        principalTable: "Voditelji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Radionice",
                columns: table => new
                {
                    RadionicaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivRadionice = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    MjestoOdrzavanja = table.Column<string>(nullable: true),
                    VrijemeOdrzavanja = table.Column<TimeSpan>(nullable: false),
                    DatumOdrzavanja = table.Column<DateTime>(nullable: false),
                    BrojUcesnika = table.Column<int>(nullable: false),
                    AsistentId = table.Column<int>(nullable: false),
                    RasporedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radionice", x => x.RadionicaId);
                    table.ForeignKey(
                        name: "FK_Radionice_Asistenti_AsistentId",
                        column: x => x.AsistentId,
                        principalTable: "Asistenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Radionice_Rasporedi_RasporedId",
                        column: x => x.RasporedId,
                        principalTable: "Rasporedi",
                        principalColumn: "RasporedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Muzika",
                columns: table => new
                {
                    MuzikaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivPjesme = table.Column<string>(nullable: true),
                    Trajanje = table.Column<TimeSpan>(nullable: false),
                    AsistentId = table.Column<int>(nullable: false),
                    KoreografijaId = table.Column<int>(nullable: false),
                    GrupaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muzika", x => x.MuzikaId);
                    table.ForeignKey(
                        name: "FK_Muzika_Asistenti_AsistentId",
                        column: x => x.AsistentId,
                        principalTable: "Asistenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Muzika_Grupe_GrupaId",
                        column: x => x.GrupaId,
                        principalTable: "Grupe",
                        principalColumn: "GrupaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Muzika_Koreografije_KoreografijaId",
                        column: x => x.KoreografijaId,
                        principalTable: "Koreografije",
                        principalColumn: "KoreografijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Koreografije_VoditeljId",
                table: "Koreografije",
                column: "VoditeljId");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_AsistentId",
                table: "Muzika",
                column: "AsistentId");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_GrupaId",
                table: "Muzika",
                column: "GrupaId");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_KoreografijaId",
                table: "Muzika",
                column: "KoreografijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_KorisnikId",
                table: "Obavijesti",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Plesaci_GrupaId",
                table: "Plesaci",
                column: "GrupaId");

            migrationBuilder.CreateIndex(
                name: "IX_Plesaci_RoditeljId",
                table: "Plesaci",
                column: "RoditeljId");

            migrationBuilder.CreateIndex(
                name: "IX_Pravdanja_VoditeljId",
                table: "Pravdanja",
                column: "VoditeljId");

            migrationBuilder.CreateIndex(
                name: "IX_Radionice_AsistentId",
                table: "Radionice",
                column: "AsistentId");

            migrationBuilder.CreateIndex(
                name: "IX_Radionice_RasporedId",
                table: "Radionice",
                column: "RasporedId");

            migrationBuilder.CreateIndex(
                name: "IX_Rasporedi_TrenerId",
                table: "Rasporedi",
                column: "TrenerId");

            migrationBuilder.CreateIndex(
                name: "IX_Treninzi_GrupaId",
                table: "Treninzi",
                column: "GrupaId");

            migrationBuilder.CreateIndex(
                name: "IX_Treninzi_TrenerId",
                table: "Treninzi",
                column: "TrenerId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_PlesacId",
                table: "Uplate",
                column: "PlesacId");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_VoditeljId",
                table: "Uplate",
                column: "VoditeljId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Muzika");

            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.DropTable(
                name: "Pravdanja");

            migrationBuilder.DropTable(
                name: "Radionice");

            migrationBuilder.DropTable(
                name: "Treninzi");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Koreografije");

            migrationBuilder.DropTable(
                name: "Asistenti");

            migrationBuilder.DropTable(
                name: "Rasporedi");

            migrationBuilder.DropTable(
                name: "Plesaci");

            migrationBuilder.DropTable(
                name: "Voditelji");

            migrationBuilder.DropTable(
                name: "Treneri");

            migrationBuilder.DropTable(
                name: "Grupe");

            migrationBuilder.DropTable(
                name: "Roditelji");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}
