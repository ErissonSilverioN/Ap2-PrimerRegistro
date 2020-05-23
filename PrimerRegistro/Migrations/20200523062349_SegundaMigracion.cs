using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerRegistro.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "errores",
                columns: table => new
                {
                    ErrorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hallazgo = table.Column<string>(nullable: false),
                    Ruta = table.Column<string>(nullable: false),
                    Importancia = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_errores", x => x.ErrorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "errores");
        }
    }
}
