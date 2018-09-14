using Microsoft.EntityFrameworkCore.Migrations;

namespace Match.Data.Database.Migrations
{
    public partial class DbSetalltabels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complexion_Persons_PersonId",
                table: "Complexion");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfo_Persons_PersonId",
                table: "ContactInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Persons_PersonId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Family_Persons_PersonId",
                table: "Family");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupation_Persons_PersonId",
                table: "Occupation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Family",
                table: "Family");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Education",
                table: "Education");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactInfo",
                table: "ContactInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complexion",
                table: "Complexion");

            migrationBuilder.RenameTable(
                name: "Occupation",
                newName: "Occupations");

            migrationBuilder.RenameTable(
                name: "Family",
                newName: "Families");

            migrationBuilder.RenameTable(
                name: "Education",
                newName: "Educations");

            migrationBuilder.RenameTable(
                name: "ContactInfo",
                newName: "ContactInfos");

            migrationBuilder.RenameTable(
                name: "Complexion",
                newName: "Complexions");

            migrationBuilder.RenameIndex(
                name: "IX_Occupation_PersonId",
                table: "Occupations",
                newName: "IX_Occupations_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Family_PersonId",
                table: "Families",
                newName: "IX_Families_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Education_PersonId",
                table: "Educations",
                newName: "IX_Educations_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInfo_PersonId",
                table: "ContactInfos",
                newName: "IX_ContactInfos_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Complexion_PersonId",
                table: "Complexions",
                newName: "IX_Complexions_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupations",
                table: "Occupations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Families",
                table: "Families",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactInfos",
                table: "ContactInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complexions",
                table: "Complexions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complexions_Persons_PersonId",
                table: "Complexions",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfos_Persons_PersonId",
                table: "ContactInfos",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Persons_PersonId",
                table: "Educations",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Families_Persons_PersonId",
                table: "Families",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occupations_Persons_PersonId",
                table: "Occupations",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complexions_Persons_PersonId",
                table: "Complexions");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactInfos_Persons_PersonId",
                table: "ContactInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Persons_PersonId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Families_Persons_PersonId",
                table: "Families");

            migrationBuilder.DropForeignKey(
                name: "FK_Occupations_Persons_PersonId",
                table: "Occupations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Occupations",
                table: "Occupations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Families",
                table: "Families");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactInfos",
                table: "ContactInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complexions",
                table: "Complexions");

            migrationBuilder.RenameTable(
                name: "Occupations",
                newName: "Occupation");

            migrationBuilder.RenameTable(
                name: "Families",
                newName: "Family");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "Education");

            migrationBuilder.RenameTable(
                name: "ContactInfos",
                newName: "ContactInfo");

            migrationBuilder.RenameTable(
                name: "Complexions",
                newName: "Complexion");

            migrationBuilder.RenameIndex(
                name: "IX_Occupations_PersonId",
                table: "Occupation",
                newName: "IX_Occupation_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Families_PersonId",
                table: "Family",
                newName: "IX_Family_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Educations_PersonId",
                table: "Education",
                newName: "IX_Education_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactInfos_PersonId",
                table: "ContactInfo",
                newName: "IX_ContactInfo_PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Complexions_PersonId",
                table: "Complexion",
                newName: "IX_Complexion_PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Occupation",
                table: "Occupation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Family",
                table: "Family",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Education",
                table: "Education",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactInfo",
                table: "ContactInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complexion",
                table: "Complexion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complexion_Persons_PersonId",
                table: "Complexion",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInfo_Persons_PersonId",
                table: "ContactInfo",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Persons_PersonId",
                table: "Education",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Family_Persons_PersonId",
                table: "Family",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Occupation_Persons_PersonId",
                table: "Occupation",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
