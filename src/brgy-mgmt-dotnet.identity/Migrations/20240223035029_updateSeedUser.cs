using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "ExternalUserId", "PasswordHash" },
                values: new object[] { "5aac8d98-1e2f-4853-965d-5af249f9f88d", 1, "AQAAAAIAAYagAAAAEKRIKxTfKI9mxJR71IL2dgfDAVE+7UH4nMtaF1DeZy36DaKxftjBdWBvC4teuDjRcw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "ExternalUserId", "PasswordHash" },
                values: new object[] { "df2dc75c-b5b4-4519-9dbb-9f7d7efec8b0", null, "AQAAAAIAAYagAAAAEHqpsTFL6XVxdBdvLjh8npx26reSEnARaUbVWtd7C6gAjkwiUga6p0Knv5Ge+tBDzw==" });
        }
    }
}
