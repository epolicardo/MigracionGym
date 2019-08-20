using Microsoft.EntityFrameworkCore.Migrations;

namespace MigracionGym.Web.Migrations
{
    public partial class Gastosconusuarios1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "usuarioId",
                table: "gastos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_gastos_usuarioId",
                table: "gastos",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_gastos_AspNetUsers_usuarioId",
                table: "gastos",
                column: "usuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gastos_AspNetUsers_usuarioId",
                table: "gastos");

            migrationBuilder.DropIndex(
                name: "IX_gastos_usuarioId",
                table: "gastos");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "gastos");
        }
    }
}
