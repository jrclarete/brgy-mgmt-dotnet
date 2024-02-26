using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class updateClaimTypeSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "[\"READ\"]");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "[\"CREATE\",\"READ\",\"UPDATE\",\"DELETE\"]");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a16a4d4b-e3a1-45b9-94de-f91f33581181", "AQAAAAIAAYagAAAAEJr78BiZL3Vhd8dIJuZ23a2UGxGhwav6RKcgirSe706N0uC1SxabsZGUN6MTqyxCow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31e99ff7-01d8-4dc5-8bf8-e17d247744fc", "AQAAAAIAAYagAAAAEP7lBYWgvQNpu2QgU7IUepcQnGQho/1T4UyNvt3kaWyhPalDA24q4TgK48bbPKpSPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1da121e-e060-4983-ab50-0ecba76fa62c", "AQAAAAIAAYagAAAAEA8CRR44N337JXqT7gDp3+UxZcx2MvYrBkIKY+UFmBBqJrcxsrcfN/Vb7mf7zgu6NA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "ClaimValue",
                value: "[CREATE,READ,UPDATE,DELETE]");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "ClaimValue",
                value: "[CREATE,READ,UPDATE,DELETE]");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "ClaimValue",
                value: "[READ]");

            migrationBuilder.UpdateData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "[CREATE,READ,UPDATE,DELETE]");

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
    }
}
