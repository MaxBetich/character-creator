using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class ChangeCharacterAndClassProficiencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartingHitpoints",
                table: "CharacterClasses",
                newName: "StartingSkillCount");

            migrationBuilder.AddColumn<string>(
                name: "AdvancedProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FortitudeSaveProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HeavyArmorProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LightArmorProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MartialProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MediumArmorProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PerceptionProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ReflexSaveProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SimpleProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UnarmedProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UnarmoredProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "WillSaveProficiency",
                table: "Characters",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AdvancedProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ClassHitpoints",
                table: "CharacterClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FortitudeSaveProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HeavyArmorProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LightArmorProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MartialProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "MediumArmorProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PerceptionProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ReflexSaveProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "SimpleProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UnarmedProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "UnarmoredProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "WillSaveProficiency",
                table: "CharacterClasses",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "CharacterClasses",
                columns: new[] { "CharacterClassId", "AdvancedProficiency", "CharacterClassDescription", "CharacterClassName", "ClassHitpoints", "FortitudeSaveProficiency", "HeavyArmorProficiency", "KeyAbility", "LightArmorProficiency", "MartialProficiency", "MediumArmorProficiency", "PerceptionProficiency", "ReflexSaveProficiency", "SimpleProficiency", "StartingSkillCount", "UnarmedProficiency", "UnarmoredProficiency", "WillSaveProficiency" },
                values: new object[] { 1, "Trained", "Fighting for honor, greed, loyalty, or simply the thrill of battle, you are an undisputed master of weaponry and combat techniques. You combine your actions through clever combinations of opening moves, finishing strikes, and counterattacks whenever your foes are unwise enough to drop their guard. Whether you are a knight, mercenary, sharpshooter, or blade master, you have honed your martial skills into an art form and perform devastating critical attacks on your enemies.", "Fighter", 10, "Expert", "Trained", "Strength or Dexterity", "Trained", "Expert", "Trained", "Expert", "Expert", "Expert", 3, "Expert", "Trained", "Trained" });

            migrationBuilder.InsertData(
                table: "CharacterClasses",
                columns: new[] { "CharacterClassId", "AdvancedProficiency", "CharacterClassDescription", "CharacterClassName", "ClassHitpoints", "FortitudeSaveProficiency", "HeavyArmorProficiency", "KeyAbility", "LightArmorProficiency", "MartialProficiency", "MediumArmorProficiency", "PerceptionProficiency", "ReflexSaveProficiency", "SimpleProficiency", "StartingSkillCount", "UnarmedProficiency", "UnarmoredProficiency", "WillSaveProficiency" },
                values: new object[] { 2, "Untrained", "The strength of your fist flows from your mind and spirit. You seek perfection—honing your body into a flawless instrument and your mind into an orderly bastion of wisdom. You're a fierce combatant renowned for martial arts skills and combat stances that grant you unique fighting moves. While the challenge of mastering many fighting styles drives you to great heights, you also enjoy meditating on philosophical questions and discovering new ways to obtain peace and enlightenment.", "Monk", 10, "Expert", "Untrained", "Dexterity or Strength", "Untrained", "Untrained", "Untrained", "Trained", "Expert", "Trained", 4, "Trained", "Expert", "Expert" });

            migrationBuilder.InsertData(
                table: "CharacterClasses",
                columns: new[] { "CharacterClassId", "AdvancedProficiency", "CharacterClassDescription", "CharacterClassName", "ClassHitpoints", "FortitudeSaveProficiency", "HeavyArmorProficiency", "KeyAbility", "LightArmorProficiency", "MartialProficiency", "MediumArmorProficiency", "PerceptionProficiency", "ReflexSaveProficiency", "SimpleProficiency", "StartingSkillCount", "UnarmedProficiency", "UnarmoredProficiency", "WillSaveProficiency" },
                values: new object[] { 3, "Untrained", "You are skilled and opportunistic. Using your sharp wits and quick reactions, you take advantage of your opponents’ missteps and strike where it hurts most. You play a dangerous game, seeking thrills and testing your skills, and likely don't care much for any laws that happen to get in your way. While the path of every rogue is unique and riddled with danger, the one thing you all share in common is the breadth and depth of your skills.", "Rogue", 8, "Trained", "Untrained", "Dexterity", "Trained", "Trained", "Untrained", "Expert", "Expert", "Trained", 8, "Trained", "Trained", "Expert" });

            migrationBuilder.InsertData(
                table: "CharacterClassSkills",
                columns: new[] { "CharacterClassSkillId", "CharacterClassId", "SkillId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "CharacterClassSkills",
                columns: new[] { "CharacterClassSkillId", "CharacterClassId", "SkillId" },
                values: new object[] { 2, 1, 3 });

            migrationBuilder.InsertData(
                table: "CharacterClassSkills",
                columns: new[] { "CharacterClassSkillId", "CharacterClassId", "SkillId" },
                values: new object[] { 3, 3, 14 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterClassSkills",
                keyColumn: "CharacterClassSkillId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CharacterClassSkills",
                keyColumn: "CharacterClassSkillId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CharacterClassSkills",
                keyColumn: "CharacterClassSkillId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CharacterClasses",
                keyColumn: "CharacterClassId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CharacterClasses",
                keyColumn: "CharacterClassId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CharacterClasses",
                keyColumn: "CharacterClassId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AdvancedProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "FortitudeSaveProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HeavyArmorProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LightArmorProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MartialProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "MediumArmorProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "PerceptionProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ReflexSaveProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SimpleProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "UnarmedProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "UnarmoredProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "WillSaveProficiency",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AdvancedProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "ClassHitpoints",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "FortitudeSaveProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "HeavyArmorProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "LightArmorProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "MartialProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "MediumArmorProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "PerceptionProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "ReflexSaveProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "SimpleProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "UnarmedProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "UnarmoredProficiency",
                table: "CharacterClasses");

            migrationBuilder.DropColumn(
                name: "WillSaveProficiency",
                table: "CharacterClasses");

            migrationBuilder.RenameColumn(
                name: "StartingSkillCount",
                table: "CharacterClasses",
                newName: "StartingHitpoints");
        }
    }
}
