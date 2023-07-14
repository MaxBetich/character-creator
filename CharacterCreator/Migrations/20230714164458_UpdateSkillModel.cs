using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateSkillModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_SkillFeats_SkillFeatId",
                table: "Backgrounds");

            migrationBuilder.DropColumn(
                name: "PrerequisiteSkill",
                table: "SkillFeats");

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "SkillFeats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "SkillFeatId",
                table: "Backgrounds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SkillName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BackgroundId = table.Column<int>(type: "int", nullable: true),
                    CharacterClassId = table.Column<int>(type: "int", nullable: true),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skills_Backgrounds_BackgroundId",
                        column: x => x.BackgroundId,
                        principalTable: "Backgrounds",
                        principalColumn: "BackgroundId");
                    table.ForeignKey(
                        name: "FK_Skills_CharacterClasses_CharacterClassId",
                        column: x => x.CharacterClassId,
                        principalTable: "CharacterClasses",
                        principalColumn: "CharacterClassId");
                    table.ForeignKey(
                        name: "FK_Skills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SkillFeats_SkillId",
                table: "SkillFeats",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_BackgroundId",
                table: "Skills",
                column: "BackgroundId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterClassId",
                table: "Skills",
                column: "CharacterClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_CharacterId",
                table: "Skills",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_SkillFeats_SkillFeatId",
                table: "Backgrounds",
                column: "SkillFeatId",
                principalTable: "SkillFeats",
                principalColumn: "SkillFeatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillFeats_Skills_SkillId",
                table: "SkillFeats",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backgrounds_SkillFeats_SkillFeatId",
                table: "Backgrounds");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillFeats_Skills_SkillId",
                table: "SkillFeats");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_SkillFeats_SkillId",
                table: "SkillFeats");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "SkillFeats");

            migrationBuilder.AddColumn<string>(
                name: "PrerequisiteSkill",
                table: "SkillFeats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "SkillFeatId",
                table: "Backgrounds",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Backgrounds_SkillFeats_SkillFeatId",
                table: "Backgrounds",
                column: "SkillFeatId",
                principalTable: "SkillFeats",
                principalColumn: "SkillFeatId");
        }
    }
}
