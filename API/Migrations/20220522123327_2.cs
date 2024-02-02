using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorAddress_Instructors_InstructorId",
                table: "InstructorAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddress",
                table: "StudentAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorAddress",
                table: "InstructorAddress");

            migrationBuilder.RenameTable(
                name: "StudentAddress",
                newName: "StudentAddresses");

            migrationBuilder.RenameTable(
                name: "InstructorAddress",
                newName: "InstructorAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAddress_StudentId",
                table: "StudentAddresses",
                newName: "IX_StudentAddresses_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorAddress_InstructorId",
                table: "InstructorAddresses",
                newName: "IX_InstructorAddresses_InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorAddresses",
                table: "InstructorAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorAddresses_Instructors_InstructorId",
                table: "InstructorAddresses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddresses_Students_StudentId",
                table: "StudentAddresses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorAddresses_Instructors_InstructorId",
                table: "InstructorAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddresses_Students_StudentId",
                table: "StudentAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorAddresses",
                table: "InstructorAddresses");

            migrationBuilder.RenameTable(
                name: "StudentAddresses",
                newName: "StudentAddress");

            migrationBuilder.RenameTable(
                name: "InstructorAddresses",
                newName: "InstructorAddress");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAddresses_StudentId",
                table: "StudentAddress",
                newName: "IX_StudentAddress_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorAddresses_InstructorId",
                table: "InstructorAddress",
                newName: "IX_InstructorAddress_InstructorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddress",
                table: "StudentAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorAddress",
                table: "InstructorAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorAddress_Instructors_InstructorId",
                table: "InstructorAddress",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
