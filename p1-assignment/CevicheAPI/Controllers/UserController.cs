using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CevicheAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Action Methods ways to access or manipulate the resources, HTTP verbs/methods (GET, PUT, POST, DELETE, PATCH, HEAD)
        // Attribute explicitly defines the function.  can be seen in Postman.
        [HttpGet]
        public string Get()
        {
            return "Hello User!";
        }
    }
}
