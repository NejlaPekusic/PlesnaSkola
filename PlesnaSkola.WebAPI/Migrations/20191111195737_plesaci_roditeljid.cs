using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class plesaci_roditeljid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plesaci_Roditelji_RoditeljId",
                table: "Plesaci");

            migrationBuilder.AlterColumn<int>(
                name: "RoditeljId",
                table: "Plesaci",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Plesaci_Roditelji_RoditeljId",
                table: "Plesaci",
                column: "RoditeljId",
                principalTable: "Roditelji",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plesaci_Roditelji_RoditeljId",
                table: "Plesaci");

            migrationBuilder.AlterColumn<int>(
                name: "RoditeljId",
                table: "Plesaci",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Plesaci_Roditelji_RoditeljId",
                table: "Plesaci",
                column: "RoditeljId",
                principalTable: "Roditelji",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
