using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListAPI.Migrations
{
    public partial class separatedTasksToBeDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedBy",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TasksAssignedId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "TasksToDo",
                table: "Persons");

            migrationBuilder.CreateTable(
                name: "TasksToBeDones",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TasksToDos",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TasksToBeDones");

            migrationBuilder.DropTable(
                name: "TasksToDos");

            migrationBuilder.AddColumn<string>(
                name: "AssignedBy",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TasksAssignedId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TasksToDo",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
