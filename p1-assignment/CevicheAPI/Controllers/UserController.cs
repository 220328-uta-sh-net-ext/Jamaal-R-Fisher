using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CevicheModels;

namespace CevicheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static List<User> _users = new List<User>
        {
            new User { UserId=0, Username="", Password="", Zipcode="", UserReview="" },
            new User { UserId=0, Username="", Password="", Zipcode="", UserReview="" },
            new User { UserId=0, Username="", Password="", Zipcode="", UserReview="" }
        };

        // Action Methods ways to access or manipulate the resources, HTTP verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD)
        // Attribute explicitly defines the function.  can be seen in Postman.
        [HttpGet]
        public string Get()
        {
            return "Hello User!";
            // return _users;       
        }
    }
}
