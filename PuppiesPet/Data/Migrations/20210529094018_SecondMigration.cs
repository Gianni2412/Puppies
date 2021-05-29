using Microsoft.EntityFrameworkCore.Migrations;

namespace PuppiesPet.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "t_usuario",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "t_trabaja",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Asunto",
                table: "t_trabaja",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "t_trabaja");

            migrationBuilder.DropColumn(
                name: "Asunto",
                table: "t_trabaja");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "t_usuario",
                newName: "Contraseña");
        }
    }
}
