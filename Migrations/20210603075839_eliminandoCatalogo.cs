using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PuppiesPet.Migrations
{
    public partial class eliminandoCatalogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t_categoriaproducto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "t_categoriaproducto",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: true),
                    productoIdId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_categoriaproducto", x => x.id);
                    table.ForeignKey(
                        name: "FK_t_categoriaproducto_t_producto_productoIdId",
                        column: x => x.productoIdId,
                        principalTable: "t_producto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_t_categoriaproducto_productoIdId",
                table: "t_categoriaproducto",
                column: "productoIdId");
        }
    }
}
