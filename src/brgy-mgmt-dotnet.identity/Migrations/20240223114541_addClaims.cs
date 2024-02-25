using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class addClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 1, "Administrator_Role_Claim", "Administrator Role Claim", new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47") });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"), null, "Officer Two", "Officer Two", "OFFICER TWO" },
                    { new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"), null, "Officer One", "Officer One", "OFFICER ONE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "Administrator_User_Claim", "Administrator User Claim", new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "ExternalUserId", "PasswordHash" },
                values: new object[] { "91b3d50f-214e-48d2-af48-685601d0f112", null, "AQAAAAIAAYagAAAAEJyVHCzH6ZE+Gqnny9LxRICf55zgI4iYYBENvqwxh4uF08rbO1coZCZTIG884S8Ktw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomUsername", "Email", "EmailConfirmed", "ExternalUserId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"), 0, "da9cce76-f5dd-4258-b4d7-dd2e650ab785", "ggn", "garyn.green@localhost.com", true, 1, false, null, "GARYN.GREEN@LOCALHOST.COM", "GARYN.GREEN@LOCALHOST.COM", "AQAAAAIAAYagAAAAELHNd0SE8Ofd448Fy62UypBMQzrUa9Uzr7khMowGFO91cu9mRDm25LGJOb6UDy+sIg==", null, false, null, false, "garyn.green@localhost.com" },
                    { new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"), 0, "4ad1da05-5e06-4fc4-8c3d-235c13218802", "jss", "jamesina.sanders@localhost.com", true, 2, false, null, "JAMESINA.SANDERS@LOCALHOST.COM", "JAMESINA.SANDERS@LOCALHOST.COM", "AQAAAAIAAYagAAAAELz5SNI/7JNvpKUyVJqeR3GVk4ZI8MhY37IRgy9WajoJFDumKYwdNL5ddCaGE048Hw==", null, false, null, false, "jamesina.sanders@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[,]
                {
                    { 2, "Officer_One_Claim", "Officer One Role Claim", new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556") },
                    { 3, "Officer_Two_Claim", "Officer Two Role Claim", new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 2, "Garyn_Claim", "Garyn One", new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19") },
                    { 3, "Jamesina_Claim", "Jamesina Two", new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"), new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19") },
                    { new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"), new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"), new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"), new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "ExternalUserId", "PasswordHash" },
                values: new object[] { "5aac8d98-1e2f-4853-965d-5af249f9f88d", 1, "AQAAAAIAAYagAAAAEKRIKxTfKI9mxJR71IL2dgfDAVE+7UH4nMtaF1DeZy36DaKxftjBdWBvC4teuDjRcw==" });
        }
    }
}
