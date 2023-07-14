using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class AddAncestry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ancestries",
                columns: new[] { "AncestryId", "AncestryDescription", "AncestryName", "Size", "Speed", "StartingHitpoints", "Trait" },
                values: new object[] { 1, "The most common ancestry, humans have a variety of strengths and are best represented by their versatility", "Human", "medium", "25 feet", 8, "Humans have no distinctive physical characteristics" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ancestries",
                keyColumn: "AncestryId",
                keyValue: 1);
        }
    }
}
