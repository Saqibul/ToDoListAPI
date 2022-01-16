using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListAPI.Migrations
{
    public partial class renamedTheTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TasksToBeDones");

            migrationBuilder.AddColumn<int>(
                name: "assignedBy",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "assignedTo",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TasksAssigned",
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
                name: "TasksAssigned");

            migrationBuilder.DropColumn(
                name: "assignedBy",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "assignedTo",
                table: "Tasks");

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
        }
    }
}
