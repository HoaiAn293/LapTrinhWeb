using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTMDT.Migrations
{
    /// <inheritdoc />
    public partial class ThemDuLieuMau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
              migrationBuilder.InsertData(
              table: "Grades",
              columns: new[] { "GradeId", "GradeName" },
              values: new object[,]
              {
                    { 1, "21DTHA1" },
                    { 2, "21DTHA2" },
                    { 3, "21DTHA3" }
              }
          );
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "GradeId" },
                values: new object[,]
                {
            { 1, "Khuyên", "Bùi", 1 },
            { 2, "Toàn", "Nguyễn", 1 }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
