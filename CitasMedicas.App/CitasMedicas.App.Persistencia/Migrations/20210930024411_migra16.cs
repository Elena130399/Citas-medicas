using Microsoft.EntityFrameworkCore.Migrations;

namespace CitasMedicas.App.Persistencia.Migrations
{
    public partial class migra16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegistroMedico",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TieneEps",
                table: "Personas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistroMedico",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TieneEps",
                table: "Personas");
        }
    }
}
