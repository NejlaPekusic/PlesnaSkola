using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class satnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Satnica",
                table: "Treninzi",
                newName: "SatnicaOd");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "SatnicaDo",
                table: "Treninzi",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SatnicaDo",
                table: "Treninzi");

            migrationBuilder.RenameColumn(
                name: "SatnicaOd",
                table: "Treninzi",
                newName: "Satnica");
        }
    }
}
