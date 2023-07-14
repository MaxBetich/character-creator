using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class AddBoostsAndFlawsToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boost_Ancestries_AncestryId",
                table: "Boost");

            migrationBuilder.DropForeignKey(
                name: "FK_Boost_Backgrounds_BackgroundId",
                table: "Boost");

            migrationBuilder.DropForeignKey(
                name: "FK_Flaw_Ancestries_AncestryId",
                table: "Flaw");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flaw",
                table: "Flaw");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boost",
                table: "Boost");

            migrationBuilder.RenameTable(
                name: "Flaw",
                newName: "Flaws");

            migrationBuilder.RenameTable(
                name: "Boost",
                newName: "Boosts");

            migrationBuilder.RenameIndex(
                name: "IX_Flaw_AncestryId",
                table: "Flaws",
                newName: "IX_Flaws_AncestryId");

            migrationBuilder.RenameIndex(
                name: "IX_Boost_BackgroundId",
                table: "Boosts",
                newName: "IX_Boosts_BackgroundId");

            migrationBuilder.RenameIndex(
                name: "IX_Boost_AncestryId",
                table: "Boosts",
                newName: "IX_Boosts_AncestryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flaws",
                table: "Flaws",
                column: "FlawId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boosts",
                table: "Boosts",
                column: "BoostId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Flaws_Ancestries_AncestryId",
                table: "Flaws",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boosts_Ancestries_AncestryId",
                table: "Boosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Boosts_Backgrounds_BackgroundId",
                table: "Boosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Flaws_Ancestries_AncestryId",
                table: "Flaws");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flaws",
                table: "Flaws");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Boosts",
                table: "Boosts");

            migrationBuilder.RenameTable(
                name: "Flaws",
                newName: "Flaw");

            migrationBuilder.RenameTable(
                name: "Boosts",
                newName: "Boost");

            migrationBuilder.RenameIndex(
                name: "IX_Flaws_AncestryId",
                table: "Flaw",
                newName: "IX_Flaw_AncestryId");

            migrationBuilder.RenameIndex(
                name: "IX_Boosts_BackgroundId",
                table: "Boost",
                newName: "IX_Boost_BackgroundId");

            migrationBuilder.RenameIndex(
                name: "IX_Boosts_AncestryId",
                table: "Boost",
                newName: "IX_Boost_AncestryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flaw",
                table: "Flaw",
                column: "FlawId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Boost",
                table: "Boost",
                column: "BoostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boost_Ancestries_AncestryId",
                table: "Boost",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boost_Backgrounds_BackgroundId",
                table: "Boost",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flaw_Ancestries_AncestryId",
                table: "Flaw",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");
        }
    }
}
