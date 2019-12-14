using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class pravdanja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Pravdanja");

            migrationBuilder.DropColumn(
                name: "NazivSkole",
                table: "Pravdanja");

            migrationBuilder.RenameColumn(
                name: "Prezime",
                table: "Pravdanja",
                newName: "Opis");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumIzdavanja",
                table: "Pravdanja",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plesaci_Pravdanja_PravdanjaPravdanjeId",
                table: "Plesaci");

            migrationBuilder.DropIndex(
                name: "IX_Plesaci_PravdanjaPravdanjeId",
                table: "Plesaci");

            migrationBuilder.DropColumn(
                name: "DatumIzdavanja",
                table: "Pravdanja");

            migrationBuilder.DropColumn(
                name: "PravdanjaPravdanjeId",
                table: "Plesaci");

            migrationBuilder.RenameColumn(
                name: "Opis",
                table: "Pravdanja",
                newName: "Prezime");

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Pravdanja",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NazivSkole",
                table: "Pravdanja",
                nullable: true);
        }
    }
}
