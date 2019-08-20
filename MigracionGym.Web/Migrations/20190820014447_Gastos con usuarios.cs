using Microsoft.EntityFrameworkCore.Migrations;

namespace MigracionGym.Web.Migrations
{
    public partial class Gastosconusuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "actividad",
                table: "actividades",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "profesoresid",
                table: "actividades",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_actividades_profesoresid",
                table: "actividades",
                column: "profesoresid");

            migrationBuilder.AddForeignKey(
                name: "FK_actividades_profesores_profesoresid",
                table: "actividades",
                column: "profesoresid",
                principalTable: "profesores",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actividades_profesores_profesoresid",
                table: "actividades");

            migrationBuilder.DropIndex(
                name: "IX_actividades_profesoresid",
                table: "actividades");

            migrationBuilder.DropColumn(
                name: "actividad",
                table: "actividades");

            migrationBuilder.DropColumn(
                name: "profesoresid",
                table: "actividades");
        }
    }
}
