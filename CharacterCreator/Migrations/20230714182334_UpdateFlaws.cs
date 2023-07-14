using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateFlaws : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flaws_Ancestries_AncestryId",
                table: "Flaws");

            migrationBuilder.DropIndex(
                name: "IX_Flaws_AncestryId",
                table: "Flaws");

            migrationBuilder.DropColumn(
                name: "AncestryId",
                table: "Flaws");

            migrationBuilder.CreateTable(
                name: "AncestryFlaw",
                columns: table => new
                {
                    AncestryFlawId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FlawId = table.Column<int>(type: "int", nullable: false),
                    AncestryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestryFlaw", x => x.AncestryFlawId);
                    table.ForeignKey(
                        name: "FK_AncestryFlaw_Ancestries_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestries",
                        principalColumn: "AncestryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AncestryFlaw_Flaws_FlawId",
                        column: x => x.FlawId,
                        principalTable: "Flaws",
                        principalColumn: "FlawId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AncestryFlaw_AncestryId",
                table: "AncestryFlaw",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_AncestryFlaw_FlawId",
                table: "AncestryFlaw",
                column: "FlawId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AncestryFlaw");

            migrationBuilder.AddColumn<int>(
                name: "AncestryId",
                table: "Flaws",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flaws_AncestryId",
                table: "Flaws",
                column: "AncestryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flaws_Ancestries_AncestryId",
                table: "Flaws",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");
        }
    }
}
