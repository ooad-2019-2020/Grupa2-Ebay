using Microsoft.EntityFrameworkCore.Migrations;

namespace eBay.Migrations
{
    public partial class PopravljenidkodIdentityreferencifkova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_AspNetUsers_KupacId1",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_AspNetUsers_ProdavacId1",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacuna_AspNetUsers_ProdavacId1",
                table: "StavkaRacuna");

            migrationBuilder.DropIndex(
                name: "IX_StavkaRacuna_ProdavacId1",
                table: "StavkaRacuna");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_ProdavacId1",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_KupacId1",
                table: "Korpa");

            migrationBuilder.DropColumn(
                name: "ProdavacId1",
                table: "StavkaRacuna");

            migrationBuilder.DropColumn(
                name: "ProdavacId1",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KupacId1",
                table: "Korpa");

            migrationBuilder.AlterColumn<string>(
                name: "ProdavacId",
                table: "StavkaRacuna",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProdavacId",
                table: "Proizvod",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "KupacId",
                table: "Korpa",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacuna_ProdavacId",
                table: "StavkaRacuna",
                column: "ProdavacId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ProdavacId",
                table: "Proizvod",
                column: "ProdavacId");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KupacId",
                table: "Korpa",
                column: "KupacId");

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_AspNetUsers_KupacId",
                table: "Korpa",
                column: "KupacId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_AspNetUsers_ProdavacId",
                table: "Proizvod",
                column: "ProdavacId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacuna_AspNetUsers_ProdavacId",
                table: "StavkaRacuna",
                column: "ProdavacId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Korpa_AspNetUsers_KupacId",
                table: "Korpa");

            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_AspNetUsers_ProdavacId",
                table: "Proizvod");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkaRacuna_AspNetUsers_ProdavacId",
                table: "StavkaRacuna");

            migrationBuilder.DropIndex(
                name: "IX_StavkaRacuna_ProdavacId",
                table: "StavkaRacuna");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_ProdavacId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Korpa_KupacId",
                table: "Korpa");

            migrationBuilder.AlterColumn<int>(
                name: "ProdavacId",
                table: "StavkaRacuna",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProdavacId1",
                table: "StavkaRacuna",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProdavacId",
                table: "Proizvod",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProdavacId1",
                table: "Proizvod",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KupacId",
                table: "Korpa",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KupacId1",
                table: "Korpa",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkaRacuna_ProdavacId1",
                table: "StavkaRacuna",
                column: "ProdavacId1");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ProdavacId1",
                table: "Proizvod",
                column: "ProdavacId1");

            migrationBuilder.CreateIndex(
                name: "IX_Korpa_KupacId1",
                table: "Korpa",
                column: "KupacId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Korpa_AspNetUsers_KupacId1",
                table: "Korpa",
                column: "KupacId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_AspNetUsers_ProdavacId1",
                table: "Proizvod",
                column: "ProdavacId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkaRacuna_AspNetUsers_ProdavacId1",
                table: "StavkaRacuna",
                column: "ProdavacId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
