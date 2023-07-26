using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBoost_Boosts_BoostId",
                table: "CharacterBoost");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBoost_Characters_CharacterId",
                table: "CharacterBoost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterBoost",
                table: "CharacterBoost");

            migrationBuilder.RenameTable(
                name: "CharacterBoost",
                newName: "CharacterBoosts");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBoost_CharacterId",
                table: "CharacterBoosts",
                newName: "IX_CharacterBoosts_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBoost_BoostId",
                table: "CharacterBoosts",
                newName: "IX_CharacterBoosts_BoostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterBoosts",
                table: "CharacterBoosts",
                column: "CharacterBoostId");

            migrationBuilder.CreateTable(
                name: "CharacterFlaws",
                columns: table => new
                {
                    CharacterFlawId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    FlawId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFlaws", x => x.CharacterFlawId);
                    table.ForeignKey(
                        name: "FK_CharacterFlaws_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFlaws_Flaws_FlawId",
                        column: x => x.FlawId,
                        principalTable: "Flaws",
                        principalColumn: "FlawId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFlaws_CharacterId",
                table: "CharacterFlaws",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFlaws_FlawId",
                table: "CharacterFlaws",
                column: "FlawId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBoosts_Boosts_BoostId",
                table: "CharacterBoosts",
                column: "BoostId",
                principalTable: "Boosts",
                principalColumn: "BoostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBoosts_Characters_CharacterId",
                table: "CharacterBoosts",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBoosts_Boosts_BoostId",
                table: "CharacterBoosts");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterBoosts_Characters_CharacterId",
                table: "CharacterBoosts");

            migrationBuilder.DropTable(
                name: "CharacterFlaws");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterBoosts",
                table: "CharacterBoosts");

            migrationBuilder.RenameTable(
                name: "CharacterBoosts",
                newName: "CharacterBoost");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBoosts_CharacterId",
                table: "CharacterBoost",
                newName: "IX_CharacterBoost_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterBoosts_BoostId",
                table: "CharacterBoost",
                newName: "IX_CharacterBoost_BoostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterBoost",
                table: "CharacterBoost",
                column: "CharacterBoostId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBoost_Boosts_BoostId",
                table: "CharacterBoost",
                column: "BoostId",
                principalTable: "Boosts",
                principalColumn: "BoostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterBoost_Characters_CharacterId",
                table: "CharacterBoost",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
