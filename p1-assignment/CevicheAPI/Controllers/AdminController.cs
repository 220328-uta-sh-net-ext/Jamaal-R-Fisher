using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CevicheModels;

namespace CevicheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private static List<Admin> _admins = new List<Admin>
        {
            new Admin { AdminId=0, AdminName="", AdminPassword="", TotalUsers=0, TotalRestaurants=0 },
            new Admin { AdminId=0, AdminName="", AdminPassword="", TotalUsers=0, TotalRestaurants=0 },
            new Admin { AdminId=0, AdminName="", AdminPassword="", TotalUsers=0, TotalRestaurants=0 }
        };

        // Action Methods ways to access or manipulate the resources, HTTP verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD)
        // Attribute explicitly defines the function.  can be seen in Postman.
        [HttpGet]
        public ActionResult<List<Admin>> Get()
        {
            // return "Hello Admin!";
            return Ok(_admins);
        }

        [HttpGet("name")]

        // [ProducesResponseType(StatusCodes.Status200OK)]
        // [ProducesResponseType(StatusCodes.Status404NotFound)]

        [ProducesResponseType(200, Type = typeof(Admin))]
        [ProducesResponseType(404)]

        public ActionResult<Admin> Get(string name)
        {
            var boss = _admins.Find(x => x.AdminName.Contains(name));
            if (boss == null)
                return NotFound($" Admin {name} you are looking for is not in the database");
            return Ok(boss);
        }
    }
}
