using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
namespace Final_Project.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Rating> Ratings => Set<Rating>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Ratings)
            .WithOne(r => r.Movie!)
            .HasForeignKey(r => r.MovieID)
            .OnDelete(DeleteBehavior.Cascade);
        SeedData(modelBuilder);
    }
    private static void SeedData(ModelBuilder modelBuilder)
    {
       modelBuilder.Entity<Movie>().HasData(
    new Movie { MovieID = 1, Title = "Inception", ReleaseYear = 2010, PosterUrl = "/img/movies/inception.jpg",
        Summary = "A skilled thief enters dreams to steal secrets, but his toughest job is planting an idea instead." },

    new Movie { MovieID = 2, Title = "Interstellar", ReleaseYear = 2014, PosterUrl = "/img/movies/interstellar.jpg",
        Summary = "Explorers travel through a wormhole in space to save humanity from a dying Earth." },

    new Movie { MovieID = 3, Title = "The Matrix", ReleaseYear = 1999, PosterUrl = "/img/movies/matrix.jpg",
        Summary = "A hacker learns that reality is a simulation and joins a rebellion against its controllers." },

    new Movie { MovieID = 4, Title = "Blade Runner 2049", ReleaseYear = 2017, PosterUrl = "/img/movies/bladerunner2049.jpg",
        Summary = "A young blade runner uncovers a secret that could plunge society into chaos." },

    new Movie { MovieID = 5, Title = "The Dark Knight", ReleaseYear = 2008, PosterUrl = "/img/movies/darkknight.jpg",
        Summary = "Batman faces the Joker, a criminal mastermind bent on breaking Gotham’s spirit." },

    new Movie { MovieID = 6, Title = "Arrival", ReleaseYear = 2016, PosterUrl = "/img/movies/arrival.jpg",
        Summary = "A linguist races to communicate with alien visitors before global conflict erupts." },

    new Movie { MovieID = 7, Title = "Dune", ReleaseYear = 2021, PosterUrl = "/img/movies/dune.jpg",
        Summary = "A noble family becomes embroiled in a war for control over the galaxy’s most valuable resource." },

    new Movie { MovieID = 8, Title = "Everything Everywhere All at Once", ReleaseYear = 2022, PosterUrl = "/img/movies/eeaao.jpg",
        Summary = "An overwhelmed woman explores parallel universes to save existence itself." },

    new Movie { MovieID = 9, Title = "The Prestige", ReleaseYear = 2006, PosterUrl = "/img/movies/prestige.jpg",
        Summary = "Two rival magicians obsessively compete to create the ultimate illusion." },

    new Movie { MovieID = 10, Title = "Ex Machina", ReleaseYear = 2014, PosterUrl = "/img/movies/exmachina.jpg",
        Summary = "A programmer evaluates an AI with unsettlingly human traits." },

    new Movie { MovieID = 11, Title = "Parasite", ReleaseYear = 2019, PosterUrl = "/img/movies/parasite.jpg",
        Summary = "A poor family schemes to infiltrate a wealthy household with unexpected consequences." },

    new Movie { MovieID = 12, Title = "Mad Max: Fury Road", ReleaseYear = 2015, PosterUrl = "/img/movies/madmax.jpg",
        Summary = "Survivors flee across the wasteland in a relentless chase for freedom." },

    new Movie { MovieID = 13, Title = "Whiplash", ReleaseYear = 2014, PosterUrl = "/img/movies/whiplash.jpg",
        Summary = "A young drummer pushes himself to the brink under a ruthless instructor." },

    new Movie { MovieID = 14, Title = "Her", ReleaseYear = 2013, PosterUrl = "/img/movies/her.jpg",
        Summary = "A lonely writer forms an emotional bond with an advanced operating system." },

    new Movie { MovieID = 15, Title = "The Grand Budapest Hotel", ReleaseYear = 2014, PosterUrl = "/img/movies/grandbudapest.jpg",
        Summary = "A hotel concierge becomes entangled in theft, war, and loyalty." },

    new Movie { MovieID = 16, Title = "No Country for Old Men", ReleaseYear = 2007, PosterUrl = "/img/movies/nocountry.jpg",
        Summary = "A hunter stumbles upon a drug deal gone wrong and unleashes a relentless killer." },

    new Movie { MovieID = 17, Title = "Fight Club", ReleaseYear = 1999, PosterUrl = "/img/movies/fightclub.jpg",
        Summary = "An insomniac forms an underground fight club that spirals out of control." },

    new Movie { MovieID = 18, Title = "The Social Network", ReleaseYear = 2010, PosterUrl = "/img/movies/socialnetwork.jpg",
        Summary = "The founding of a social media empire leads to betrayal and lawsuits." },

    new Movie { MovieID = 19, Title = "Shutter Island", ReleaseYear = 2010, PosterUrl = "/img/movies/shutterisland.jpg",
        Summary = "A U.S. Marshal investigates a disappearance at a mysterious asylum." },

    new Movie { MovieID = 20, Title = "The Truman Show", ReleaseYear = 1998, PosterUrl = "/img/movies/truman.jpg",
        Summary = "A man slowly realizes his entire life is a television show." },

    new Movie { MovieID = 21, Title = "Joker", ReleaseYear = 2019, PosterUrl = "/img/movies/joker.jpg",
        Summary = "A failed comedian descends into madness and chaos." },

    new Movie { MovieID = 22, Title = "Get Out", ReleaseYear = 2017, PosterUrl = "/img/movies/getout.jpg",
        Summary = "A weekend visit uncovers disturbing secrets beneath polite smiles." },

    new Movie { MovieID = 23, Title = "The Lighthouse", ReleaseYear = 2019, PosterUrl = "/img/movies/lighthouse.jpg",
        Summary = "Two lighthouse keepers descend into madness on a remote island." },

    new Movie { MovieID = 24, Title = "La La Land", ReleaseYear = 2016, PosterUrl = "/img/movies/lalaland.jpg",
        Summary = "An aspiring actress and a jazz musician chase dreams in Los Angeles." },

    new Movie { MovieID = 25, Title = "The Shawshank Redemption", ReleaseYear = 1994, PosterUrl = "/img/movies/shawshank.jpg",
        Summary = "A wrongfully imprisoned man forms a life-changing friendship behind bars." }
); //pasted from chatgbt since I used it to generate the data for the movies


        modelBuilder.Entity<Rating>().HasData(
    new Rating { RatingID = 1, MovieID = 1, Score = 5, ReviewText = "Mind-bending and brilliant." },
    new Rating { RatingID = 2, MovieID = 1, Score = 4, ReviewText = "Complex but rewarding." },

    new Rating { RatingID = 3, MovieID = 2, Score = 5, ReviewText = "Visually stunning and emotional." },
    new Rating { RatingID = 4, MovieID = 2, Score = 5, ReviewText = "An unforgettable journey." },

    new Rating { RatingID = 5, MovieID = 3, Score = 5, ReviewText = "Revolutionary sci-fi." },
    new Rating { RatingID = 6, MovieID = 3, Score = 4, ReviewText = "Still holds up today." },

    new Rating { RatingID = 7, MovieID = 5, Score = 5, ReviewText = "Best superhero movie ever." },
    new Rating { RatingID = 8, MovieID = 5, Score = 4, ReviewText = "Heath Ledger was incredible." },

    new Rating { RatingID = 9, MovieID = 8, Score = 5, ReviewText = "Absolutely wild and emotional." },
    new Rating { RatingID = 10, MovieID = 8, Score = 4, ReviewText = "Strange but beautiful." },

    new Rating { RatingID = 11, MovieID = 11, Score = 5, ReviewText = "Sharp, funny, and unsettling." },
    new Rating { RatingID = 12, MovieID = 11, Score = 5, ReviewText = "Deserved every award." },

    new Rating { RatingID = 13, MovieID = 17, Score = 4, ReviewText = "Stylish and provocative." },
    new Rating { RatingID = 14, MovieID = 17, Score = 3, ReviewText = "A bit overrated but interesting." },

    new Rating { RatingID = 15, MovieID = 25, Score = 5, ReviewText = "Timeless and inspiring." }
); //also pasted from chatgbt since I used it to generate the ratings data

    }
}
