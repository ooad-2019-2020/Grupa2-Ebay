using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBay.Migrations
{
    public partial class Dodanracun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorpaId",
                table: "Proizvod",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    KorpaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<int>(nullable: false),
                    KupacId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.KorpaId);
                    table.ForeignKey(
                        name: "FK_Korpa_AspNetUsers_KupacId1",
                        column: x => x.KupacId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KupacId = table.Column<string>(nullable: true),
                    DatumNarucivanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunId);
                    table.ForeignKey(
                        name: "FK_Racun_AspNetUsers_KupacId",
                        column: x => x.KupacId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkaRacuna",
                columns: table => new
                {
                    StavkaRacunaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    OpisProizvoda = table.Column<string>(nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    Kategorija = table.Column<string>(nullable: true),
                    ProdavacId = table.Column<int>(nullable: false),
                    ProdavacId1 = table.Column<string>(nullable: true),
                    Kolicina = table.Column<long>(nullable: false),
                    ProizvodId = table.Column<int>(nullable: false),
                    RacunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaRacuna", x => x.StavkaRacunaId);
                    table.ForeignKey(
                        name: "FK_StavkaRacuna_AspNetUsers_ProdavacId1",
                        column: x => x.ProdavacId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StavkaRacuna_Racun_RacunId",
                        column: x => x.RacunId,
                        principalTable: "Racun",
                        principalColumn: "RacunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KorpaId",
                table: "Proizvod",
                column: "KorpaId");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KupacId1",
                table: "Korpa",
                column: "KupacId1");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_KupacId",
                table: "Racun",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacuna_ProdavacId1",
                table: "StavkaRacuna",
                column: "ProdavacId1");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacuna_RacunId",
                table: "StavkaRacuna",
                column: "RacunId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Korpa_KorpaId",
                table: "Proizvod",
                column: "KorpaId",
                principalTable: "Korpa",
                principalColumn: "KorpaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Korpa_KorpaId",
                table: "Proizvod");

            migrationBuilder.DropTable(
                name: "Korpa");

            migrationBuilder.DropTable(
                name: "StavkaRacuna");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_KorpaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KorpaId",
                table: "Proizvod");
        }
    }
}
