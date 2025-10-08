using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorPastaShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class Aanpassing1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Pasta_PastaId",
                table: "Bestellingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Porties_PortieId",
                table: "Bestellingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Bestellingen_Sauzen_SausId",
                table: "Bestellingen");

            migrationBuilder.DropTable(
                name: "Pasta");

            migrationBuilder.DropTable(
                name: "Porties");

            migrationBuilder.DropTable(
                name: "Sauzen");

            migrationBuilder.DropIndex(
                name: "IX_Bestellingen_PastaId",
                table: "Bestellingen");

            migrationBuilder.DropIndex(
                name: "IX_Bestellingen_PortieId",
                table: "Bestellingen");

            migrationBuilder.DropIndex(
                name: "IX_Bestellingen_SausId",
                table: "Bestellingen");

            migrationBuilder.RenameColumn(
                name: "SausId",
                table: "Bestellingen",
                newName: "Saus");

            migrationBuilder.RenameColumn(
                name: "PortieId",
                table: "Bestellingen",
                newName: "PastaSoort");

            migrationBuilder.RenameColumn(
                name: "PastaId",
                table: "Bestellingen",
                newName: "Grootte");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Saus",
                table: "Bestellingen",
                newName: "SausId");

            migrationBuilder.RenameColumn(
                name: "PastaSoort",
                table: "Bestellingen",
                newName: "PortieId");

            migrationBuilder.RenameColumn(
                name: "Grootte",
                table: "Bestellingen",
                newName: "PastaId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bestellingen_Pasta_PastaId",
                table: "Bestellingen",
                column: "PastaId",
                principalTable: "Pasta",
                principalColumn: "PastaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bestellingen_Porties_PortieId",
                table: "Bestellingen",
                column: "PortieId",
                principalTable: "Porties",
                principalColumn: "PortieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bestellingen_Sauzen_SausId",
                table: "Bestellingen",
                column: "SausId",
                principalTable: "Sauzen",
                principalColumn: "SausId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
