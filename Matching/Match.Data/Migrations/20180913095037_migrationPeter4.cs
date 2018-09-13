using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class migrationPeter4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Persons_PersonId",
                table: "Interests");

            migrationBuilder.DropForeignKey(
                name: "FK_Interests_InterestType_TypeId",
                table: "Interests");

            migrationBuilder.DropTable(
                name: "InterestType");

            migrationBuilder.DropIndex(
                name: "IX_Interests_TypeId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "FoodNdrinks",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "HealthNExercise",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "Literature",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "Movie",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "Music",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "Travel",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Interests");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Interests",
                newName: "personId");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_PersonId",
                table: "Interests",
                newName: "IX_Interests_personId");

            migrationBuilder.AddColumn<int>(
                name: "PersonInterest",
                table: "Interests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Persons_personId",
                table: "Interests",
                column: "personId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_Persons_personId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "PersonInterest",
                table: "Interests");

            migrationBuilder.RenameColumn(
                name: "personId",
                table: "Interests",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Interests_personId",
                table: "Interests",
                newName: "IX_Interests_PersonId");

            migrationBuilder.AddColumn<string>(
                name: "FoodNdrinks",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthNExercise",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Literature",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Movie",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Music",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Travel",
                table: "Interests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Interests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InterestType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonInterest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_TypeId",
                table: "Interests",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_Persons_PersonId",
                table: "Interests",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interests_InterestType_TypeId",
                table: "Interests",
                column: "TypeId",
                principalTable: "InterestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
