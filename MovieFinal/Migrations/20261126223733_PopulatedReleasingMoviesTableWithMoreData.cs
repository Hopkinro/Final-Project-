using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieFinal.Migrations
{
    /// <inheritdoc />
    public partial class PopulatedReleasingMoviesTableWithMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 3,
                column: "Name",
                value: "Godzilla x Kong: Supernova");

            migrationBuilder.InsertData(
                table: "ReleasingMovies",
                columns: new[] { "ReleasingMovieId", "GenreId", "Name", "ReleaseYear" },
                values: new object[,]
                {
                    { 4, "A", "The Legend of Zelda", 2027 },
                    { 5, "A", "Sonic the Hedgehog 4", 2027 },
                    { 6, "A", "Fast Forever", 2028 },
                    { 7, "S", "Mad Max: The Wasteland", 2028 },
                    { 8, "H", "Gremlins 3", 2028 },
                    { 9, "S", "Star Wars: Rogue Squadron", 2028 },
                    { 10, "A", "Den of Thieves 3", 2028 },
                    { 11, "A", "King Spawn", 2028 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "ReleasingMovies",
                keyColumn: "ReleasingMovieId",
                keyValue: 3,
                column: "Name",
                value: "Sonic the Hedgehog 4");
        }
    }
}
