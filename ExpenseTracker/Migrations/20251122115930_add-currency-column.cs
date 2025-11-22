using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class addcurrencycolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTimeStamp", "Currency" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 11, 20, 19, 59, 29, 713, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 8, 0, 0, 0)), "MYR" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTimeStamp", "Currency" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 11, 12, 19, 59, 29, 713, DateTimeKind.Unspecified).AddTicks(6264), new TimeSpan(0, 8, 0, 0, 0)), "MYR" });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTimeStamp", "Currency" },
                values: new object[] { new DateTimeOffset(new DateTime(2025, 11, 17, 19, 59, 29, 713, DateTimeKind.Unspecified).AddTicks(6268), new TimeSpan(0, 8, 0, 0, 0)), "MYR" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 20, 19, 45, 35, 158, DateTimeKind.Unspecified).AddTicks(2420), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 12, 19, 45, 35, 158, DateTimeKind.Unspecified).AddTicks(2460), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 17, 19, 45, 35, 158, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
