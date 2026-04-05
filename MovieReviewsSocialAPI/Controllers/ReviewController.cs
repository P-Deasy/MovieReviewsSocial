using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieReviewsSocialAPI.Models.Reviews;
using MovieReviewsSocialAPI.Services.Reviews.Interfaces;

namespace MovieReviewsSocialAPI.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController: ControllerBase
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public List<ReviewResponse> Get(string? movieTitle)
        {
            return _reviewService.GetReviews(movieTitle);
        }
    }
}
