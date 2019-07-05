using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MigracionGym.Web.Migrations
{
    public partial class ProductoModificado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Productos",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaCompra",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UltimaVenta",
                table: "Productos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UltimaCompra",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UltimaVenta",
                table: "Productos");
        }
    }
}
