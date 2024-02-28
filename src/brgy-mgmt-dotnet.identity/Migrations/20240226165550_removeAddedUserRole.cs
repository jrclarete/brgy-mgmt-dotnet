using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class removeAddedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"), new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dc692e3-b72c-4a68-a383-04250ba6169f", "AQAAAAIAAYagAAAAEGmN5hpbUypnlqoTK/vLgRjI6GdDXCWD/F6x7mlnpghkLg5pyI0pdCE5xFb3ClIIFA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de7794ba-d294-442a-861d-3a8f870ffa69", "AQAAAAIAAYagAAAAEIt+Vu37qWa0PXV//vORGjnwcwget+mZ1ElifGXV6idk6uvswnxQsNK0goSlVwPrpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "47eecb4c-12ff-428f-8bb1-b4b277210d47", "AQAAAAIAAYagAAAAEP2TARdmpuB8I+q5V/xit1XFdtsGCt6UhCa+Bp6pCuXKLWMLhqHQQtM9ktCTAYJDGw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"), new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf968b53-e1bf-4a05-aa17-1119b1e2726d", "AQAAAAIAAYagAAAAEPXpsgkzsB4bREudN5ls+cWQ4FJJUvVzI4JxPNIANYJF8UWMbW4f2qn93JWrr0OnwQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0719a6c-1e83-44ec-88d2-6bd2159f75fd", "AQAAAAIAAYagAAAAEFLLz0YUrT1JbUJnEh8q/DEbS8eTc1y2s6+mQ24MITl//UlZf6X8lzX0BlU4G2ZclQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6fdb0bbb-5c1f-423c-a2dd-d9c9e1ab49c6", "AQAAAAIAAYagAAAAEC0e4dXRMxxi5Upq1CZFJkC7Ry4d3h4jlXNp3hJCQz7wv6xcvszEcGvmermPco5NVg==" });
        }
    }
}
