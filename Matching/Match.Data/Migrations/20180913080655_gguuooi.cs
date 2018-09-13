using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class gguuooi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_ContactInfo_ContactInfoId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ContactInfoId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Persons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                table: "Persons",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adress = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ContactInfoId",
                table: "Persons",
                column: "ContactInfoId");

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
