namespace MovieReviewsSocialAPI.Models.Reviews
{
    public class ReviewResponse
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public decimal Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }
    }
}
