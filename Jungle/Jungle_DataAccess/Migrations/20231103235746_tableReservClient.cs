using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jungle_DataAccess.Migrations
{
    public partial class tableReservClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NoTelephone1 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NoTelephone2 = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "date", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Province = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Courriel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NoCarteCredit = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    LimiteCredit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateReservation = table.Column<DateTime>(type: "date", nullable: false),
                    DateDepart = table.Column<DateTime>(type: "date", nullable: false),
                    PourcentageRabais = table.Column<int>(type: "int", nullable: false),
                    NombrePlaces = table.Column<int>(type: "int", nullable: false),
                    PrixFinal = table.Column<double>(type: "float", nullable: false),
                    StatusConfirme = table.Column<bool>(type: "bit", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Travels_Id",
                        column: x => x.Id,
                        principalTable: "Travels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ClientId",
                table: "Reservations",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_Id",
                table: "Reservations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
