using Microsoft.EntityFrameworkCore.Migrations;

namespace CitasMedicas.App.Persistencia.Migrations
{
    public partial class migra13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sede",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "SedeId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_SedeId",
                table: "Personas",
                column: "SedeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Sedes_SedeId",
                table: "Personas",
                column: "SedeId",
                principalTable: "Sedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Sedes_SedeId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_SedeId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "SedeId",
                table: "Personas");

            migrationBuilder.AddColumn<string>(
                name: "Sede",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
