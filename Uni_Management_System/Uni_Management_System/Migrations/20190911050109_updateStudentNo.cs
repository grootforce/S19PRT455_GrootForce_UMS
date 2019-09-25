using Microsoft.EntityFrameworkCore.Migrations;

namespace Uni_Management_System.Migrations
{
    public partial class updateStudentNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "studentNo",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentNo",
                table: "Students");
        }
    }
}
