using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class AddBoostsAndFlaws : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boost",
                columns: table => new
                {
                    BoostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AbilityBoost = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AncestryId = table.Column<int>(type: "int", nullable: true),
                    BackgroundId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boost", x => x.BoostId);
                    table.ForeignKey(
                        name: "FK_Boost_Ancestries_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestries",
                        principalColumn: "AncestryId");
                    table.ForeignKey(
                        name: "FK_Boost_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Flaw",
                columns: table => new
                {
                    FlawId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AbilityFlaw = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AncestryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flaw", x => x.FlawId);
                    table.ForeignKey(
                        name: "FK_Flaw_Ancestries_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestries",
                        principalColumn: "AncestryId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Boost_AncestryId",
                table: "Boost",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_Boost_BackgroundId",
                table: "Boost",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Flaw_AncestryId",
                table: "Flaw",
                column: "AncestryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boost");

            migrationBuilder.DropTable(
                name: "Flaw");
        }
    }
}
