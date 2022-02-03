using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Temperature = table.Column<decimal>(type: "TEXT", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 1, "Device 1", "Available", 10m, 0, 1 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 2, "Device 2", "Offline", 15m, 0, 3 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 3, "Device 3", "Available", 7m, 0, 2 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 4, "Device 4", "Offline", 4m, 0, 1 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 5, "Device 5", "Offline", 20m, 0, 2 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 6, "Device 6", "Available", 12m, 0, 3 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 7, "Device 7", "Available", 21m, 0, 3 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 8, "Device 8", "Offline", 19m, 0, 2 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 9, "Device 9", "Offline", 22m, 0, 1 });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Name", "Status", "Temperature", "Type", "TypeId" },
                values: new object[] { 10, "Device 10", "Available", 40m, 0, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
