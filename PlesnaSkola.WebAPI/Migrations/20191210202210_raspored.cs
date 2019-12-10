using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class raspored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radionice_Rasporedi_RasporedId",
                table: "Radionice");

            migrationBuilder.DropTable(
                name: "Rasporedi");

            migrationBuilder.DropIndex(
                name: "IX_Radionice_RasporedId",
                table: "Radionice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rasporedi",
                columns: table => new
                {
                    RasporedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumObjave = table.Column<DateTime>(nullable: false),
                    NazivRasporeda = table.Column<string>(nullable: true),
                    Sadrzaj = table.Column<string>(nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_Radionice_RasporedId",
                table: "Radionice",
                column: "RasporedId");

            migrationBuilder.CreateIndex(
                name: "IX_Rasporedi_TrenerId",
                table: "Rasporedi",
                column: "TrenerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Radionice_Rasporedi_RasporedId",
                table: "Radionice",
                column: "RasporedId",
                principalTable: "Rasporedi",
                principalColumn: "RasporedId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
