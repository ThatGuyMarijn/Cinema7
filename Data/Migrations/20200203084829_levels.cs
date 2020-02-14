using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema7.Data.Migrations
{
    public partial class levels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
