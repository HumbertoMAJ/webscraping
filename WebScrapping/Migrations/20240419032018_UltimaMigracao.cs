using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebScrapping.Migrations
{
    public partial class UltimaMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_componsicoes",
                table: "componsicoes");

            migrationBuilder.RenameTable(
                name: "componsicoes",
                newName: "composicoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_composicoes",
                table: "composicoes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_composicoes",
                table: "composicoes");

            migrationBuilder.RenameTable(
                name: "composicoes",
                newName: "componsicoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_componsicoes",
                table: "componsicoes",
                column: "Id");
        }
    }
}
