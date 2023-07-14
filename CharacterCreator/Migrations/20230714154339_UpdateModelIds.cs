using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CharacterCreator.Migrations
{
    public partial class UpdateModelIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AncestryFeats_Ancestries_AncestryId",
                table: "AncestryFeats");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Ancestries_AncestryId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Backgrounds_BackgroundId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterClasses_CharacterClassId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassFeats_CharacterClasses_CharacterClassId",
                table: "ClassFeats");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterClassId",
                table: "ClassFeats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterClassId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BackgroundId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AncestryId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AncestryId",
                table: "AncestryFeats",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AncestryFeats_Ancestries_AncestryId",
                table: "AncestryFeats",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Ancestries_AncestryId",
                table: "Characters",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Backgrounds_BackgroundId",
                table: "Characters",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterClasses_CharacterClassId",
                table: "Characters",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "CharacterClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassFeats_CharacterClasses_CharacterClassId",
                table: "ClassFeats",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "CharacterClassId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AncestryFeats_Ancestries_AncestryId",
                table: "AncestryFeats");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Ancestries_AncestryId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Backgrounds_BackgroundId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_CharacterClasses_CharacterClassId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassFeats_CharacterClasses_CharacterClassId",
                table: "ClassFeats");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterClassId",
                table: "ClassFeats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterClassId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BackgroundId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AncestryId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AncestryId",
                table: "AncestryFeats",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AncestryFeats_Ancestries_AncestryId",
                table: "AncestryFeats",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Ancestries_AncestryId",
                table: "Characters",
                column: "AncestryId",
                principalTable: "Ancestries",
                principalColumn: "AncestryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Backgrounds_BackgroundId",
                table: "Characters",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "BackgroundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_CharacterClasses_CharacterClassId",
                table: "Characters",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "CharacterClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassFeats_CharacterClasses_CharacterClassId",
                table: "ClassFeats",
                column: "CharacterClassId",
                principalTable: "CharacterClasses",
                principalColumn: "CharacterClassId");
        }
    }
}
