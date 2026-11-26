namespace MovieFinal.Data
{
    public class ReleasingMovie
    {
        public int ReleasingMovieId { get; set; }
        public string? Name { get; set; }
        public int? ReleaseYear { get; set; }
        public string? GenreId { get; set; }
        public Genre? Genre { get; set; }

        public string Slug =>
        (Name ?? "").Replace(' ', '-').ToLower() + "-" + (ReleaseYear?.ToString() ?? "");

    }
}
