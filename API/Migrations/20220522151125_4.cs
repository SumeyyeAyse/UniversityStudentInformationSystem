using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmantId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Departmants");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_FacultyId",
                table: "Departmants",
                newName: "IX_Departmants_FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmants",
                table: "Departmants",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departmants_Faculties_FacultyId",
                table: "Departmants",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departmants_DepartmantId",
                table: "Students",
                column: "DepartmantId",
                principalTable: "Departmants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmants_Faculties_FacultyId",
                table: "Departmants");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departmants_DepartmantId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmants",
                table: "Departmants");

            migrationBuilder.RenameTable(
                name: "Departmants",
                newName: "Departments");

            migrationBuilder.RenameIndex(
                name: "IX_Departmants_FacultyId",
                table: "Departments",
                newName: "IX_Departments_FacultyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Faculties_FacultyId",
                table: "Departments",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmantId",
                table: "Students",
                column: "DepartmantId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
