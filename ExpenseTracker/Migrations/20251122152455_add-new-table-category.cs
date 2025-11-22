using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExpenseTracker.Migrations
{
    /// <inheritdoc />
    public partial class addnewtablecategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Expenses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Food" },
                    { 2, null, "Utilities" },
                    { 3, null, "Entertainment" },
                    { 4, null, "Transportation" },
                    { 5, null, "Healthcare" },
                    { 6, null, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CategoryId", "CreatedTimeStamp" },
                values: new object[] { null, 1, new DateTimeOffset(new DateTime(2025, 11, 20, 23, 24, 55, 310, DateTimeKind.Unspecified).AddTicks(4189), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "CategoryId", "CreatedTimeStamp" },
                values: new object[] { null, 2, new DateTimeOffset(new DateTime(2025, 11, 12, 23, 24, 55, 310, DateTimeKind.Unspecified).AddTicks(4252), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CategoryId", "CreatedTimeStamp" },
                values: new object[] { null, 3, new DateTimeOffset(new DateTime(2025, 11, 17, 23, 24, 55, 310, DateTimeKind.Unspecified).AddTicks(4255), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_CategoryId",
                table: "Expenses",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_Categories_CategoryId",
                table: "Expenses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_Categories_CategoryId",
                table: "Expenses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_CategoryId",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Expenses");

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "CreatedTimeStamp" },
                values: new object[] { "Food", new DateTimeOffset(new DateTime(2025, 11, 20, 19, 59, 29, 713, DateTimeKind.Unspecified).AddTicks(6205), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "CreatedTimeStamp" },
                values: new object[] { "Utilities", new DateTimeOffset(new DateTime(2025, 11, 12, 19, 59, 29, 713, DateTimeKind.Unspecified).AddTicks(6264), new TimeSpan(0, 8, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "CreatedTimeStamp" },
                values: new object[] { "Entertainment", new DateTimeOffset(new DateTime(2025, 11, 17, 19, 59, 29, 713, DateTimeKind.Unspecified).AddTicks(6268), new TimeSpan(0, 8, 0, 0, 0)) });
        }
    }
}
