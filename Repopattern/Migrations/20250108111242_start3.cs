using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repopattern.Migrations
{
    /// <inheritdoc />
    public partial class start3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "StudentDetails");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StudentDetails",
                newName: "StudentName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StudentDetails",
                newName: "Rn");

            migrationBuilder.AlterColumn<string>(
                name: "StudentName",
                table: "StudentDetails",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "StudentDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Marks",
                table: "StudentDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentDetails",
                table: "StudentDetails",
                column: "Rn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentDetails",
                table: "StudentDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "StudentDetails");

            migrationBuilder.DropColumn(
                name: "Marks",
                table: "StudentDetails");

            migrationBuilder.RenameTable(
                name: "StudentDetails",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentName",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Rn",
                table: "Students",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }
    }
}
