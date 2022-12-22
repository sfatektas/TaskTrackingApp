using Microsoft.EntityFrameworkCore.Migrations;

namespace Select.TaskTrackingApp.DataAccess.Migrations
{
    public partial class appUserTaskfixxed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompleteDocument",
                table: "AppUserTasks",
                newName: "CompleteDocumentDefination");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompleteDocumentDefination",
                table: "AppUserTasks",
                newName: "CompleteDocument");
        }
    }
}
