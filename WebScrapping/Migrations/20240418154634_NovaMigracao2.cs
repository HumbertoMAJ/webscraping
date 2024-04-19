using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebScrapping.Migrations
{
    public partial class NovaMigracao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_componsicoes",
                table: "componsicoes");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "componsicoes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "componsicoes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_componsicoes",
                table: "componsicoes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_componsicoes",
                table: "componsicoes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "componsicoes");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "componsicoes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddPrimaryKey(
                name: "PK_componsicoes",
                table: "componsicoes",
                column: "Codigo");
        }
    }
}
