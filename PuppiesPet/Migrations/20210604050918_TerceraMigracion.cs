using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppiesPet.Migrations
{
    public partial class TerceraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "fechaNacimiento",
                table: "t_mascota",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaNacimiento",
                table: "t_mascota");
        }
    }
}
