using Microsoft.EntityFrameworkCore.Migrations;

namespace Uni_Management_System.Migrations
{
    public partial class addPersonality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "personality",
                table: "Student",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "personality",
                table: "Student");
        }
    }
}
