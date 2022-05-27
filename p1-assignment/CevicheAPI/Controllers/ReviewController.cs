using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CevicheModels;

namespace CevicheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private static List<Review> _reviews = new List<Review>
        {
            new Review { Id=0, UserId=0, Name="", Rating=0, UserReview="" },
            new Review { Id=0, UserId=0, Name="", Rating=0, UserReview="" },
            new Review { Id=0, UserId=0, Name="", Rating=0, UserReview="" }
        };
        // Action Methods ways to access or manipulate the resources, HTTP verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD)
        // Attribute explicitly defines the function.  can be seen in Postman.
        [HttpGet]
        public string Get()
        {
            return "Hello Review!";
            // return _reviews;
        }
    }
}
