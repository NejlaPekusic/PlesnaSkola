using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class brojpasosa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojPasosa",
                table: "Voditelji");

            migrationBuilder.DropColumn(
                name: "BrojPasosa",
                table: "Treneri");

            migrationBuilder.DropColumn(
                name: "BrojClanova",
                table: "Grupe");

            migrationBuilder.AddColumn<string>(
                name: "BrojPasosa",
                table: "Korisnici",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrojPasosa",
                table: "Korisnici");

            migrationBuilder.AddColumn<string>(
                name: "BrojPasosa",
                table: "Voditelji",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrojPasosa",
                table: "Treneri",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BrojClanova",
                table: "Grupe",
                nullable: false,
                defaultValue: 0);
        }
    }
}
