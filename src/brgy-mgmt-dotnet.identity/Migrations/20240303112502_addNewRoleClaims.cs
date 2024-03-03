using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class addNewRoleClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 5, "RESIDENT", "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]", new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47") },
                    { 6, "RESIDENT", "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]", new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556") },
                    { 7, "RESIDENT", "[\"READ\"]", new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69aa2ce4-cf4b-4a04-ba50-42eab98d3efb", "AQAAAAIAAYagAAAAEE74h/e26LLrPE0VndLvQqZ0aO22CLCeui5X53ut6nm5hxLWNScTVfu2aHmBNhseaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "12c9311e-b6b4-4d7d-9973-7156c030a9eb", "AQAAAAIAAYagAAAAEPJY+VFsAWpiEtcP2CIo45Lv8zP56cgduGsQZc4+ejXKeMZ3J07Gws89Gu0041arUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d81c315-4b83-40f2-965c-55adcbea8d19", "AQAAAAIAAYagAAAAEDlAv3pkNFQ/Mwxy4M/S/ezIKzNeoHxEcj617FZWvY4/V6g51gf4wuUMtvEXfuF5Ww==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 7);

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
    }
}
