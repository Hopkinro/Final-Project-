using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieFinal.Migrations
{
    /// <inheritdoc />
    public partial class CreatedReleasingMoviesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReleasingMovie",
                columns: table => new
                {
                    ReleasingMovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: true),
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReleasingMovie", x => x.ReleasingMovieId);
                    table.ForeignKey(
                        name: "FK_ReleasingMovie_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId");
                });

            migrationBuilder.InsertData(
                table: "ReleasingMovie",
                columns: new[] { "ReleasingMovieId", "GenreId", "Name", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, "A", "Lord of the Rings: The Hunt for Gollum", 2027 },
                    { 2, "A", "Children of Blood and Bone", 2027 },
                    { 3, "A", "Sonic the Hedgehog 4", 2027 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReleasingMovie_GenreId",
                table: "ReleasingMovie",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReleasingMovie");
        }
    }
}
