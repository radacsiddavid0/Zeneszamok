using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Zeneszamok.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Eloadok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(type: "longtext", nullable: false),
                    Nemzetiseg = table.Column<string>(type: "longtext", nullable: false),
                    Elo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eloadok", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kiadok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(type: "longtext", nullable: false),
                    AlapitasiEv = table.Column<short>(type: "smallint", nullable: false),
                    Cim = table.Column<string>(type: "longtext", nullable: false),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kiadok", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EloadoKiado",
                columns: table => new
                {
                    EloadokId = table.Column<int>(type: "int", nullable: false),
                    KiadokId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EloadoKiado", x => new { x.EloadokId, x.KiadokId });
                    table.ForeignKey(
                        name: "FK_EloadoKiado_Eloadok_EloadokId",
                        column: x => x.EloadokId,
                        principalTable: "Eloadok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EloadoKiado_Kiadok_KiadokId",
                        column: x => x.KiadokId,
                        principalTable: "Kiadok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Zeneszamok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nev = table.Column<string>(type: "longtext", nullable: false),
                    MegjelenesiEv = table.Column<int>(type: "int", nullable: false),
                    Hossz = table.Column<double>(type: "double", nullable: false),
                    Jogdija = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    EloadoId = table.Column<int>(type: "int", nullable: false),
                    KiadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zeneszamok", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zeneszamok_Eloadok_EloadoId",
                        column: x => x.EloadoId,
                        principalTable: "Eloadok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zeneszamok_Kiadok_KiadoId",
                        column: x => x.KiadoId,
                        principalTable: "Kiadok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EloadoKiado_KiadokId",
                table: "EloadoKiado",
                column: "KiadokId");

            migrationBuilder.CreateIndex(
                name: "IX_Zeneszamok_EloadoId",
                table: "Zeneszamok",
                column: "EloadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Zeneszamok_KiadoId",
                table: "Zeneszamok",
                column: "KiadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EloadoKiado");

            migrationBuilder.DropTable(
                name: "Zeneszamok");

            migrationBuilder.DropTable(
                name: "Eloadok");

            migrationBuilder.DropTable(
                name: "Kiadok");
        }
    }
}
