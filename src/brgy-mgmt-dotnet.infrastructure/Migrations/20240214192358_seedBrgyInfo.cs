using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brgy_mgmt_dotnet.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedBrgyInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barangay",
                table: "BrgyInfo");

            migrationBuilder.InsertData(
                table: "BrgyInfo",
                columns: new[] { "Id", "City", "CreatedBy", "DateCreated", "DateUpdated", "District", "Name", "State", "Street", "UpdatedBy", "ZipCode" },
                values: new object[] { 1, "Manila", "Default", new DateTime(2024, 2, 15, 3, 23, 57, 21, DateTimeKind.Local).AddTicks(8072), null, "San Andres Bukid", "767", "Metro Manila", "0000001", null, "1017" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BrgyInfo",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Barangay",
                table: "BrgyInfo",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
