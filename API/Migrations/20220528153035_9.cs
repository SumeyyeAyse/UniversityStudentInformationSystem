using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CV",
                table: "Instructors",
                newName: "Cv");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cv",
                table: "Instructors",
                newName: "CV");
        }
    }
}
