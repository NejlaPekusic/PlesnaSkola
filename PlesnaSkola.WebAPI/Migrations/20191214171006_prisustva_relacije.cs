using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class prisustva_relacije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Prisustva_PlesacId",
                table: "Prisustva",
                column: "PlesacId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prisustva_Plesaci_PlesacId",
                table: "Prisustva",
                column: "PlesacId",
                principalTable: "Plesaci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prisustva_Plesaci_PlesacId",
                table: "Prisustva");

            migrationBuilder.DropIndex(
                name: "IX_Prisustva_PlesacId",
                table: "Prisustva");
        }
    }
}
