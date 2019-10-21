using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistenti",
                columns: table => new
                {
                    AsistentID = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: true),
                    Aktivan = table.Column<bool>(nullable: true),
                    Mail = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistenti", x => x.AsistentID);
                });

            migrationBuilder.CreateTable(
                name: "Grupe",
                columns: table => new
                {
                    GrupaID = table.Column<int>(nullable: false),
                    NazivGrupe = table.Column<string>(maxLength: 20, nullable: false),
                    BrojClanova = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupe", x => x.GrupaID);
                });

            migrationBuilder.CreateTable(
                name: "Roditelji",
                columns: table => new
                {
                    RoditeljID = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Mail = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roditelji", x => x.RoditeljID);
                });

            migrationBuilder.CreateTable(
                name: "Treneri",
                columns: table => new
                {
                    TrenerID = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Mail = table.Column<string>(maxLength: 100, nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: true),
                    Aktivan = table.Column<bool>(nullable: false),
                    Broj_pasosa = table.Column<string>(maxLength: 8, nullable: true),
                    Licenca = table.Column<string>(maxLength: 100, nullable: true),
                    Funkcija = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treneri", x => x.TrenerID);
                });

            migrationBuilder.CreateTable(
                name: "Voditelji",
                columns: table => new
                {
                    VoditeljID = table.Column<int>(nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Mail = table.Column<string>(maxLength: 100, nullable: true),
                    Aktivan = table.Column<bool>(nullable: false),
                    BrojPasosa = table.Column<string>(maxLength: 8, nullable: true),
                    Telefon = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voditelji", x => x.VoditeljID);
                });

            migrationBuilder.CreateTable(
                name: "Plesaci",
                columns: table => new
                {
                    PlesacID = table.Column<int>(nullable: false),
                    BrojOdjece = table.Column<int>(nullable: true),
                    BrojObuce = table.Column<int>(nullable: true),
                    NazivSkole = table.Column<string>(maxLength: 40, nullable: true),
                    Aktivan = table.Column<bool>(nullable: true),
                    RoditeljID = table.Column<int>(nullable: false),
                    GrupaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plesaci", x => x.PlesacID);
                    table.ForeignKey(
                        name: "FK__Plesaci__Grupe_G__4F7CD00D",
                        column: x => x.GrupaID,
                        principalTable: "Grupe",
                        principalColumn: "GrupaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Plesaci__Roditel__4E88ABD4",
                        column: x => x.RoditeljID,
                        principalTable: "Roditelji",
                        principalColumn: "RoditeljID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rasporedi",
                columns: table => new
                {
                    RasporedID = table.Column<int>(nullable: false),
                    NazivRasporeda = table.Column<string>(maxLength: 30, nullable: false),
                    Sadrzaj = table.Column<string>(maxLength: 200, nullable: true),
                    DatumObjave = table.Column<DateTime>(type: "date", nullable: false),
                    TrenerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rasporedi", x => x.RasporedID);
                    table.ForeignKey(
                        name: "FK__Rasporedi__Trene__52593CB8",
                        column: x => x.TrenerID,
                        principalTable: "Treneri",
                        principalColumn: "TrenerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treninzi",
                columns: table => new
                {
                    TreningID = table.Column<int>(nullable: false),
                    Satnica = table.Column<TimeSpan>(nullable: false),
                    DatumOdrzavanja = table.Column<DateTime>(type: "date", nullable: false),
                    Sala = table.Column<string>(maxLength: 20, nullable: false),
                    TrenerID = table.Column<int>(nullable: false),
                    GrupaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treninzi", x => x.TreningID);
                    table.ForeignKey(
                        name: "FK__Treninzi__Grupe___5165187F",
                        column: x => x.GrupaID,
                        principalTable: "Grupe",
                        principalColumn: "GrupaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Treninzi__Trener__5070F446",
                        column: x => x.TrenerID,
                        principalTable: "Treneri",
                        principalColumn: "TrenerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Koreografije",
                columns: table => new
                {
                    KoreografijaID = table.Column<int>(nullable: false),
                    NazivKoreografije = table.Column<string>(maxLength: 20, nullable: false),
                    VoditeljID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koreografije", x => x.KoreografijaID);
                    table.ForeignKey(
                        name: "FK__Koreograf__Vodit__5AEE82B9",
                        column: x => x.VoditeljID,
                        principalTable: "Voditelji",
                        principalColumn: "VoditeljID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pravdanja",
                columns: table => new
                {
                    PravdanjeID = table.Column<int>(nullable: false),
                    NazivSkole = table.Column<string>(maxLength: 30, nullable: false),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    DatumOD = table.Column<DateTime>(type: "date", nullable: false),
                    DatumDO = table.Column<DateTime>(type: "date", nullable: false),
                    VoditeljID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pravdanja", x => x.PravdanjeID);
                    table.ForeignKey(
                        name: "FK__Pravdanja__Vodit__5629CD9C",
                        column: x => x.VoditeljID,
                        principalTable: "Voditelji",
                        principalColumn: "VoditeljID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    UplataID = table.Column<int>(nullable: false),
                    IznosUplate = table.Column<double>(nullable: false),
                    DatumUplate = table.Column<DateTime>(type: "date", nullable: false),
                    VoditeljID = table.Column<int>(nullable: false),
                    PlesacID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.UplataID);
                    table.ForeignKey(
                        name: "FK__Uplate__Plesaci___5812160E",
                        column: x => x.PlesacID,
                        principalTable: "Plesaci",
                        principalColumn: "PlesacID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Uplate__Voditelj__571DF1D5",
                        column: x => x.VoditeljID,
                        principalTable: "Voditelji",
                        principalColumn: "VoditeljID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Radionice",
                columns: table => new
                {
                    RadionicaID = table.Column<int>(nullable: false),
                    NazivRadionice = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true),
                    MjestoOdrzavanja = table.Column<string>(maxLength: 30, nullable: false),
                    VrijemeOdrzavanja = table.Column<TimeSpan>(nullable: false),
                    DatumOdrzavanja = table.Column<DateTime>(type: "date", nullable: false),
                    BrojUcesnika = table.Column<int>(nullable: false),
                    AsistentID = table.Column<int>(nullable: false),
                    RasporedID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radionice", x => x.RadionicaID);
                    table.ForeignKey(
                        name: "FK__Radionice__Asist__59063A47",
                        column: x => x.AsistentID,
                        principalTable: "Asistenti",
                        principalColumn: "AsistentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Radionice__Raspo__59FA5E80",
                        column: x => x.RasporedID,
                        principalTable: "Rasporedi",
                        principalColumn: "RasporedID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Muzika",
                columns: table => new
                {
                    MuzikaID = table.Column<int>(nullable: false),
                    NazivPjesme = table.Column<string>(maxLength: 50, nullable: false),
                    Trajanje = table.Column<TimeSpan>(nullable: false),
                    AsistentID = table.Column<int>(nullable: false),
                    KoreografijaID = table.Column<int>(nullable: false),
                    GrupaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muzika", x => x.MuzikaID);
                    table.ForeignKey(
                        name: "FK__Muzika__Asistent__534D60F1",
                        column: x => x.AsistentID,
                        principalTable: "Asistenti",
                        principalColumn: "AsistentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Muzika__Grupe_Gr__5535A963",
                        column: x => x.GrupaID,
                        principalTable: "Grupe",
                        principalColumn: "GrupaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Muzika__Koreogra__5441852A",
                        column: x => x.KoreografijaID,
                        principalTable: "Koreografije",
                        principalColumn: "KoreografijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Koreografije_VoditeljID",
                table: "Koreografije",
                column: "VoditeljID");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_AsistentID",
                table: "Muzika",
                column: "AsistentID");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_GrupaID",
                table: "Muzika",
                column: "GrupaID");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_KoreografijaID",
                table: "Muzika",
                column: "KoreografijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Plesaci_GrupaID",
                table: "Plesaci",
                column: "GrupaID");

            migrationBuilder.CreateIndex(
                name: "IX_Plesaci_RoditeljID",
                table: "Plesaci",
                column: "RoditeljID");

            migrationBuilder.CreateIndex(
                name: "IX_Pravdanja_VoditeljID",
                table: "Pravdanja",
                column: "VoditeljID");

            migrationBuilder.CreateIndex(
                name: "IX_Radionice_AsistentID",
                table: "Radionice",
                column: "AsistentID");

            migrationBuilder.CreateIndex(
                name: "IX_Radionice_RasporedID",
                table: "Radionice",
                column: "RasporedID");

            migrationBuilder.CreateIndex(
                name: "IX_Rasporedi_TrenerID",
                table: "Rasporedi",
                column: "TrenerID");

            migrationBuilder.CreateIndex(
                name: "IX_Treninzi_GrupaID",
                table: "Treninzi",
                column: "GrupaID");

            migrationBuilder.CreateIndex(
                name: "IX_Treninzi_TrenerID",
                table: "Treninzi",
                column: "TrenerID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_PlesacID",
                table: "Uplate",
                column: "PlesacID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_VoditeljID",
                table: "Uplate",
                column: "VoditeljID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Muzika");

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
        }
    }
}
