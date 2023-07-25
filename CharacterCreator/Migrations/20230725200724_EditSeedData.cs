using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class EditSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 1,
                column: "AbilityBoost",
                value: "Strength");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 2,
                column: "AbilityBoost",
                value: "Dexterity");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 3,
                column: "AbilityBoost",
                value: "Constitution");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 4,
                column: "AbilityBoost",
                value: "Intelligence");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 5,
                column: "AbilityBoost",
                value: "Wisdom");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 6,
                column: "AbilityBoost",
                value: "Charisma");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 7,
                column: "AbilityBoost",
                value: "Free");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 1,
                column: "AbilityFlaw",
                value: "Strength");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 2,
                column: "AbilityFlaw",
                value: "Dexterity");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 3,
                column: "AbilityFlaw",
                value: "Constitution");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 4,
                column: "AbilityFlaw",
                value: "Intelligence");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 5,
                column: "AbilityFlaw",
                value: "Wisdom");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 6,
                column: "AbilityFlaw",
                value: "Charisma");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 7,
                column: "AbilityFlaw",
                value: "Free");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 1,
                column: "AbilityBoost",
                value: "strength");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 2,
                column: "AbilityBoost",
                value: "dexterity");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 3,
                column: "AbilityBoost",
                value: "constitution");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 4,
                column: "AbilityBoost",
                value: "intelligence");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 5,
                column: "AbilityBoost",
                value: "wisdom");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 6,
                column: "AbilityBoost",
                value: "charisma");

            migrationBuilder.UpdateData(
                table: "Boosts",
                keyColumn: "BoostId",
                keyValue: 7,
                column: "AbilityBoost",
                value: "free");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 1,
                column: "AbilityFlaw",
                value: "strength");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 2,
                column: "AbilityFlaw",
                value: "dexterity");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 3,
                column: "AbilityFlaw",
                value: "constitution");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 4,
                column: "AbilityFlaw",
                value: "intelligence");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 5,
                column: "AbilityFlaw",
                value: "wisdom");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 6,
                column: "AbilityFlaw",
                value: "charisma");

            migrationBuilder.UpdateData(
                table: "Flaws",
                keyColumn: "FlawId",
                keyValue: 7,
                column: "AbilityFlaw",
                value: "free");
        }
    }
}
