using Microsoft.EntityFrameworkCore.Migrations;

namespace Select.TaskTrackingApp.DataAccess.Migrations
{
    public partial class addedisActivetoAppTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AppTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AppTasks");
        }
    }
}
