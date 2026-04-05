using MovieReviewsSocialAPI.Models.Reviews;

namespace MovieReviewsSocialAPI.Services.Reviews.Interfaces
{
    public interface IReviewService
    {
        public List<ReviewResponse> GetReviews(string? movieTitle);
    }
}
