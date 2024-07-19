using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentsystem3.Migrations
{
    /// <inheritdoc />
    public partial class Addfirstrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "student_id",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "student_id1",
                table: "courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_courses_student_id1",
                table: "courses",
                column: "student_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_studnts_student_id1",
                table: "courses",
                column: "student_id1",
                principalTable: "studnts",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_studnts_student_id1",
                table: "courses");

            migrationBuilder.DropIndex(
                name: "IX_courses_student_id1",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "student_id",
                table: "courses");

            migrationBuilder.DropColumn(
                name: "student_id1",
                table: "courses");
        }
    }
}
