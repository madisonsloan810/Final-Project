using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoviesAndRatings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "/img/movies/inception.jpg", 2010, "A skilled thief enters dreams to steal secrets, but his toughest job is planting an idea instead.", "Inception" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "/img/movies/interstellar.jpg", 2014, "Explorers travel through a wormhole in space to save humanity from a dying Earth.", "Interstellar" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "/img/movies/matrix.jpg", 1999, "A hacker learns that reality is a simulation and joins a rebellion against its controllers.", "The Matrix" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 25,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "/img/movies/shawshank.jpg", 1994, "A wrongfully imprisoned man forms a life-changing friendship behind bars.", "The Shawshank Redemption" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[,]
                {
                    { 4, "/img/movies/bladerunner2049.jpg", 2017, "A young blade runner uncovers a secret that could plunge society into chaos.", "Blade Runner 2049" },
                    { 5, "/img/movies/darkknight.jpg", 2008, "Batman faces the Joker, a criminal mastermind bent on breaking Gotham’s spirit.", "The Dark Knight" },
                    { 6, "/img/movies/arrival.jpg", 2016, "A linguist races to communicate with alien visitors before global conflict erupts.", "Arrival" },
                    { 7, "/img/movies/dune.jpg", 2021, "A noble family becomes embroiled in a war for control over the galaxy’s most valuable resource.", "Dune" },
                    { 8, "/img/movies/eeaao.jpg", 2022, "An overwhelmed woman explores parallel universes to save existence itself.", "Everything Everywhere All at Once" },
                    { 9, "/img/movies/prestige.jpg", 2006, "Two rival magicians obsessively compete to create the ultimate illusion.", "The Prestige" },
                    { 10, "/img/movies/exmachina.jpg", 2014, "A programmer evaluates an AI with unsettlingly human traits.", "Ex Machina" },
                    { 11, "/img/movies/parasite.jpg", 2019, "A poor family schemes to infiltrate a wealthy household with unexpected consequences.", "Parasite" },
                    { 12, "/img/movies/madmax.jpg", 2015, "Survivors flee across the wasteland in a relentless chase for freedom.", "Mad Max: Fury Road" },
                    { 13, "/img/movies/whiplash.jpg", 2014, "A young drummer pushes himself to the brink under a ruthless instructor.", "Whiplash" },
                    { 14, "/img/movies/her.jpg", 2013, "A lonely writer forms an emotional bond with an advanced operating system.", "Her" },
                    { 15, "/img/movies/grandbudapest.jpg", 2014, "A hotel concierge becomes entangled in theft, war, and loyalty.", "The Grand Budapest Hotel" },
                    { 16, "/img/movies/nocountry.jpg", 2007, "A hunter stumbles upon a drug deal gone wrong and unleashes a relentless killer.", "No Country for Old Men" },
                    { 17, "/img/movies/fightclub.jpg", 1999, "An insomniac forms an underground fight club that spirals out of control.", "Fight Club" },
                    { 18, "/img/movies/socialnetwork.jpg", 2010, "The founding of a social media empire leads to betrayal and lawsuits.", "The Social Network" },
                    { 19, "/img/movies/shutterisland.jpg", 2010, "A U.S. Marshal investigates a disappearance at a mysterious asylum.", "Shutter Island" },
                    { 20, "/img/movies/truman.jpg", 1998, "A man slowly realizes his entire life is a television show.", "The Truman Show" },
                    { 21, "/img/movies/joker.jpg", 2019, "A failed comedian descends into madness and chaos.", "Joker" },
                    { 22, "/img/movies/getout.jpg", 2017, "A weekend visit uncovers disturbing secrets beneath polite smiles.", "Get Out" },
                    { 23, "/img/movies/lighthouse.jpg", 2019, "Two lighthouse keepers descend into madness on a remote island.", "The Lighthouse" },
                    { 24, "/img/movies/lalaland.jpg", 2016, "An aspiring actress and a jazz musician chase dreams in Los Angeles.", "La La Land" }
                });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "ReviewText",
                value: "Mind-bending and brilliant.");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "ReviewText",
                value: "Complex but rewarding.");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                columns: new[] { "ReviewText", "Score" },
                values: new object[] { "Visually stunning and emotional.", 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                columns: new[] { "MovieID", "ReviewText", "Score" },
                values: new object[] { 2, "An unforgettable journey.", 5 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingID", "MovieID", "ReviewText", "Score" },
                values: new object[,]
                {
                    { 5, 3, "Revolutionary sci-fi.", 5 },
                    { 6, 3, "Still holds up today.", 4 },
                    { 15, 25, "Timeless and inspiring.", 5 },
                    { 7, 5, "Best superhero movie ever.", 5 },
                    { 8, 5, "Heath Ledger was incredible.", 4 },
                    { 9, 8, "Absolutely wild and emotional.", 5 },
                    { 10, 8, "Strange but beautiful.", 4 },
                    { 11, 11, "Sharp, funny, and unsettling.", 5 },
                    { 12, 11, "Deserved every award.", 5 },
                    { 13, 17, "Stylish and provocative.", 4 },
                    { 14, 17, "A bit overrated but interesting.", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 1,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "https://via.placeholder.com/240x360?text=EGGY+1", 2016, "A washed-up chef uncovers an underground egg-rating ring.", "EGGY: The First Crack" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 2,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "https://via.placeholder.com/240x360?text=Yolk+Runner", 2017, "A courier smuggles illegal breakfasts across a neon city.", "Yolk Runner" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 3,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "https://via.placeholder.com/240x360?text=Shellshock", 2018, "A drummer hears messages hidden in cracked shells.", "Shellshock" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieID",
                keyValue: 25,
                columns: new[] { "PosterUrl", "ReleaseYear", "Summary", "Title" },
                values: new object[] { "https://via.placeholder.com/240x360?text=Cracked+Horizons", 1999, "A sci-fi expedition finds a planet where memory is edible.", "Cracked Horizons" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1,
                column: "ReviewText",
                value: "Peak EGGY cinema.");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2,
                column: "ReviewText",
                value: "Better than expected.");

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3,
                columns: new[] { "ReviewText", "Score" },
                values: new object[] { "Cool vibe, thin story.", 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4,
                columns: new[] { "MovieID", "ReviewText", "Score" },
                values: new object[] { 3, "Didn’t land for me.", 2 });
        }
    }
}
