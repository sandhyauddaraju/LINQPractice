using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "DeptName" },
                values: new object[,]
                {
                    { 1, "Operations" },
                    { 2, "Development" },
                    { 3, "Sales" },
                    { 4, "HR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateCreated", "DeptId", "Name", "Salary" },
                values: new object[,]
                {
                    { 101, new DateTime(2024, 6, 5, 3, 19, 47, 640, DateTimeKind.Local).AddTicks(7426), 1, "Sal", 7000 },
                    { 102, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(4945), 1, "Will", 8000 },
                    { 103, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(4979), 2, "John", 10000 },
                    { 104, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(4983), 2, "Julie", 20000 },
                    { 105, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(4987), 2, "Sam", 8000 },
                    { 106, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(4995), 3, "Jude", 20000 },
                    { 107, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(4998), 3, "Jen", 15000 },
                    { 108, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(5001), 4, "Ram", 11000 },
                    { 109, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(5004), 4, "Violet", 12000 },
                    { 110, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(5008), 2, "Andy", 30000 },
                    { 111, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(5011), 1, "Molly", 16000 },
                    { 112, new DateTime(2024, 6, 5, 3, 19, 47, 643, DateTimeKind.Local).AddTicks(5014), 2, "Vincent", 6000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
