using Microsoft.EntityFrameworkCore.Migrations;

namespace Asus_rest.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Porudzbenicce_Kupci_kupacPiB",
                table: "Porudzbenicce");

            migrationBuilder.DropForeignKey(
                name: "FK_Porudzbenicce_OdgovornaLica_odgovornoLiceSifraRadnika",
                table: "Porudzbenicce");

            migrationBuilder.RenameColumn(
                name: "odgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                newName: "OdgovornoLiceSifraRadnika");

            migrationBuilder.RenameColumn(
                name: "kupacPiB",
                table: "Porudzbenicce",
                newName: "KupacPiB");

            migrationBuilder.RenameColumn(
                name: "datumPor",
                table: "Porudzbenicce",
                newName: "DatumPor");

            migrationBuilder.RenameColumn(
                name: "porudzbeniccaID",
                table: "Porudzbenicce",
                newName: "PorudzbeniccaID");

            migrationBuilder.RenameIndex(
                name: "IX_Porudzbenicce_odgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                newName: "IX_Porudzbenicce_OdgovornoLiceSifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_Porudzbenicce_kupacPiB",
                table: "Porudzbenicce",
                newName: "IX_Porudzbenicce_KupacPiB");

            migrationBuilder.AlterColumn<string>(
                name: "PiB",
                table: "Porudzbenicce",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Porudzbenicce_Kupci_KupacPiB",
                table: "Porudzbenicce",
                column: "KupacPiB",
                principalTable: "Kupci",
                principalColumn: "PiB",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Porudzbenicce_OdgovornaLica_OdgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                column: "OdgovornoLiceSifraRadnika",
                principalTable: "OdgovornaLica",
                principalColumn: "SifraRadnika",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Porudzbenicce_Kupci_KupacPiB",
                table: "Porudzbenicce");

            migrationBuilder.DropForeignKey(
                name: "FK_Porudzbenicce_OdgovornaLica_OdgovornoLiceSifraRadnika",
                table: "Porudzbenicce");

            migrationBuilder.RenameColumn(
                name: "OdgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                newName: "odgovornoLiceSifraRadnika");

            migrationBuilder.RenameColumn(
                name: "KupacPiB",
                table: "Porudzbenicce",
                newName: "kupacPiB");

            migrationBuilder.RenameColumn(
                name: "DatumPor",
                table: "Porudzbenicce",
                newName: "datumPor");

            migrationBuilder.RenameColumn(
                name: "PorudzbeniccaID",
                table: "Porudzbenicce",
                newName: "porudzbeniccaID");

            migrationBuilder.RenameIndex(
                name: "IX_Porudzbenicce_OdgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                newName: "IX_Porudzbenicce_odgovornoLiceSifraRadnika");

            migrationBuilder.RenameIndex(
                name: "IX_Porudzbenicce_KupacPiB",
                table: "Porudzbenicce",
                newName: "IX_Porudzbenicce_kupacPiB");

            migrationBuilder.AlterColumn<int>(
                name: "PiB",
                table: "Porudzbenicce",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Porudzbenicce_Kupci_kupacPiB",
                table: "Porudzbenicce",
                column: "kupacPiB",
                principalTable: "Kupci",
                principalColumn: "PiB",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Porudzbenicce_OdgovornaLica_odgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                column: "odgovornoLiceSifraRadnika",
                principalTable: "OdgovornaLica",
                principalColumn: "SifraRadnika",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
