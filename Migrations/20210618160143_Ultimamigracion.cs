using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppiesPet.Migrations
{
    public partial class Ultimamigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto",
                table: "t_doctor",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cmvp",
                table: "t_doctor",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "especializaciones",
                table: "t_doctor",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "t_doctor");

            migrationBuilder.DropColumn(
                name: "cmvp",
                table: "t_doctor");

            migrationBuilder.DropColumn(
                name: "especializaciones",
                table: "t_doctor");
        }
    }
}
