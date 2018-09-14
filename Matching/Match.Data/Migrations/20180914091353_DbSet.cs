using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class DbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonPersonality_Personality_PersonalityId",
                table: "PersonPersonality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personality",
                table: "Personality");

            migrationBuilder.RenameTable(
                name: "Personality",
                newName: "Personalities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personalities",
                table: "Personalities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonPersonality_Personalities_PersonalityId",
                table: "PersonPersonality",
                column: "PersonalityId",
                principalTable: "Personalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonPersonality_Personalities_PersonalityId",
                table: "PersonPersonality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personalities",
                table: "Personalities");

            migrationBuilder.RenameTable(
                name: "Personalities",
                newName: "Personality");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personality",
                table: "Personality",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonPersonality_Personality_PersonalityId",
                table: "PersonPersonality",
                column: "PersonalityId",
                principalTable: "Personality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
