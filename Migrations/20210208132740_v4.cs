using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHSManagement.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProgram");

            migrationBuilder.DropTable(
                name: "StudentProgram");

            migrationBuilder.CreateTable(
                name: "Programme",
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
                    table.PrimaryKey("PK_Programme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammeUser",
                columns: table => new
                {
                    MembersId = table.Column<int>(type: "int", nullable: false),
                    ProgrammeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammeUser", x => new { x.MembersId, x.ProgrammeId });
                    table.ForeignKey(
                        name: "FK_ProgrammeUser_Programme_ProgrammeId",
                        column: x => x.ProgrammeId,
                        principalTable: "Programme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgrammeUser_User_MembersId",
                        column: x => x.MembersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgrammeUser_ProgrammeId",
                table: "ProgrammeUser",
                column: "ProgrammeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgrammeUser");

            migrationBuilder.DropTable(
                name: "Programme");

            migrationBuilder.CreateTable(
                name: "StudentProgram",
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
                    table.PrimaryKey("PK_StudentProgram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProgram",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProgram", x => new { x.UserId, x.ProgramId });
                    table.ForeignKey(
                        name: "FK_UserProgram_StudentProgram_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "StudentProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProgram_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProgram_ProgramId",
                table: "UserProgram",
                column: "ProgramId");
        }
    }
}
