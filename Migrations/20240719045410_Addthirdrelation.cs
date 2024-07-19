using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentsystem3.Migrations
{
    /// <inheritdoc />
    public partial class Addthirdrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "course_id",
                table: "studnts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_resourcess_course_id",
                table: "resourcess",
                column: "course_id");

            migrationBuilder.AddForeignKey(
                name: "FK_resourcess_courses_course_id",
                table: "resourcess",
                column: "course_id",
                principalTable: "courses",
                principalColumn: "course_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_resourcess_courses_course_id",
                table: "resourcess");

            migrationBuilder.DropIndex(
                name: "IX_resourcess_course_id",
                table: "resourcess");

            migrationBuilder.DropColumn(
                name: "course_id",
                table: "studnts");
        }
    }
}
