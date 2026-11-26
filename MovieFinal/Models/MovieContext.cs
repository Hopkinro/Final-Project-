using Microsoft.EntityFrameworkCore;
using MovieFinal.Data;

namespace MovieFinal.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<ReleasingMovie> ReleasingMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "D", Name = "Drama" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "M", Name = "Musical" },
                new Genre { GenreId = "R", Name = "RomCom" },
                new Genre { GenreId = "S", Name = "SciFi" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Name = "Casablanca", Year = 1942, Rating = 5, GenreId = "D" },
                new Movie { MovieId = 2, Name = "Wonder Woman", Year = 2017, Rating = 3, GenreId = "A" },
                new Movie { MovieId = 3, Name = "Moonstruck", Year = 1988, Rating = 4, GenreId = "R" },
                new Movie { MovieId = 4, Name = "Maximum Overdrive", Year = 1986, Rating = 3, GenreId = "H" },
                new Movie { MovieId = 5, Name = "Boyz in the Hood", Year = 1991, Rating = 4, GenreId = "D" },
                new Movie { MovieId = 6, Name = "The Incredible Hulk", Year = 2008, Rating = 3, GenreId = "A" },
                new Movie { MovieId = 7, Name = "Scarface", Year = 1983, Rating = 4, GenreId = "D" },
                new Movie { MovieId = 8, Name = "Cars", Year = 2006, Rating = 4, GenreId = "R" },
                new Movie { MovieId = 9, Name = "Indiana Jones the Last Crusade", Year = 1989, Rating = 4, GenreId = "A" },
                new Movie { MovieId = 10, Name = "A Few Good Men", Year = 1992, Rating = 4, GenreId = "D" }
            );

            modelBuilder.Entity<ReleasingMovie>().HasData(
                new ReleasingMovie { ReleasingMovieId = 1, Name = "Lord of the Rings: The Hunt for Gollum", ReleaseYear = 2027, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 2, Name = "Children of Blood and Bone", ReleaseYear = 2027, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 3, Name = "Godzilla x Kong: Supernova", ReleaseYear = 2027, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 4, Name = "The Legend of Zelda", ReleaseYear = 2027, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 5, Name = "Sonic the Hedgehog 4", ReleaseYear = 2027, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 6, Name = "Fast Forever", ReleaseYear = 2028, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 7, Name = "Mad Max: The Wasteland", ReleaseYear = 2028, GenreId = "S" },
                new ReleasingMovie { ReleasingMovieId = 8, Name = "Gremlins 3", ReleaseYear = 2028, GenreId = "H" },
                new ReleasingMovie { ReleasingMovieId = 9, Name = "Star Wars: Rogue Squadron", ReleaseYear = 2028, GenreId = "S" },
                new ReleasingMovie { ReleasingMovieId = 10, Name = "Den of Thieves 3", ReleaseYear = 2028, GenreId = "A" },
                new ReleasingMovie { ReleasingMovieId = 11, Name = "King Spawn", ReleaseYear = 2028, GenreId = "A" }
            );
        }
    }
}