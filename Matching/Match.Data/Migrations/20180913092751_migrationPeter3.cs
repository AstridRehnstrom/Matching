using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class migrationPeter3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Interests");

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
                name: "FK_Interests_InterestType_TypeId",
                table: "Interests",
                column: "TypeId",
                principalTable: "InterestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interests_InterestType_TypeId",
                table: "Interests");

            migrationBuilder.DropTable(
                name: "InterestType");

            migrationBuilder.DropIndex(
                name: "IX_Interests_TypeId",
                table: "Interests");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Interests");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Interests",
                nullable: false,
                defaultValue: 0);
        }
    }
}
