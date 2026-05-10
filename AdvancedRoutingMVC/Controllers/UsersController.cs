using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    public class UsersController : Controller
    {
        // Route: /Users/nitesh/Orders
        [Route("Users/{username}/Orders")]
        public IActionResult Orders(string username)
        {
            ViewBag.Username = username;

            return View();
        }
    }
}