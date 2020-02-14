using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema7.Data.Migrations
{
    public partial class Testing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
