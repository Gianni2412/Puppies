using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppiesPet.Migrations
{
    public partial class QuintaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApellidoReservar",
                table: "t_reservar",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorreoReservar",
                table: "t_reservar",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreReservar",
                table: "t_reservar",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApellidoReservar",
                table: "t_reservar");

            migrationBuilder.DropColumn(
                name: "CorreoReservar",
                table: "t_reservar");

            migrationBuilder.DropColumn(
                name: "NombreReservar",
                table: "t_reservar");
        }
    }
}
