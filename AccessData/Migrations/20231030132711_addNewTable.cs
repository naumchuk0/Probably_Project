using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccessData.Migrations
{
    /// <inheritdoc />
    public partial class addNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FilmId",
                table: "Comments",
                column: "FilmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CountryId", "Description", "Duration", "GenreId", "GraduationYear", "Img", "Title", "Video", "Views" },
                values: new object[,]
                {
                    { 1, 2, "test1", 15, 2, 2023, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test1", "video (2160p).mp4", 1 },
                    { 2, 7, "test2", 15, 6, 1999, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test2", "video (2160p).mp4", 123123 },
                    { 3, 1, "test3", 15, 1, 2077, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test3", "video (2160p).mp4", 4127 },
                    { 4, 5, "test4", 15, 3, 2013, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test4", "video (2160p).mp4", 19 },
                    { 5, 2, "test5", 15, 2, 2023, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test5", "video (2160p).mp4", 1 },
                    { 6, 7, "test6", 15, 6, 1999, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test6", "video-1658576887.mp4", 123123 },
                    { 7, 1, "test7", 15, 1, 2077, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test7", "video-1658576887.mp4", 4127 },
                    { 8, 5, "test8", 15, 3, 2013, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test8", "video-1658576887.mp4", 19 },
                    { 9, 2, "test9", 15, 2, 2023, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test9", "video (2160p).mp4", 1 },
                    { 10, 7, "test10", 15, 6, 1999, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test10", "video (2160p).mp4", 123123 },
                    { 11, 1, "test11", 15, 1, 2077, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test11", "video (2160p).mp4", 4127 },
                    { 12, 5, "test12", 15, 3, 2013, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test12", "video (2160p).mp4", 19 },
                    { 13, 8, "test13", 3, 8, 2122, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test13", "video-1658576887.mp4", 123 }
                });
        }
    }
}
