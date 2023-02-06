using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04Sklep.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "ImgUrl", "Title" },
                values: new object[,]
                {
                    { 22, "orange", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "https://loremflickr.com/320/240?lock=2101005094", "Sleek Cotton Ball" },
                    { 23, "grey", "The Football Is Good For Training And Recreational Purposes", "https://loremflickr.com/320/240?lock=1239332566", "Incredible Rubber Keyboard" },
                    { 24, "yellow", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "https://loremflickr.com/320/240?lock=1381805223", "Ergonomic Fresh Fish" },
                    { 25, "silver", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "https://loremflickr.com/320/240?lock=2130438457", "Refined Rubber Pizza" },
                    { 26, "plum", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=630231208", "Handcrafted Frozen Fish" },
                    { 27, "blue", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=1252756713", "Handmade Wooden Car" },
                    { 28, "white", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "https://loremflickr.com/320/240?lock=1082487822", "Intelligent Steel Keyboard" },
                    { 29, "red", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "https://loremflickr.com/320/240?lock=182736563", "Gorgeous Cotton Hat" },
                    { 30, "fuchsia", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "https://loremflickr.com/320/240?lock=1508701604", "Handcrafted Concrete Pants" },
                    { 31, "plum", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "https://loremflickr.com/320/240?lock=851157842", "Unbranded Plastic Sausages" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
