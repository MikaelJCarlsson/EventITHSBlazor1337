using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHSManagement.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCourse");

            migrationBuilder.DropTable(
                name: "UserGroup");

            migrationBuilder.CreateTable(
                name: "CourseProgramme",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    ProgrammesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseProgramme", x => new { x.CoursesId, x.ProgrammesId });
                    table.ForeignKey(
                        name: "FK_CourseProgramme_Course_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseProgramme_Programme_ProgrammesId",
                        column: x => x.ProgrammesId,
                        principalTable: "Programme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    MembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUser", x => new { x.CourseId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_CourseUser_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseUser_User_MembersId",
                        column: x => x.MembersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupUser",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    MembersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupUser", x => new { x.GroupId, x.MembersId });
                    table.ForeignKey(
                        name: "FK_GroupUser_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupUser_User_MembersId",
                        column: x => x.MembersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseProgramme_ProgrammesId",
                table: "CourseProgramme",
                column: "ProgrammesId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_MembersId",
                table: "CourseUser",
                column: "MembersId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupUser_MembersId",
                table: "GroupUser",
                column: "MembersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseProgramme");

            migrationBuilder.DropTable(
                name: "CourseUser");

            migrationBuilder.DropTable(
                name: "GroupUser");

            migrationBuilder.CreateTable(
                name: "UserCourse",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourse", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_UserCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCourse_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroup",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroup", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_UserGroup_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroup_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserCourse_CourseId",
                table: "UserCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroup_GroupId",
                table: "UserGroup",
                column: "GroupId");
        }
    }
}
