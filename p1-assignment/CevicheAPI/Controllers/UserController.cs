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
        public ActionResult<List<User>> Get()
        {
            // return "Hello User!";
            return Ok(_users);
        }

        [HttpGet("name")]

        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]

        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(404)]

        public ActionResult<User> Get(string name)
        {
            var tester = _users.Find(x => x.Username.Contains(name));
            if (tester == null)
                return NotFound($" User {name} you are looking for is not in the database");
            return Ok(tester);
        }
    }
}
