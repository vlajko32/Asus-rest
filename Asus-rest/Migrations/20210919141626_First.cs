using Microsoft.EntityFrameworkCore.Migrations;

namespace Asus_rest.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trzista",
                columns: table => new
                {
                    SifraTrzista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trzista", x => x.SifraTrzista);
                });

            migrationBuilder.CreateTable(
                name: "OdgovornaLica",
                columns: table => new
                {
                    SifraRadnika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrzisteSifraTrzista = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdgovornaLica", x => x.SifraRadnika);
                    table.ForeignKey(
                        name: "FK_OdgovornaLica_Trzista_TrzisteSifraTrzista",
                        column: x => x.TrzisteSifraTrzista,
                        principalTable: "Trzista",
                        principalColumn: "SifraTrzista",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OdgovornaLica_TrzisteSifraTrzista",
                table: "OdgovornaLica",
                column: "TrzisteSifraTrzista");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OdgovornaLica");

            migrationBuilder.DropTable(
                name: "Trzista");
        }
    }
}
