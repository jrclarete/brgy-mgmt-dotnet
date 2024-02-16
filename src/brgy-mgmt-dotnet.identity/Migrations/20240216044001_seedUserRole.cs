using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace brgy_mgmt_dotnet.identity.Migrations
{
    /// <inheritdoc />
    public partial class seedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"), new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae98890c-9ea0-473e-8475-7825bcedf21f", "AQAAAAIAAYagAAAAEPYWApsMKasbJhvYrhdHWXa5WacBiEpx5LJzUl5XIfICqbsujhREaMtSGfKC6pvZaQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("96445f78-7f86-4a0f-8e46-44ecf3690a47"), new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1ed72e4b-d489-4c2a-9f9a-a8a29e8ef735"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dcb5c0f8-00a0-48a4-be63-012f44ea703a", "AQAAAAIAAYagAAAAEHA7JfrvZY8yIUIqTRGAxLR+FQhZq07Yg0UNQASlhXaN8JWGqnO2UXfn2Jg/b9YhZw==" });
        }
    }
}
