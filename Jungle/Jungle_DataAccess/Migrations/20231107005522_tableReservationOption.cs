using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    public partial class tableReservationOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdOption1",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOption2",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdOption3",
                table: "Reservations",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOption1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "IdOption2",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "IdOption3",
                table: "Reservations");
        }
    }
}
