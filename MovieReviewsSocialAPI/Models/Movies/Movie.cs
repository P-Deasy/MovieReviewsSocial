namespace MovieReviewsSocialAPI.Models.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Description { get; set; }
    }
}
