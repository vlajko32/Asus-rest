using Microsoft.EntityFrameworkCore.Migrations;

namespace Asus_rest.Migrations
{
    public partial class updatedRadnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OdgovornaLica_Trzista_TrzisteSifraTrzista",
                table: "OdgovornaLica");

            migrationBuilder.DropIndex(
                name: "IX_OdgovornaLica_TrzisteSifraTrzista",
                table: "OdgovornaLica");

            migrationBuilder.DropColumn(
                name: "TrzisteSifraTrzista",
                table: "OdgovornaLica");

            migrationBuilder.AddColumn<int>(
                name: "TrzisteID",
                table: "OdgovornaLica",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OdgovornaLica_TrzisteID",
                table: "OdgovornaLica",
                column: "TrzisteID");

            migrationBuilder.AddForeignKey(
                name: "FK_OdgovornaLica_Trzista_TrzisteID",
                table: "OdgovornaLica",
                column: "TrzisteID",
                principalTable: "Trzista",
                principalColumn: "SifraTrzista",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OdgovornaLica_Trzista_TrzisteID",
                table: "OdgovornaLica");

            migrationBuilder.DropIndex(
                name: "IX_OdgovornaLica_TrzisteID",
                table: "OdgovornaLica");

            migrationBuilder.DropColumn(
                name: "TrzisteID",
                table: "OdgovornaLica");

            migrationBuilder.AddColumn<int>(
                name: "TrzisteSifraTrzista",
                table: "OdgovornaLica",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OdgovornaLica_TrzisteSifraTrzista",
                table: "OdgovornaLica",
                column: "TrzisteSifraTrzista");

            migrationBuilder.AddForeignKey(
                name: "FK_OdgovornaLica_Trzista_TrzisteSifraTrzista",
                table: "OdgovornaLica",
                column: "TrzisteSifraTrzista",
                principalTable: "Trzista",
                principalColumn: "SifraTrzista",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
