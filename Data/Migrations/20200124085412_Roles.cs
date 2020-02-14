using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema7.Data.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da95e63a-9b05-4cf2-960f-d02ff06c746f", "bd090be8-b086-4b44-a0d8-ca2e29e7b83a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9ada2a4d-d597-4520-98f2-a2f20275ac3d", "5da3b3b7-2b92-4590-a673-5a2b594fcbed", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ada2a4d-d597-4520-98f2-a2f20275ac3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da95e63a-9b05-4cf2-960f-d02ff06c746f");
        }
    }
}
