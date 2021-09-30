using Microsoft.EntityFrameworkCore.Migrations;

namespace CitasMedicas.App.Persistencia.Migrations
{
    public partial class migra12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Agenda",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Especializacion",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sede",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoMedico",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agenda",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Especializacion",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Sede",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TipoMedico",
                table: "Personas");
        }
    }
}
