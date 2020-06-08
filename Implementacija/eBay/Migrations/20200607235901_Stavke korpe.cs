using Microsoft.EntityFrameworkCore.Migrations;

namespace eBay.Migrations
{
    public partial class Stavkekorpe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Korpa_KorpaId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_KorpaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KorpaId",
                table: "Proizvod");

            migrationBuilder.CreateTable(
                name: "StavkaKorpe",
                columns: table => new
                {
                    StavkaKorpeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<long>(nullable: false),
                    KorpaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaKorpe", x => x.StavkaKorpeId);
                    table.ForeignKey(
                        name: "FK_StavkaKorpe_Korpa_KorpaId",
                        column: x => x.KorpaId,
                        principalTable: "Korpa",
                        principalColumn: "KorpaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkaKorpe_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StavkaKorpe_KorpaId",
                table: "StavkaKorpe",
                column: "KorpaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaKorpe_ProizvodId",
                table: "StavkaKorpe",
                column: "ProizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkaKorpe");

            migrationBuilder.AddColumn<int>(
                name: "KorpaId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KorpaId",
                table: "Proizvod",
                column: "KorpaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Korpa_KorpaId",
                table: "Proizvod",
                column: "KorpaId",
                principalTable: "Korpa",
                principalColumn: "KorpaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
