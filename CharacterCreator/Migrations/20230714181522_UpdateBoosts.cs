using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateBoosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boosts_Ancestries_AncestryId",
                table: "Boosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Boosts_Backgrounds_BackgroundId",
                table: "Boosts");

            migrationBuilder.DropIndex(
                name: "IX_Boosts_AncestryId",
                table: "Boosts");

            migrationBuilder.DropIndex(
                name: "IX_Boosts_BackgroundId",
                table: "Boosts");

            migrationBuilder.DropColumn(
                name: "AncestryId",
                table: "Boosts");

            migrationBuilder.DropColumn(
                name: "BackgroundId",
                table: "Boosts");

            migrationBuilder.CreateTable(
                name: "AncestryBoosts",
                columns: table => new
                {
                    AncestryBoostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BoostId = table.Column<int>(type: "int", nullable: false),
                    AncestryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AncestryBoosts", x => x.AncestryBoostId);
                    table.ForeignKey(
                        name: "FK_AncestryBoosts_Ancestries_AncestryId",
                        column: x => x.AncestryId,
                        principalTable: "Ancestries",
                        principalColumn: "AncestryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AncestryBoosts_Boosts_BoostId",
                        column: x => x.BoostId,
                        principalTable: "Boosts",
                        principalColumn: "BoostId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BackgroundBoost",
                columns: table => new
                {
                    BackgroundBoostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BoostId = table.Column<int>(type: "int", nullable: false),
                    BackgroundId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundBoost", x => x.BackgroundBoostId);
                    table.ForeignKey(
                        name: "FK_BackgroundBoost_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundBoost_Boosts_BoostId",
                        column: x => x.BoostId,
                        principalTable: "Boosts",
                        principalColumn: "BoostId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Boosts",
                columns: new[] { "BoostId", "AbilityBoost" },
                values: new object[,]
                {
                    { 1, "strength" },
                    { 2, "dexterity" },
                    { 3, "constitution" },
                    { 4, "intelligence" },
                    { 5, "wisdom" },
                    { 6, "charisma" },
                    { 7, "free" }
                });

            migrationBuilder.InsertData(
                table: "Flaws",
                columns: new[] { "FlawId", "AbilityFlaw", "AncestryId" },
                values: new object[,]
                {
                    { 1, "strength", null },
                    { 2, "dexterity", null },
                    { 3, "constitution", null },
                    { 4, "intelligence", null },
                    { 5, "wisdom", null },
                    { 6, "charisma", null },
                    { 7, "free", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AncestryBoosts_AncestryId",
                table: "AncestryBoosts",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_AncestryBoosts_BoostId",
                table: "AncestryBoosts",
                column: "BoostId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundBoost_BackgroundId",
                table: "BackgroundBoost",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundBoost_BoostId",
                table: "BackgroundBoost",
                column: "BoostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AncestryBoosts");

            migrationBuilder.DropTable(
                name: "BackgroundBoost");

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 7);

            migrationBuilder.AddColumn<int>(
                name: "AncestryId",
                table: "Boosts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BackgroundId",
                table: "Boosts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Boosts_AncestryId",
                table: "Boosts",
                column: "AncestryId");

            migrationBuilder.CreateIndex(
                name: "IX_Boosts_BackgroundId",
                table: "Boosts",
                column: "BackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boosts_Ancestries_AncestryId",
                table: "Boosts",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boosts_Backgrounds_BackgroundId",
                table: "Boosts",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId");
        }
    }
}
