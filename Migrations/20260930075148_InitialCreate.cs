using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend_Rider.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    KundeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kodeord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.KundeId);
                });

            migrationBuilder.CreateTable(
                name: "Medarbejdere",
                columns: table => new
                {
                    MedarbejderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kodeord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medarbejdere", x => x.MedarbejderId);
                });

            migrationBuilder.CreateTable(
                name: "Sager",
                columns: table => new
                {
                    SagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivelse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategori = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Prioritet = table.Column<int>(type: "int", nullable: false),
                    Oprettet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KundeId = table.Column<int>(type: "int", nullable: false),
                    MedarbejderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sager", x => x.SagId);
                    table.ForeignKey(
                        name: "FK_Sager_Kunder_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunder",
                        principalColumn: "KundeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sager_Medarbejdere_MedarbejderId",
                        column: x => x.MedarbejderId,
                        principalTable: "Medarbejdere",
                        principalColumn: "MedarbejderId");
                });

            migrationBuilder.CreateTable(
                name: "Beskeder",
                columns: table => new
                {
                    BeskedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SagsNummer = table.Column<int>(type: "int", nullable: false),
                    Beskeden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oprettet = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SagId = table.Column<int>(type: "int", nullable: false),
                    KundeId = table.Column<int>(type: "int", nullable: true),
                    MedarbejderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beskeder", x => x.BeskedId);
                    table.ForeignKey(
                        name: "FK_Beskeder_Kunder_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunder",
                        principalColumn: "KundeId");
                    table.ForeignKey(
                        name: "FK_Beskeder_Medarbejdere_MedarbejderId",
                        column: x => x.MedarbejderId,
                        principalTable: "Medarbejdere",
                        principalColumn: "MedarbejderId");
                    table.ForeignKey(
                        name: "FK_Beskeder_Sager_SagId",
                        column: x => x.SagId,
                        principalTable: "Sager",
                        principalColumn: "SagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beskeder_KundeId",
                table: "Beskeder",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Beskeder_MedarbejderId",
                table: "Beskeder",
                column: "MedarbejderId");

            migrationBuilder.CreateIndex(
                name: "IX_Beskeder_SagId",
                table: "Beskeder",
                column: "SagId");

            migrationBuilder.CreateIndex(
                name: "IX_Sager_KundeId",
                table: "Sager",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sager_MedarbejderId",
                table: "Sager",
                column: "MedarbejderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beskeder");

            migrationBuilder.DropTable(
                name: "Sager");

            migrationBuilder.DropTable(
                name: "Kunder");

            migrationBuilder.DropTable(
                name: "Medarbejdere");
        }
    }
}
