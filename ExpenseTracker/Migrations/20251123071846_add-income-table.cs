using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class addincometable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 21, 14, 43, 32, 788, DateTimeKind.Unspecified).AddTicks(3708), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 13, 14, 43, 32, 788, DateTimeKind.Unspecified).AddTicks(3776), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 18, 14, 43, 32, 788, DateTimeKind.Unspecified).AddTicks(3778), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
