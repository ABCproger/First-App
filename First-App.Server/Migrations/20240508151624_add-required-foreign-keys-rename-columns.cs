using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class addrequiredforeignkeysrenamecolumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Priority",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Action",
                table: "CardActivityLogs",
                newName: "action");

            migrationBuilder.RenameColumn(
                name: "ActivityTime",
                table: "CardActivityLogs",
                newName: "activity_time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Priority",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "action",
                table: "CardActivityLogs",
                newName: "Action");

            migrationBuilder.RenameColumn(
                name: "activity_time",
                table: "CardActivityLogs",
                newName: "ActivityTime");
        }
    }
}
