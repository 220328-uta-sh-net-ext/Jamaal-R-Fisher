using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CevicheModels;

namespace CevicheAPI.Controllers
{
    //  Routes are used to configure the endpoints of the API
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private static List<Restaurant> _restaurants = new List<Restaurant>
        {
            new Restaurant { Id=0, Name="", Rating=0, TotalRatings=0, UserReview="", Zipcode="", },
            new Restaurant { Id=0, Name="", Rating=0, TotalRatings=0, UserReview="", Zipcode="", },
            new Restaurant { Id=0, Name="", Rating=0, TotalRatings=0, UserReview="", Zipcode="", }
        };

        // Action Methods ways to access or manipulate the resources, HTTP verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD)
        // Attribute explicitly defines the function.  can be seen in Postman.
        [HttpGet]
        public ActionResult<List<Restaurant>> Get()
        {
            // return "Hello Restaurant!";
            return Ok(_restaurants);       
        }

        [HttpGet("name")]
        [ProducesResponseType(200, Type = typeof(Restaurant))]
        [ProducesResponseType(404)]

        public ActionResult<Restaurant> Get(string name)
        {
            var rest = _restaurants.Find(x => x.Name.Contains(name));
            if (rest == null)
                return NotFound($" Restaurant {name} you are looking for is not in the database");
            return Ok(rest);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult Post([FromBody] Restaurant rest) 
        {
            if (rest == null)
                return BadRequest("Invalid restaurant.  Please try again with valid values.");
            _restaurants.Add(rest);
            return CreatedAtAction("Get", rest);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult Put([FromBody] Restaurant rest, [FromRoute] string name)
        {
            if (name == null)
                return BadRequest("Cannot modify restaurant without name");
            var restaurant = _restaurants.Find(x => x.Name.Contains(name));
            if (restaurant == null)
                return NotFound("Restaurant not found.");
            restaurant.Id = rest.Id;
            restaurant.Name = rest.Name;
            restaurant.Rating = rest.Rating;
            restaurant.TotalRatings = rest.TotalRatings;
            restaurant.UserReview = rest.UserReview;
            restaurant.Zipcode = rest.Zipcode;
            return Created("Get", rest);
        }

        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)
                return BadRequest("Cannot modify restaurant without name");
            var restaurant = _restaurants.Find(x => x.Name.Contains(name));
            if (restaurant == null)
                return NotFound("Restaurant not found.");
            _restaurants.Remove(restaurant);
            return Ok($"Restaurant {name} deleted.");
        }
    }
}
