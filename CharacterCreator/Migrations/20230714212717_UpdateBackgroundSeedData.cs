using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateBackgroundSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Backgrounds_BackgroundId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_BackgroundId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "BackgroundId",
                table: "Skills");

            migrationBuilder.CreateTable(
                name: "BackgroundSkills",
                columns: table => new
                {
                    BackgroundSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BackgroundId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackgroundSkills", x => x.BackgroundSkillId);
                    table.ForeignKey(
                        name: "FK_BackgroundSkills_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackgroundSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "CharacterClassId", "CharacterId", "SkillName" },
                values: new object[,]
                {
                    { 1, null, null, "Acrobatics" },
                    { 2, null, null, "Arcana" },
                    { 3, null, null, "Athletics" },
                    { 4, null, null, "Crafting" },
                    { 5, null, null, "Deception" },
                    { 6, null, null, "Diplomacy" },
                    { 7, null, null, "Intimidation" },
                    { 8, null, null, "Medicine" },
                    { 9, null, null, "Nature" },
                    { 10, null, null, "Occultism" },
                    { 11, null, null, "Performance" },
                    { 12, null, null, "Religion" },
                    { 13, null, null, "Society" },
                    { 14, null, null, "Stealth" },
                    { 15, null, null, "Survival" },
                    { 16, null, null, "Thievery" },
                    { 17, null, null, "Scribing Lore" },
                    { 18, null, null, "Underworld Lore" },
                    { 19, null, null, "Terrain Lore" }
                });

            migrationBuilder.InsertData(
                table: "SkillFeats",
                columns: new[] { "SkillFeatId", "PrerequisiteTraining", "RequiredLevel", "SkillFeatDescription", "SkillFeatName", "SkillId" },
                values: new object[] { 1, "trained", 1, "You've researched many faiths enough to recognize notions about them that are unlikely to be true. If you roll a critical failure at a Religion check to decipher writing of a religious nature or to recall knowledge about the tenets of faiths, you get a failure instead. When attempting to recall knowledge about the tenets of your own faith, if you roll a failure, you get a success instead, and if you roll a success, you get a critical success instead.", "Student of the Canon", 12 });

            migrationBuilder.InsertData(
                table: "SkillFeats",
                columns: new[] { "SkillFeatId", "PrerequisiteTraining", "RequiredLevel", "SkillFeatDescription", "SkillFeatName", "SkillId" },
                values: new object[] { 2, "trained", 1, "You often smuggle things past the authorities. When the GM rolls your Stealth check to see if a passive observer notices a small item you have concealed, the GM uses the number rolled or 10—whichever is higher—as the result of your die roll, adding it to your Stealth modifier to determine your Stealth check result. If you're a master in Stealth, the GM uses the number rolled or 15, and if you're legendary in Stealth, you automatically succeed at hiding a small concealed item from passive observers. This provides no benefits when a creature attempts a Perception check while actively searching you for hidden items. Due to your smuggling skill, you're more likely to find more lucrative smuggling jobs when using Underworld Lore to Earn Income.", "Experienced Smuggler", 14 });

            migrationBuilder.InsertData(
                table: "SkillFeats",
                columns: new[] { "SkillFeatId", "PrerequisiteTraining", "RequiredLevel", "SkillFeatDescription", "SkillFeatName", "SkillId" },
                values: new object[] { 3, "trained", 1, "While using Survival to Subsist, if you roll any result worse than a success, you get a success. On a success, you can provide subsistence living for yourself and four additional creatures, and on a critical success, you can take care of twice as many creatures as on a success. Each time your proficiency rank in Survival increases, double the number of additional creatures you can take care of on a success (to eight if you're an expert, 16 if you're a master, or 32 if you're legendary). You can choose to care for half the number of additional creatures and provide a comfortable living instead of subsistence living. Multiple smaller creatures or creatures with significantly smaller appetites than a human are counted as a single creature for this feat, and larger creatures or those with significantly greater appetites each count as multiple creatures. The GM determines how much a non-human creature needs to eat.", "Forager", 15 });

            migrationBuilder.InsertData(
                table: "Backgrounds",
                columns: new[] { "BackgroundId", "BackgroundDescription", "BackgroundName", "SkillFeatId" },
                values: new object[] { 1, "You spent your early days in a religious monastery or cloister. You may have traveled out into the world to spread the message of your religion or because you cast away the teachings of your faith, but deep down you'll always carry within you the lessons you learned.", "Acolyte", 1 });

            migrationBuilder.InsertData(
                table: "Backgrounds",
                columns: new[] { "BackgroundId", "BackgroundDescription", "BackgroundName", "SkillFeatId" },
                values: new object[] { 2, "As an unscrupulous independent or as a member of an underworld organization, you lived a life of crime. You might have become an adventurer to seek redemption, to escape the law, or simply to get access to bigger and better loot.", "Criminal", 2 });

            migrationBuilder.InsertData(
                table: "Backgrounds",
                columns: new[] { "BackgroundId", "BackgroundDescription", "BackgroundName", "SkillFeatId" },
                values: new object[] { 3, "You called the wilderness home as you found trails and guided travelers. Your wanderlust could have called you to the adventuring life, or perhaps you served as a scout for soldiers and found you liked battle.", "Scout", 3 });

            migrationBuilder.InsertData(
                table: "BackgroundBoosts",
                columns: new[] { "BackgroundBoostId", "BackgroundId", "BoostId" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 1, 5 },
                    { 3, 1, 7 },
                    { 4, 2, 2 },
                    { 5, 2, 4 },
                    { 6, 2, 7 },
                    { 7, 3, 2 },
                    { 8, 3, 5 },
                    { 9, 3, 7 }
                });

            migrationBuilder.InsertData(
                table: "BackgroundSkills",
                columns: new[] { "BackgroundSkillId", "BackgroundId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 12 },
                    { 2, 1, 17 },
                    { 3, 2, 14 },
                    { 4, 2, 18 },
                    { 5, 3, 15 },
                    { 6, 3, 19 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundSkills_BackgroundId",
                table: "BackgroundSkills",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundSkills_SkillId",
                table: "BackgroundSkills",
                column: "SkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackgroundSkills");

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BackgroundBoosts",
                keyColumn: "BackgroundBoostId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Backgrounds",
                keyColumn: "BackgroundId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Backgrounds",
                keyColumn: "BackgroundId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Backgrounds",
                keyColumn: "BackgroundId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SkillFeats",
                keyColumn: "SkillFeatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SkillFeats",
                keyColumn: "SkillFeatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SkillFeats",
                keyColumn: "SkillFeatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15);

            migrationBuilder.AddColumn<int>(
                name: "BackgroundId",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_BackgroundId",
                table: "Skills",
                column: "BackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Backgrounds_BackgroundId",
                table: "Skills",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId");
        }
    }
}
