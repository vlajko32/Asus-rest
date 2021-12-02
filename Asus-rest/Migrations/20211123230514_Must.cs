using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asus_rest.Migrations
{
    public partial class Must : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(
                name: "Porudzbenicce",
                columns: table => new
                {
                    porudzbeniccaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    datumPor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kupacPiB = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PiB = table.Column<int>(type: "int", nullable: false),
                    odgovornoLiceSifraRadnika = table.Column<int>(type: "int", nullable: true),
                    SifraRadnika = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porudzbenicce", x => x.porudzbeniccaID);
                    table.ForeignKey(
                        name: "FK_Porudzbenicce_Kupci_kupacPiB",
                        column: x => x.kupacPiB,
                        principalTable: "Kupci",
                        principalColumn: "PiB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Porudzbenicce_OdgovornaLica_odgovornoLiceSifraRadnika",
                        column: x => x.odgovornoLiceSifraRadnika,
                        principalTable: "OdgovornaLica",
                        principalColumn: "SifraRadnika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkePorudzbenicce",
                columns: table => new
                {
                    stavkaPorudzbenicceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    porudzbenicaID = table.Column<int>(type: "int", nullable: false),
                    kolicina = table.Column<int>(type: "int", nullable: false),
                    SifraProizvoda = table.Column<int>(type: "int", nullable: false),
                    ProizvodSifraProizvoda = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkePorudzbenicce", x => x.stavkaPorudzbenicceID);
                    table.ForeignKey(
                        name: "FK_StavkePorudzbenicce_Porudzbenicce_porudzbenicaID",
                        column: x => x.porudzbenicaID,
                        principalTable: "Porudzbenicce",
                        principalColumn: "porudzbeniccaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkePorudzbenicce_Proizvodi_ProizvodSifraProizvoda",
                        column: x => x.ProizvodSifraProizvoda,
                        principalTable: "Proizvodi",
                        principalColumn: "SifraProizvoda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbenicce_kupacPiB",
                table: "Porudzbenicce",
                column: "kupacPiB");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbenicce_odgovornoLiceSifraRadnika",
                table: "Porudzbenicce",
                column: "odgovornoLiceSifraRadnika");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePorudzbenicce_porudzbenicaID",
                table: "StavkePorudzbenicce",
                column: "porudzbenicaID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePorudzbenicce_ProizvodSifraProizvoda",
                table: "StavkePorudzbenicce",
                column: "ProizvodSifraProizvoda");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkePorudzbenicce");

            migrationBuilder.DropTable(
                name: "Porudzbenicce");

            migrationBuilder.CreateTable(
                name: "Porudzbennice",
                columns: table => new
                {
                    porudzbenicaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PiB = table.Column<int>(type: "int", nullable: false),
                    SifraRadnika = table.Column<int>(type: "int", nullable: false),
                    datumPor = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kupacPiB = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    odgovornoLiceSifraRadnika = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porudzbennice", x => x.porudzbenicaID);
                    table.ForeignKey(
                        name: "FK_Porudzbennice_Kupci_kupacPiB",
                        column: x => x.kupacPiB,
                        principalTable: "Kupci",
                        principalColumn: "PiB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Porudzbennice_OdgovornaLica_odgovornoLiceSifraRadnika",
                        column: x => x.odgovornoLiceSifraRadnika,
                        principalTable: "OdgovornaLica",
                        principalColumn: "SifraRadnika",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StavkePorudzbenice",
                columns: table => new
                {
                    stavkaPorudzbeniceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodSifraProizvoda = table.Column<int>(type: "int", nullable: true),
                    SifraProizvoda = table.Column<int>(type: "int", nullable: false),
                    kolicina = table.Column<int>(type: "int", nullable: false),
                    porudzbenicaID = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkePorudzbenice", x => x.stavkaPorudzbeniceID);
                    table.ForeignKey(
                        name: "FK_StavkePorudzbenice_Porudzbennice_porudzbenicaID",
                        column: x => x.porudzbenicaID,
                        principalTable: "Porudzbennice",
                        principalColumn: "porudzbenicaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkePorudzbenice_Proizvodi_ProizvodSifraProizvoda",
                        column: x => x.ProizvodSifraProizvoda,
                        principalTable: "Proizvodi",
                        principalColumn: "SifraProizvoda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbennice_kupacPiB",
                table: "Porudzbennice",
                column: "kupacPiB");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbennice_odgovornoLiceSifraRadnika",
                table: "Porudzbennice",
                column: "odgovornoLiceSifraRadnika");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePorudzbenice_porudzbenicaID",
                table: "StavkePorudzbenice",
                column: "porudzbenicaID");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePorudzbenice_ProizvodSifraProizvoda",
                table: "StavkePorudzbenice",
                column: "ProizvodSifraProizvoda");
        }
    }
}
