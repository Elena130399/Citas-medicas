using Microsoft.EntityFrameworkCore.Migrations;

namespace CitasMedicas.App.Persistencia.Migrations
{
    public partial class migra15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CiudadId",
                table: "Sedes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sedes_CiudadId",
                table: "Sedes",
                column: "CiudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sedes_Ciudades_CiudadId",
                table: "Sedes",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sedes_Ciudades_CiudadId",
                table: "Sedes");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Sedes_CiudadId",
                table: "Sedes");

            migrationBuilder.DropColumn(
                name: "CiudadId",
                table: "Sedes");
        }
    }
}
