using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class addClaimsTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 4, "Administrator_User_Claim2", "Administrator User Claim2", new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "926982ee-0d3b-47f8-9f5d-5ac90b6e43e7", "AQAAAAIAAYagAAAAENdWuFw7CuhHFp4uS4v8o5kgZDHPc9vTsqjrQvpveMCHBHttlxEvfpCF9Rg560jyPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b85c7b9-7641-4515-b12e-fa5e98dbb350", "AQAAAAIAAYagAAAAEGJ9PdzKG+Fo0mZr+lfuyqU/rNHN92Dw4g4eVsszcleQ1rg2xE4nQGwwEtdnhtOW7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8be3f9dc-4684-4550-94c6-b43c61984b40", "AQAAAAIAAYagAAAAEBbo8h1YJejC4vislSrpGJJDmlrq17VwMMJWK+nhh0woF1MVTyEXLK7vVe5IUc5k9Q==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "91b3d50f-214e-48d2-af48-685601d0f112", "AQAAAAIAAYagAAAAEJyVHCzH6ZE+Gqnny9LxRICf55zgI4iYYBENvqwxh4uF08rbO1coZCZTIG884S8Ktw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76361a7e-0f21-4eea-8681-a3ce26588b19"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da9cce76-f5dd-4258-b4d7-dd2e650ab785", "AQAAAAIAAYagAAAAELHNd0SE8Ofd448Fy62UypBMQzrUa9Uzr7khMowGFO91cu9mRDm25LGJOb6UDy+sIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f063d4f6-34f2-4169-b01c-da053928fa2a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ad1da05-5e06-4fc4-8c3d-235c13218802", "AQAAAAIAAYagAAAAELz5SNI/7JNvpKUyVJqeR3GVk4ZI8MhY37IRgy9WajoJFDumKYwdNL5ddCaGE048Hw==" });
        }
    }
}
