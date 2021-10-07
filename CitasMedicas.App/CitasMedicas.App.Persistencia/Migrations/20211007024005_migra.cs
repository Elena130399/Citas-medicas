using Microsoft.EntityFrameworkCore.Migrations;

namespace CitasMedicas.App.Persistencia.Migrations
{
    public partial class migra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TieneEps",
                table: "Personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TieneEps",
                table: "Personas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
