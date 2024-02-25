using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class updateRoleClaim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClaimType", "ClaimValue" },
                values: new object[] { "HOUSEHOLD", "[CREATE,READ,UPDATE,DELETE]" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClaimType", "ClaimValue" },
                values: new object[] { "HOUSEHOLD", "[CREATE,READ,UPDATE,DELETE]" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClaimType", "ClaimValue" },
                values: new object[] { "HOUSEHOLD", "[READ]" });

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 4, "BRGY_INFO", "[CREATE,READ,UPDATE,DELETE]", new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47") });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"),
                columns: new[] { "Description", "Name", "NormalizedName" },
                values: new object[] { "SK_Official", "SK_Official", "SK_OFFICIAL" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"),
                columns: new[] { "Description", "Name", "NormalizedName" },
                values: new object[] { "Main_Official", "Main_Official", "MAIN_OFFICIAL" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d36516c-577d-439e-8ca6-7cba7eafccf3", "AQAAAAIAAYagAAAAEIj4/CMa2mVbQizp7M1B4HD3QiLglSKVTrTo5Eur4zuXpOuhAKsed3ZKcSn1hBlPJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f65c8ae6-33d2-42e3-8e02-759c16a63939", "AQAAAAIAAYagAAAAEH1c6Sc07DveefpfbprT8YpuU5EKMsraWXAWYS7IlcLD23NWDxdPDv5n8Xl6PO6kUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9ed2ce0-1b0c-444a-b54a-faf62ff53028", "AQAAAAIAAYagAAAAEKr5N6kOJMaOlFhg2kaahUDBbfy0lcctS6aIIlXOqbhxlxI5EJk6pt407ddo2x3UtA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClaimType", "ClaimValue" },
                values: new object[] { "Administrator_Role_Claim", "Administrator Role Claim" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClaimType", "ClaimValue" },
                values: new object[] { "Officer_One_Claim", "Officer One Role Claim" });

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClaimType", "ClaimValue" },
                values: new object[] { "Officer_Two_Claim", "Officer Two Role Claim" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b0954a50-4a88-44b1-9f80-09ca191307f4"),
                columns: new[] { "Description", "Name", "NormalizedName" },
                values: new object[] { "Officer Two", "Officer Two", "OFFICER TWO" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("de0484d9-1201-4298-bc5d-ae1ca3392556"),
                columns: new[] { "Description", "Name", "NormalizedName" },
                values: new object[] { "Officer One", "Officer One", "OFFICER ONE" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "Administrator_User_Claim", "Administrator User Claim", new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") },
                    { 2, "Garyn_Claim", "Garyn One", new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19") },
                    { 3, "Jamesina_Claim", "Jamesina Two", new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8d585893-0f26-4a8d-95f2-5e109f04dddf", "AQAAAAIAAYagAAAAEJJ/gzWCXwGISzw/wMs6AiDGQV0fRtijii4XBw6qBCj2CEZl+Ut5YO0Lei2To1+OUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f1cee28a-8340-4a10-aba8-162c289898f6", "AQAAAAIAAYagAAAAEOMdneXBee65jbLCX4+aYDlRjUs+IJJP4fiYXqXlrxwA9/C3/vWEHfcswLlFi6wSXA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8137bdda-3f4c-43fe-8198-0f6f0895b630", "AQAAAAIAAYagAAAAEGxhdvdBuSlVBoNPt3wkrxbgJMFd19zaaPrL0Ny8AbY4Jd7AjHz+0bntaYY7x7iayA==" });
        }
    }
}
