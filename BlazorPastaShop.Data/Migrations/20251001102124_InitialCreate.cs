using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPastaShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klanten",
                columns: table => new
                {
                    KlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeboorteDatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klanten", x => x.KlantId);
                });

            migrationBuilder.CreateTable(
                name: "Pasta",
                columns: table => new
                {
                    PastaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pasta", x => x.PastaId);
                });

            migrationBuilder.CreateTable(
                name: "Porties",
                columns: table => new
                {
                    PortieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grootte = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porties", x => x.PortieId);
                });

            migrationBuilder.CreateTable(
                name: "Sauzen",
                columns: table => new
                {
                    SausId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauzen", x => x.SausId);
                });

            migrationBuilder.CreateTable(
                name: "Bestellingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PastaId = table.Column<int>(type: "int", nullable: false),
                    PortieId = table.Column<int>(type: "int", nullable: false),
                    SausId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestellingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Pasta_PastaId",
                        column: x => x.PastaId,
                        principalTable: "Pasta",
                        principalColumn: "PastaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Porties_PortieId",
                        column: x => x.PortieId,
                        principalTable: "Porties",
                        principalColumn: "PortieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bestellingen_Sauzen_SausId",
                        column: x => x.SausId,
                        principalTable: "Sauzen",
                        principalColumn: "SausId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_PastaId",
                table: "Bestellingen",
                column: "PastaId");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_PortieId",
                table: "Bestellingen",
                column: "PortieId");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellingen_SausId",
                table: "Bestellingen",
                column: "SausId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bestellingen");

            migrationBuilder.DropTable(
                name: "Klanten");

            migrationBuilder.DropTable(
                name: "Pasta");

            migrationBuilder.DropTable(
                name: "Porties");

            migrationBuilder.DropTable(
                name: "Sauzen");
        }
    }
}
