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
        public ActionResult<List<Review>> Get()
        {
            // return "Hello Review!";
            return Ok(_reviews);
        }

        [HttpGet("name")]

        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]

        [ProducesResponseType(200, Type = typeof(Review))]
        [ProducesResponseType(404)]

        public ActionResult<Review> Get(string name)
        {
            var view = _reviews.Find(x => x.UserReview.Contains(name));
            if (view == null)
                return NotFound($" Review {name} you are looking for is not in the database");
            return Ok(view);
        }
    }
}
