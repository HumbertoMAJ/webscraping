using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebScrapping.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alimentos",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NomeCF = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Grupo = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alimentos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "componsicoes",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Componente = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Unidades = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ValorP = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DesvioP = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ValorMin = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ValorMax = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    NumeroD = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Ref = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TipoD = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_componsicoes", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alimentos");

            migrationBuilder.DropTable(
                name: "componsicoes");
        }
    }
}
