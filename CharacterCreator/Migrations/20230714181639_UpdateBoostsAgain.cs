using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateBoostsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BackgroundBoost_Backgrounds_BackgroundId",
                table: "BackgroundBoost");

            migrationBuilder.DropForeignKey(
                name: "FK_BackgroundBoost_Boosts_BoostId",
                table: "BackgroundBoost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundBoost",
                table: "BackgroundBoost");

            migrationBuilder.RenameTable(
                name: "BackgroundBoost",
                newName: "BackgroundBoosts");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundBoost_BoostId",
                table: "BackgroundBoosts",
                newName: "IX_BackgroundBoosts_BoostId");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundBoost_BackgroundId",
                table: "BackgroundBoosts",
                newName: "IX_BackgroundBoosts_BackgroundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundBoosts",
                table: "BackgroundBoosts",
                column: "BackgroundBoostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BackgroundBoosts_Backgrounds_BackgroundId",
                table: "BackgroundBoosts",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BackgroundBoosts_Boosts_BoostId",
                table: "BackgroundBoosts",
                column: "BoostId",
                principalTable: "Boosts",
                principalColumn: "BoostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BackgroundBoosts_Backgrounds_BackgroundId",
                table: "BackgroundBoosts");

            migrationBuilder.DropForeignKey(
                name: "FK_BackgroundBoosts_Boosts_BoostId",
                table: "BackgroundBoosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundBoosts",
                table: "BackgroundBoosts");

            migrationBuilder.RenameTable(
                name: "BackgroundBoosts",
                newName: "BackgroundBoost");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundBoosts_BoostId",
                table: "BackgroundBoost",
                newName: "IX_BackgroundBoost_BoostId");

            migrationBuilder.RenameIndex(
                name: "IX_BackgroundBoosts_BackgroundId",
                table: "BackgroundBoost",
                newName: "IX_BackgroundBoost_BackgroundId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundBoost",
                table: "BackgroundBoost",
                column: "BackgroundBoostId");

            migrationBuilder.AddForeignKey(
                name: "FK_BackgroundBoost_Backgrounds_BackgroundId",
                table: "BackgroundBoost",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BackgroundBoost_Boosts_BoostId",
                table: "BackgroundBoost",
                column: "BoostId",
                principalTable: "Boosts",
                principalColumn: "BoostId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
