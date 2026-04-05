namespace MovieReviewsSocialAPI.Models.Genre
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }

    }
}
