using MovieReviewsSocialAPI.Models.Reviews;
using MovieReviewsSocialAPI.Services.Reviews.Interfaces;

namespace MovieReviewsSocialAPI.Services.Reviews
{
    public class ReviewService: IReviewService
    {
        public ReviewService() { }

        public List<ReviewResponse> GetReviews(string? movieTitle)
        {
            return new List<ReviewResponse>();
        }
    }
}
