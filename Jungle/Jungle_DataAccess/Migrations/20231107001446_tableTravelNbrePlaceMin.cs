using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    public partial class tableTravelNbrePlaceMin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombrePlaces",
                table: "Travels",
                newName: "NombrePlacesMinimun");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombrePlacesMinimun",
                table: "Travels",
                newName: "NombrePlaces");
        }
    }
}
