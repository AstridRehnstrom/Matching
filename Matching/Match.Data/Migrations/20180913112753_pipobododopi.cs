using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class pipobododopi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Persons_personId",
                table: "Interests");

            migrationBuilder.RenameColumn(
                name: "personId",
                table: "Interests",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_personId",
                table: "Interests",
                newName: "IX_Interests_PersonId");

            migrationBuilder.CreateTable(
                name: "InterestsPerson",
                columns: table => new
                {
                    InterestsId = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestsPerson", x => new { x.PersonId, x.InterestsId });
                    table.ForeignKey(
                        name: "FK_InterestsPerson_Interests_InterestsId",
                        column: x => x.InterestsId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterestsPerson_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterestsPerson_InterestsId",
                table: "InterestsPerson",
                column: "InterestsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Persons_PersonId",
                table: "Interests",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Persons_PersonId",
                table: "Interests");

            migrationBuilder.DropTable(
                name: "InterestsPerson");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Interests",
                newName: "personId");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_PersonId",
                table: "Interests",
                newName: "IX_Interests_personId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Persons_personId",
                table: "Interests",
                column: "personId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
