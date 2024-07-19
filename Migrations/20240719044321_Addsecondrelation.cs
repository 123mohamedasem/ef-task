using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace studentsystem3.Migrations
{
    /// <inheritdoc />
    public partial class Addsecondrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_homeworks_student_id",
                table: "homeworks",
                column: "student_id");

            migrationBuilder.AddForeignKey(
                name: "FK_homeworks_studnts_student_id",
                table: "homeworks",
                column: "student_id",
                principalTable: "studnts",
                principalColumn: "student_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_homeworks_studnts_student_id",
                table: "homeworks");

            migrationBuilder.DropIndex(
                name: "IX_homeworks_student_id",
                table: "homeworks");
        }
    }
}
