using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace First_App.Server.Migrations
{
    /// <inheritdoc />
    public partial class addtestdataforactivitylog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardActivityLogs",
                columns: new[] { "id", "Action", "ActivityTime", "CardId" },
                values: new object[,]
                {
                    { 100, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 20 },
                    { 101, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 21 },
                    { 102, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 22 },
                    { 103, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 23 },
                    { 104, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 24 },
                    { 105, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 25 },
                    { 106, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 26 },
                    { 107, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 27 },
                    { 108, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 28 },
                    { 109, "You created this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 29 },
                    { 110, "You renamed first card to first card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 20 },
                    { 111, "You moved second card from To Do to Planned", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 21 },
                    { 112, "You deleted third card from to do", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 22 },
                    { 113, "You changed the priority fourth card from low to medium", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 23 },
                    { 114, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 24 },
                    { 115, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 25 },
                    { 116, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 26 },
                    { 117, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 27 },
                    { 118, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 28 },
                    { 119, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 29 },
                    { 120, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 20 },
                    { 121, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 21 },
                    { 122, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 22 },
                    { 123, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 23 },
                    { 124, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 24 },
                    { 125, "You do something with this card", new DateTime(2024, 4, 12, 2, 13, 2, 0, DateTimeKind.Utc), 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "CardActivityLogs",
                keyColumn: "id",
                keyValue: 125);
        }
    }
}
