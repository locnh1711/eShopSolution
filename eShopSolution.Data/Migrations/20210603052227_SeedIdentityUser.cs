using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8e571449-6259-48f3-beea-4bb63ec6b744"), "850a960c-fcf1-4bf2-8126-0ed93d139890", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8e571449-6259-48f3-beea-4bb63ec6b744"), new Guid("afd0989b-6c53-46ae-8094-3137e396e88d") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("afd0989b-6c53-46ae-8094-3137e396e88d"), 0, "7fa564b3-9fd6-43de-8002-fc1eb64c33de", new DateTime(1999, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "locnhgcs17219@fpt.edu.vn", true, "Loc", "Nguyen", false, null, "locnhgcs17219@fpt.edu.vn", "admin", "AQAAAAEAACcQAAAAEIdqfpgF9Zd+iDqHewM7Ip+ez8P13JWVucKGwo1MSp4FTrq6XfU+Y9fIY8dF6GnX+w==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 12, 22, 26, 765, DateTimeKind.Local).AddTicks(7390));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8e571449-6259-48f3-beea-4bb63ec6b744"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8e571449-6259-48f3-beea-4bb63ec6b744"), new Guid("afd0989b-6c53-46ae-8094-3137e396e88d") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("afd0989b-6c53-46ae-8094-3137e396e88d"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 6, 3, 11, 52, 38, 46, DateTimeKind.Local).AddTicks(796));
        }
    }
}
