using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHSManagement.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProgramme_Programme_ProgrammesId",
                table: "CourseProgramme");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammeUser_Programme_ProgrammeId",
                table: "ProgrammeUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programme",
                table: "Programme");

            migrationBuilder.RenameTable(
                name: "Programme",
                newName: "Programmes");

            migrationBuilder.AddColumn<string>(
                name: "YhNumber",
                table: "Programmes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programmes",
                table: "Programmes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProgramme_Programmes_ProgrammesId",
                table: "CourseProgramme",
                column: "ProgrammesId",
                principalTable: "Programmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammeUser_Programmes_ProgrammeId",
                table: "ProgrammeUser",
                column: "ProgrammeId",
                principalTable: "Programmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProgramme_Programmes_ProgrammesId",
                table: "CourseProgramme");

            migrationBuilder.DropForeignKey(
                name: "FK_ProgrammeUser_Programmes_ProgrammeId",
                table: "ProgrammeUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programmes",
                table: "Programmes");

            migrationBuilder.DropColumn(
                name: "YhNumber",
                table: "Programmes");

            migrationBuilder.RenameTable(
                name: "Programmes",
                newName: "Programme");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programme",
                table: "Programme",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProgramme_Programme_ProgrammesId",
                table: "CourseProgramme",
                column: "ProgrammesId",
                principalTable: "Programme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProgrammeUser_Programme_ProgrammeId",
                table: "ProgrammeUser",
                column: "ProgrammeId",
                principalTable: "Programme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
