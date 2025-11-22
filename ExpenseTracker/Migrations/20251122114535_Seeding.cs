using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "Category", "CreatedTimeStamp", "Title" },
                values: new object[,]
                {
                    { 1, 150.75m, "Food", new DateTimeOffset(new DateTime(2025, 11, 20, 19, 45, 35, 158, DateTimeKind.Unspecified).AddTicks(2420), new TimeSpan(0, 8, 0, 0, 0)), "Grocery Shopping" },
                    { 2, 60.00m, "Utilities", new DateTimeOffset(new DateTime(2025, 11, 12, 19, 45, 35, 158, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 8, 0, 0, 0)), "Electricity Bill" },
                    { 3, 30.50m, "Entertainment", new DateTimeOffset(new DateTime(2025, 11, 17, 19, 45, 35, 158, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 8, 0, 0, 0)), "Movie Night" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
