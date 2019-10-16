using Microsoft.EntityFrameworkCore.Migrations;

namespace Uni_Management_System.Migrations
{
    public partial class updateCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "location",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "time",
                table: "Course",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unitCode",
                table: "Course",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "location",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "time",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "unitCode",
                table: "Course");
        }
    }
}
