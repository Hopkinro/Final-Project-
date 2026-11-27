using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieFinal.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReleasingMoviesTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleasingMovie_Genres_GenreId",
                table: "ReleasingMovie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReleasingMovie",
                table: "ReleasingMovie");

            migrationBuilder.RenameTable(
                name: "ReleasingMovie",
                newName: "ReleasingMovies");

            migrationBuilder.RenameIndex(
                name: "IX_ReleasingMovie_GenreId",
                table: "ReleasingMovies",
                newName: "IX_ReleasingMovies_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReleasingMovies",
                table: "ReleasingMovies",
                column: "ReleasingMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasingMovies_Genres_GenreId",
                table: "ReleasingMovies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReleasingMovies_Genres_GenreId",
                table: "ReleasingMovies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReleasingMovies",
                table: "ReleasingMovies");

            migrationBuilder.RenameTable(
                name: "ReleasingMovies",
                newName: "ReleasingMovie");

            migrationBuilder.RenameIndex(
                name: "IX_ReleasingMovies_GenreId",
                table: "ReleasingMovie",
                newName: "IX_ReleasingMovie_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReleasingMovie",
                table: "ReleasingMovie",
                column: "ReleasingMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReleasingMovie_Genres_GenreId",
                table: "ReleasingMovie",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId");
        }
    }
}
