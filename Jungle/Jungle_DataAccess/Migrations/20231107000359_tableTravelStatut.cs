using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    public partial class tableTravelStatut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StatusConfirme",
                table: "Travels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusConfirme",
                table: "Travels");
        }
    }
}
