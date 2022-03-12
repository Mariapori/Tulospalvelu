using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tulospalvelu.Migrations
{
    public partial class TiimiTilasto_paattynyt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Paattynyt",
                table: "Tilastot",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paattynyt",
                table: "Tilastot");
        }
    }
}
