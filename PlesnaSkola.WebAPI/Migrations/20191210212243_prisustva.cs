using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class prisustva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prisustva",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlesacId = table.Column<int>(nullable: false),
                    TreningId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisustva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prisustva_Plesaci_PlesacId",
                        column: x => x.PlesacId,
                        principalTable: "Plesaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prisustva_Treninzi_TreningId",
                        column: x => x.TreningId,
                        principalTable: "Treninzi",
                        principalColumn: "TreningId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prisustva_PlesacId",
                table: "Prisustva",
                column: "PlesacId");

            migrationBuilder.CreateIndex(
                name: "IX_Prisustva_TreningId",
                table: "Prisustva",
                column: "TreningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prisustva");
        }
    }
}
