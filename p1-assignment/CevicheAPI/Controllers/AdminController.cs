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
        public string Get()
        {
            return "Hello Admin!";
            // return _admins;       
        }
    }
}
