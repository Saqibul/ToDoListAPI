using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListAPI.Migrations
{
    public partial class addedPrimaryKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TasksToDos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TasksAssigned",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasksToDos",
                table: "TasksToDos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TasksAssigned",
                table: "TasksAssigned",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TasksToDos",
                table: "TasksToDos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TasksAssigned",
                table: "TasksAssigned");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TasksToDos");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TasksAssigned");
        }
    }
}
