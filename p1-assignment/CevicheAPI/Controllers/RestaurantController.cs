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
        public string Get()
        {
            return "Hello Restaurant!";
            // return _restaurants;       
        }
    }
}
