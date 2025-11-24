using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class updateincometable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedTimeStamp",
                table: "Incomes",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 21, 15, 34, 16, 906, DateTimeKind.Unspecified).AddTicks(8859), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 13, 15, 34, 16, 906, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 18, 15, 34, 16, 906, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 8, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTimeStamp",
                table: "Incomes");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 21, 15, 18, 45, 784, DateTimeKind.Unspecified).AddTicks(2397), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 13, 15, 18, 45, 784, DateTimeKind.Unspecified).AddTicks(2437), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 18, 15, 18, 45, 784, DateTimeKind.Unspecified).AddTicks(2439), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
