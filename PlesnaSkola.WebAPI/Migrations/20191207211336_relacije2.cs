using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class relacije2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muzika_Asistenti_AsistentiId",
                table: "Muzika");

            migrationBuilder.DropIndex(
                name: "IX_Muzika_AsistentiId",
                table: "Muzika");

            migrationBuilder.DropColumn(
                name: "AsistentiId",
                table: "Muzika");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsistentiId",
                table: "Muzika",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_AsistentiId",
                table: "Muzika",
                column: "AsistentiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Muzika_Asistenti_AsistentiId",
                table: "Muzika",
                column: "AsistentiId",
                principalTable: "Asistenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
