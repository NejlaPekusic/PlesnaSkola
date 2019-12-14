using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class pravdanja_plesaci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plesaci_Pravdanja_PravdanjaPravdanjeId",
                table: "Plesaci");

            migrationBuilder.DropIndex(
                name: "IX_Plesaci_PravdanjaPravdanjeId",
                table: "Plesaci");

            migrationBuilder.DropColumn(
                name: "PravdanjaPravdanjeId",
                table: "Plesaci");

            migrationBuilder.CreateTable(
                name: "PravdanjaPlesaci",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlesacId = table.Column<int>(nullable: false),
                    PravdanjeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PravdanjaPlesaci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PravdanjaPlesaci_Plesaci_PlesacId",
                        column: x => x.PlesacId,
                        principalTable: "Plesaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PravdanjaPlesaci_Pravdanja_PravdanjeId",
                        column: x => x.PravdanjeId,
                        principalTable: "Pravdanja",
                        principalColumn: "PravdanjeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PravdanjaPlesaci_PlesacId",
                table: "PravdanjaPlesaci",
                column: "PlesacId");

            migrationBuilder.CreateIndex(
                name: "IX_PravdanjaPlesaci_PravdanjeId",
                table: "PravdanjaPlesaci",
                column: "PravdanjeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PravdanjaPlesaci");

            migrationBuilder.AddColumn<int>(
                name: "PravdanjaPravdanjeId",
                table: "Plesaci",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Plesaci_PravdanjaPravdanjeId",
                table: "Plesaci",
                column: "PravdanjaPravdanjeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plesaci_Pravdanja_PravdanjaPravdanjeId",
                table: "Plesaci",
                column: "PravdanjaPravdanjeId",
                principalTable: "Pravdanja",
                principalColumn: "PravdanjeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
