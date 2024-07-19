using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentsystem3.Migrations
{
    /// <inheritdoc />
    public partial class Addfnoaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_homeworks_course_id",
                table: "homeworks",
                column: "course_id");

            migrationBuilder.AddForeignKey(
                name: "FK_homeworks_courses_course_id",
                table: "homeworks",
                column: "course_id",
                principalTable: "courses",
                principalColumn: "course_id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_homeworks_courses_course_id",
                table: "homeworks");

            migrationBuilder.DropIndex(
                name: "IX_homeworks_course_id",
                table: "homeworks");
        }
    }
}
