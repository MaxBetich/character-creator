using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateAncestrySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ancestries",
                keyColumn: "AncestryId",
                keyValue: 1,
                column: "Trait",
                value: "Humans have no distinctive physical characteristics.");

            migrationBuilder.InsertData(
                table: "Ancestries",
                columns: new[] { "AncestryId", "AncestryDescription", "AncestryName", "Size", "Speed", "StartingHitpoints", "Trait" },
                values: new object[] { 2, "Dwarves are squat, hardy folk known for their skill at metalworking, and most at home in their ancient undergound cities", "Dwarf", "medium", "20 feet", 10, "Darkvision: Dwarves can see in darkness and dim light just as well as in bright light, though their vision in such conditions is limited to black and white." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ancestries",
                keyColumn: "AncestryId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Ancestries",
                keyColumn: "AncestryId",
                keyValue: 1,
                column: "Trait",
                value: "Humans have no distinctive physical characteristics");
        }
    }
}
