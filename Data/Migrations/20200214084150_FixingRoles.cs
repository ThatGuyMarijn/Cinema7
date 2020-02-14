using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema7.Data.Migrations
{
    public partial class FixingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d7bf5b7-d173-40ff-888c-f9050b710719", "a14f5a88-3f96-44f8-853b-5c44f4ae5057", "LevelOne", "LEVELONE" },
                    { "cf7a1e8d-ded0-4234-9d73-377e946ee196", "71cc7881-f476-497b-a9e1-2c6500cb93a6", "LevelTwo", "LEVELTWO" },
                    { "45d208b8-360c-4ce1-833d-63714bde541b", "77eb09fd-cdb3-4abf-a04b-f976432a0b41", "LevelThree", "LEVELTHREE" },
                    { "9112a882-a11a-4ec6-a2d9-8c809b654b70", "2d48ec72-a44b-4dd9-a2c0-57f68962b465", "LevelFour", "LEVELFOUR" },
                    { "2f28f05b-7de2-4c74-bf64-cd825c353cef", "1028fbde-23e2-4d84-935b-73cad467ccde", "LevelFive", "LEVELFIVE" }
                });
        }
    }
}
