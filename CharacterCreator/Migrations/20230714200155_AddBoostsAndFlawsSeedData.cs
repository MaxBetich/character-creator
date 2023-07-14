using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class AddBoostsAndFlawsSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ancestries",
                columns: new[] { "AncestryId", "AncestryDescription", "AncestryName", "Size", "Speed", "StartingHitpoints", "Trait" },
                values: new object[] { 3, "Fair folk, taller and sleeker than humans and having an innate connection to the magical currents of the world.", "Elf", "medium", "30 feet", 6, "Low-Light Vision: Elves can see in dim light as though it were bright light, and ignore the concealed condition due to dim light." });

            migrationBuilder.InsertData(
                table: "AncestryBoosts",
                columns: new[] { "AncestryBoostId", "AncestryId", "BoostId" },
                values: new object[,]
                {
                    { 1, 1, 7 },
                    { 2, 1, 7 },
                    { 3, 2, 3 },
                    { 4, 2, 5 },
                    { 5, 2, 7 }
                });

            migrationBuilder.InsertData(
                table: "AncestryFlaw",
                columns: new[] { "AncestryFlawId", "AncestryId", "FlawId" },
                values: new object[] { 1, 2, 6 });

            migrationBuilder.InsertData(
                table: "AncestryBoosts",
                columns: new[] { "AncestryBoostId", "AncestryId", "BoostId" },
                values: new object[,]
                {
                    { 6, 3, 2 },
                    { 7, 3, 4 },
                    { 8, 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "AncestryFlaw",
                columns: new[] { "AncestryFlawId", "AncestryId", "FlawId" },
                values: new object[] { 2, 3, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AncestryBoosts",
                keyColumn: "AncestryBoostId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AncestryFlaw",
                keyColumn: "AncestryFlawId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AncestryFlaw",
                keyColumn: "AncestryFlawId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ancestries",
                keyColumn: "AncestryId",
                keyValue: 3);
        }
    }
}
