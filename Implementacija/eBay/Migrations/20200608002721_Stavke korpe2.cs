using Microsoft.EntityFrameworkCore.Migrations;

namespace eBay.Migrations
{
    public partial class Stavkekorpe2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkaKorpe_Korpa_KorpaId",
                table: "StavkaKorpe");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaKorpe_Proizvod_ProizvodId",
                table: "StavkaKorpe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StavkaKorpe",
                table: "StavkaKorpe");

            migrationBuilder.RenameTable(
                name: "StavkaKorpe",
                newName: "StavkeKorpe");

            migrationBuilder.RenameIndex(
                name: "IX_StavkaKorpe_ProizvodId",
                table: "StavkeKorpe",
                newName: "IX_StavkeKorpe_ProizvodId");

            migrationBuilder.RenameIndex(
                name: "IX_StavkaKorpe_KorpaId",
                table: "StavkeKorpe",
                newName: "IX_StavkeKorpe_KorpaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StavkeKorpe",
                table: "StavkeKorpe",
                column: "StavkaKorpeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeKorpe_Korpa_KorpaId",
                table: "StavkeKorpe",
                column: "KorpaId",
                principalTable: "Korpa",
                principalColumn: "KorpaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeKorpe_Proizvod_ProizvodId",
                table: "StavkeKorpe",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "ProizvodId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkeKorpe_Korpa_KorpaId",
                table: "StavkeKorpe");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeKorpe_Proizvod_ProizvodId",
                table: "StavkeKorpe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StavkeKorpe",
                table: "StavkeKorpe");

            migrationBuilder.RenameTable(
                name: "StavkeKorpe",
                newName: "StavkaKorpe");

            migrationBuilder.RenameIndex(
                name: "IX_StavkeKorpe_ProizvodId",
                table: "StavkaKorpe",
                newName: "IX_StavkaKorpe_ProizvodId");

            migrationBuilder.RenameIndex(
                name: "IX_StavkeKorpe_KorpaId",
                table: "StavkaKorpe",
                newName: "IX_StavkaKorpe_KorpaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StavkaKorpe",
                table: "StavkaKorpe",
                column: "StavkaKorpeId");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaKorpe_Korpa_KorpaId",
                table: "StavkaKorpe",
                column: "KorpaId",
                principalTable: "Korpa",
                principalColumn: "KorpaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaKorpe_Proizvod_ProizvodId",
                table: "StavkaKorpe",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "ProizvodId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
