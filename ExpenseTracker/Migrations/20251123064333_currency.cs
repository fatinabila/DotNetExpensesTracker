using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class currency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "MYR" },
                    { 2, null, "USD" },
                    { 3, null, "SGD" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 20, 23, 24, 55, 310, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 12, 23, 24, 55, 310, DateTimeKind.Unspecified).AddTicks(4252), new TimeSpan(0, 8, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimeStamp",
                value: new DateTimeOffset(new DateTime(2025, 11, 17, 23, 24, 55, 310, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 8, 0, 0, 0)));
        }
    }
}
