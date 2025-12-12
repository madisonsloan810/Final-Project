using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseYear = table.Column<int>(type: "INTEGER", nullable: false),
                    PosterUrl = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewText = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "https://via.placeholder.com/240x360?text=EGGY+1", 2016, "A washed-up chef uncovers an underground egg-rating ring.", "EGGY: The First Crack" },
                    { 2, "https://via.placeholder.com/240x360?text=Yolk+Runner", 2017, "A courier smuggles illegal breakfasts across a neon city.", "Yolk Runner" },
                    { 3, "https://via.placeholder.com/240x360?text=Shellshock", 2018, "A drummer hears messages hidden in cracked shells.", "Shellshock" },
                    { 25, "https://via.placeholder.com/240x360?text=Cracked+Horizons", 1999, "A sci-fi expedition finds a planet where memory is edible.", "Cracked Horizons" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingID", "MovieID", "ReviewText", "Score" },
                values: new object[,]
                {
                    { 1, 1, "Peak EGGY cinema.", 5 },
                    { 2, 1, "Better than expected.", 4 },
                    { 3, 2, "Cool vibe, thin story.", 3 },
                    { 4, 3, "Didn’t land for me.", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MovieID",
                table: "Ratings",
                column: "MovieID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
