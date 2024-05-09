using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class addprioritytodatafactory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Priority",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Low" },
                    { 2, "Medium" },
                    { 3, "High" }
                });

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 20,
                column: "PriorityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 21,
                column: "PriorityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 22,
                column: "PriorityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 23,
                column: "PriorityId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 24,
                column: "PriorityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 25,
                column: "PriorityId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 26,
                column: "PriorityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 27,
                column: "PriorityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 28,
                column: "PriorityId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 29,
                column: "PriorityId",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Priority",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 20,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 21,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 22,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 23,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 24,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 25,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 26,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 27,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 28,
                column: "PriorityId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "cards",
                keyColumn: "id",
                keyValue: 29,
                column: "PriorityId",
                value: 0);
        }
    }
}
