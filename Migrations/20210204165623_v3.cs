using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHSManagement.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProgram_Program_ProgramId",
                table: "UserProgram");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.CreateTable(
                name: "StudentProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentProgram", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgram_StudentProgram_ProgramId",
                table: "UserProgram",
                column: "ProgramId",
                principalTable: "StudentProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProgram_StudentProgram_ProgramId",
                table: "UserProgram");

            migrationBuilder.DropTable(
                name: "StudentProgram");

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseAdmin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProgramName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgram_Program_ProgramId",
                table: "UserProgram",
                column: "ProgramId",
                principalTable: "Program",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
