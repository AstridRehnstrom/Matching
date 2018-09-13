using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class giipoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_ContactInfo_ContactInfoId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "RelationType");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ContactInfoId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "ContactInfo",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenderType = table.Column<int>(nullable: false),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gender_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_PersonId",
                table: "ContactInfo",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Gender_PersonId",
                table: "Gender",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfo_Persons_PersonId",
                table: "ContactInfo",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfo_Persons_PersonId",
                table: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_ContactInfo_PersonId",
                table: "ContactInfo");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "ContactInfo");

            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RelationType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelationType_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ContactInfoId",
                table: "Persons",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_RelationType_PersonId",
                table: "RelationType",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_ContactInfo_ContactInfoId",
                table: "Persons",
                column: "ContactInfoId",
                principalTable: "ContactInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
