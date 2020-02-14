using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema7.Data.Migrations
{
    public partial class NewIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ea8cdca-380d-4b1f-b398-c8211bdf6178");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c079b52-39c0-4ab3-9ebb-6aabfa925ea0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afd37608-2093-4b08-b9c6-a117e41d2231");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bda7f8f1-4395-45c4-a5da-16178fb68cd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9a2bbd0-aa1a-4372-9108-d6c6fb85e425");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Films",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Leeftijd",
                table: "Films",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Films",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e6b114d1-2a4c-4adb-afb1-ee4f4d12fa0a", "926da079-6cf2-4932-b338-ea6df86b0717", "LevelOne", "LEVELONE" },
                    { "6c8e1928-0a87-4fec-bfd7-7c575faf13cd", "76c849cf-96d8-4b07-b87a-3ee51eddc181", "LevelTwo", "LEVELTWO" },
                    { "188415bf-3974-4dd0-a391-6e3766703410", "bb81c615-a20d-4836-8ff9-3cefe88513d8", "LevelThree", "LEVELTHREE" },
                    { "54d92e34-046a-4e2f-ae90-11bde25e41b8", "452c2764-2283-41e0-b57c-9eb65b7d0b2a", "LevelFour", "LEVELFOUR" },
                    { "f6a65f78-c606-4de6-8e77-bed8516707dc", "c0c8eab7-10e7-4402-bd51-81adf6ceae2c", "LevelFive", "LEVELFIVE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmVertoningen");

            migrationBuilder.DropTable(
                name: "Reserveringen");

            migrationBuilder.DropTable(
                name: "ReserveringenVertoningen");

            migrationBuilder.DropTable(
                name: "Zalen");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "188415bf-3974-4dd0-a391-6e3766703410");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54d92e34-046a-4e2f-ae90-11bde25e41b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c8e1928-0a87-4fec-bfd7-7c575faf13cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6b114d1-2a4c-4adb-afb1-ee4f4d12fa0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6a65f78-c606-4de6-8e77-bed8516707dc");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Leeftijd",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d9a2bbd0-aa1a-4372-9108-d6c6fb85e425", "5872b4dc-5351-42b7-aaf2-79b340e052ba", "LevelOne", "LEVELONE" },
                    { "6c079b52-39c0-4ab3-9ebb-6aabfa925ea0", "3833bbec-821d-4a64-8abc-6ef6546aa737", "LevelTwo", "LEVELTWO" },
                    { "3ea8cdca-380d-4b1f-b398-c8211bdf6178", "2f17a1c8-aeb3-4d18-817b-0a013608bc4d", "LevelThree", "LEVELTHREE" },
                    { "bda7f8f1-4395-45c4-a5da-16178fb68cd3", "81f46afc-d1f6-45b7-9a64-1299fb4ffe72", "LevelFour", "LEVELFOUR" },
                    { "afd37608-2093-4b08-b9c6-a117e41d2231", "6f6fb02c-69ad-4059-b136-c49db6dfb92b", "LevelFive", "LEVELFIVE" }
                });
        }
    }
}
