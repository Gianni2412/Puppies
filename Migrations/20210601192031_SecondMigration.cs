using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppiesPet.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenMascota",
                table: "t_mascota",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenMascota",
                table: "t_mascota");
        }
    }
}
