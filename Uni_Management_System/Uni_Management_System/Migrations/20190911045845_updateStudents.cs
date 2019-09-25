using Microsoft.EntityFrameworkCore.Migrations;

namespace Uni_Management_System.Migrations
{
    public partial class updateStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dateOfBirth",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateOfBirth",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Students");
        }
    }
}
