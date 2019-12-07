using Microsoft.EntityFrameworkCore.Migrations;

namespace PlesnaSkola.WebAPI.Migrations
{
    public partial class relacije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muzika_Asistenti_AsistentId",
                table: "Muzika");

            migrationBuilder.DropForeignKey(
                name: "FK_Muzika_Grupe_GrupaId",
                table: "Muzika");

            migrationBuilder.DropForeignKey(
                name: "FK_Muzika_Koreografije_KoreografijaId",
                table: "Muzika");

            migrationBuilder.DropIndex(
                name: "IX_Muzika_AsistentId",
                table: "Muzika");

            migrationBuilder.DropIndex(
                name: "IX_Muzika_GrupaId",
                table: "Muzika");

            migrationBuilder.DropIndex(
                name: "IX_Muzika_KoreografijaId",
                table: "Muzika");

            migrationBuilder.DropColumn(
                name: "AsistentId",
                table: "Muzika");

            migrationBuilder.DropColumn(
                name: "GrupaId",
                table: "Muzika");

            migrationBuilder.AddColumn<int>(
                name: "AsistentiId",
                table: "Muzika",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AsistentId",
                table: "Koreografije",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrupaId",
                table: "Koreografije",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MuzikaId",
                table: "Koreografije",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrenerId",
                table: "Grupe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_AsistentiId",
                table: "Muzika",
                column: "AsistentiId");

            migrationBuilder.CreateIndex(
                name: "IX_Koreografije_AsistentId",
                table: "Koreografije",
                column: "AsistentId");

            migrationBuilder.CreateIndex(
                name: "IX_Koreografije_GrupaId",
                table: "Koreografije",
                column: "GrupaId");

            migrationBuilder.CreateIndex(
                name: "IX_Koreografije_MuzikaId",
                table: "Koreografije",
                column: "MuzikaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupe_TrenerId",
                table: "Grupe",
                column: "TrenerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grupe_Treneri_TrenerId",
                table: "Grupe",
                column: "TrenerId",
                principalTable: "Treneri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Koreografije_Asistenti_AsistentId",
                table: "Koreografije",
                column: "AsistentId",
                principalTable: "Asistenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Koreografije_Grupe_GrupaId",
                table: "Koreografije",
                column: "GrupaId",
                principalTable: "Grupe",
                principalColumn: "GrupaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Koreografije_Muzika_MuzikaId",
                table: "Koreografije",
                column: "MuzikaId",
                principalTable: "Muzika",
                principalColumn: "MuzikaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Muzika_Asistenti_AsistentiId",
                table: "Muzika",
                column: "AsistentiId",
                principalTable: "Asistenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grupe_Treneri_TrenerId",
                table: "Grupe");

            migrationBuilder.DropForeignKey(
                name: "FK_Koreografije_Asistenti_AsistentId",
                table: "Koreografije");

            migrationBuilder.DropForeignKey(
                name: "FK_Koreografije_Grupe_GrupaId",
                table: "Koreografije");

            migrationBuilder.DropForeignKey(
                name: "FK_Koreografije_Muzika_MuzikaId",
                table: "Koreografije");

            migrationBuilder.DropForeignKey(
                name: "FK_Muzika_Asistenti_AsistentiId",
                table: "Muzika");

            migrationBuilder.DropIndex(
                name: "IX_Muzika_AsistentiId",
                table: "Muzika");

            migrationBuilder.DropIndex(
                name: "IX_Koreografije_AsistentId",
                table: "Koreografije");

            migrationBuilder.DropIndex(
                name: "IX_Koreografije_GrupaId",
                table: "Koreografije");

            migrationBuilder.DropIndex(
                name: "IX_Koreografije_MuzikaId",
                table: "Koreografije");

            migrationBuilder.DropIndex(
                name: "IX_Grupe_TrenerId",
                table: "Grupe");

            migrationBuilder.DropColumn(
                name: "AsistentiId",
                table: "Muzika");

            migrationBuilder.DropColumn(
                name: "AsistentId",
                table: "Koreografije");

            migrationBuilder.DropColumn(
                name: "GrupaId",
                table: "Koreografije");

            migrationBuilder.DropColumn(
                name: "MuzikaId",
                table: "Koreografije");

            migrationBuilder.DropColumn(
                name: "TrenerId",
                table: "Grupe");

            migrationBuilder.AddColumn<int>(
                name: "AsistentId",
                table: "Muzika",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrupaId",
                table: "Muzika",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_AsistentId",
                table: "Muzika",
                column: "AsistentId");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_GrupaId",
                table: "Muzika",
                column: "GrupaId");

            migrationBuilder.CreateIndex(
                name: "IX_Muzika_KoreografijaId",
                table: "Muzika",
                column: "KoreografijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Muzika_Asistenti_AsistentId",
                table: "Muzika",
                column: "AsistentId",
                principalTable: "Asistenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Muzika_Grupe_GrupaId",
                table: "Muzika",
                column: "GrupaId",
                principalTable: "Grupe",
                principalColumn: "GrupaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Muzika_Koreografije_KoreografijaId",
                table: "Muzika",
                column: "KoreografijaId",
                principalTable: "Koreografije",
                principalColumn: "KoreografijaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
