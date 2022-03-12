using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tulospalvelu.Migrations
{
    public partial class TiimiTilasto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joukkueet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nimi = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joukkueet", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tilastot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    kotiId = table.Column<int>(type: "int", nullable: true),
                    vierasId = table.Column<int>(type: "int", nullable: true),
                    VierasPisteet = table.Column<int>(type: "int", nullable: false),
                    KotiPistet = table.Column<int>(type: "int", nullable: false),
                    PVM = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tilastot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tilastot_Joukkueet_kotiId",
                        column: x => x.kotiId,
                        principalTable: "Joukkueet",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tilastot_Joukkueet_vierasId",
                        column: x => x.vierasId,
                        principalTable: "Joukkueet",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tilastot_kotiId",
                table: "Tilastot",
                column: "kotiId");

            migrationBuilder.CreateIndex(
                name: "IX_Tilastot_vierasId",
                table: "Tilastot",
                column: "vierasId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tilastot");

            migrationBuilder.DropTable(
                name: "Joukkueet");
        }
    }
}
