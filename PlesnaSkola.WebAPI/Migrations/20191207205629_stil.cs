using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class stil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Pjesma",
                table: "Muzika",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stil",
                table: "Koreografije",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pjesma",
                table: "Muzika");

            migrationBuilder.DropColumn(
                name: "Stil",
                table: "Koreografije");
        }
    }
}
