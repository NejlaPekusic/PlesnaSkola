using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class username_password : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Korisnici",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Korisnici",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Korisnici");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Korisnici");
        }
    }
}
