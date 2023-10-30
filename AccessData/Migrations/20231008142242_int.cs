using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccessData.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    GraduationYear = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Ireland" },
                    { 3, "Germany" },
                    { 4, "China" },
                    { 5, "USA" },
                    { 6, "Japan" },
                    { 7, "India" },
                    { 8, "Mexico" },
                    { 9, "Spain" },
                    { 10, "Poland" },
                    { 11, "Sweden" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Documentary" },
                    { 4, "Drama" },
                    { 5, "Fantasy" },
                    { 6, "Horror" },
                    { 7, "Musical" },
                    { 8, "Mystery" },
                    { 9, "Romance" },
                    { 10, "Science Fiction" },
                    { 11, "Thriller" },
                    { 12, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CountryId", "Description", "Duration", "GenreId", "GraduationYear", "Img", "Title", "Video", "Views" },
                values: new object[,]
                {
                    { 1, 2, "test1", 15, 2, 2023, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test1", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 1 },
                    { 2, 7, "test2", 15, 6, 1999, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test2", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 123123 },
                    { 3, 1, "test3", 15, 1, 2077, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test3", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 4127 },
                    { 4, 5, "test4", 15, 3, 2013, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test4", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 19 },
                    { 5, 2, "test5", 15, 2, 2023, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test5", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 1 },
                    { 6, 7, "test6", 15, 6, 1999, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test6", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 123123 },
                    { 7, 1, "test7", 15, 1, 2077, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test7", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 4127 },
                    { 8, 5, "test8", 15, 3, 2013, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test8", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 19 },
                    { 9, 2, "test9", 15, 2, 2023, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test9", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 1 },
                    { 10, 7, "test10", 15, 6, 1999, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test10", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 123123 },
                    { 11, 1, "test11", 15, 1, 2077, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test11", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 4127 },
                    { 12, 5, "test12", 15, 3, 2013, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test12", "https://player.vimeo.com/external/413023251.sd.mp4?s=166ac94a452958dd2bb4c77531b5e284c9c66dd4&profile_id=164&oauth2_token_id=57447761.mp4", 19 },
                    { 13, 8, "test13", 3, 8, 2122, "https://cpmr-islands.org/wp-content/uploads/sites/4/2019/07/test.png", "Test13", "video-1658576887.mp4", 123 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_CountryId",
                table: "Films",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_GenreId",
                table: "Films",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
