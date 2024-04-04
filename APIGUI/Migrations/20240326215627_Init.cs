using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIGUI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CosmicImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Copyright = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Explanation = table.Column<string>(type: "TEXT", nullable: true),
                    Hdurl = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CosmicImages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CosmicImages",
                columns: new[] { "Id", "Copyright", "Date", "Explanation", "Hdurl", "Title", "Url" },
                values: new object[,]
                {
                    { 1, null, "2019-04-12", "I ain't got time", "https://apod.nasa.gov/apod/image/1904/JMD_Rosette_Rotated.jpg", "A Cosmic Rose: The Rosette Nebula in Monoceros", null },
                    { 2, null, "2019-08-13", "I ain't got time2", "https://apod.nasa.gov/apod/image/1908/CannonSupernova_English_8404.jpg", "Supernova Cannon Expels Pulsar J0002", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CosmicImages");
        }
    }
}
