using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class pravdanja_voditelj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pravdanja_Voditelji_VoditeljId",
                table: "Pravdanja");

            migrationBuilder.AlterColumn<int>(
                name: "VoditeljId",
                table: "Pravdanja",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Pravdanja_Voditelji_VoditeljId",
                table: "Pravdanja",
                column: "VoditeljId",
                principalTable: "Voditelji",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pravdanja_Voditelji_VoditeljId",
                table: "Pravdanja");

            migrationBuilder.AlterColumn<int>(
                name: "VoditeljId",
                table: "Pravdanja",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pravdanja_Voditelji_VoditeljId",
                table: "Pravdanja",
                column: "VoditeljId",
                principalTable: "Voditelji",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
