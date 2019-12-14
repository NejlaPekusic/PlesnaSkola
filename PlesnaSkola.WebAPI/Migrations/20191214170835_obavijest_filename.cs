using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class obavijest_filename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prisustva_Plesaci_PlesacId",
                table: "Prisustva");

            migrationBuilder.DropIndex(
                name: "IX_Prisustva_PlesacId",
                table: "Prisustva");

            migrationBuilder.AddColumn<string>(
                name: "PrilogFileName",
                table: "Obavijesti",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrilogFileName",
                table: "Obavijesti");

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
    }
}
