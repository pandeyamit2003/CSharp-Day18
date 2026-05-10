using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    [Route("Dashboard")]
    public class DashboardController : Controller
    {
        // URL:
        // /Dashboard/admin
        // /Dashboard/user

        [HttpGet("{role}")]
        public IActionResult Index(string role)
        {
            if (role.ToLower() == "admin")
            {
                return RedirectToAction("AdminDashboard");
            }

            return RedirectToAction("UserDashboard");
        }

        [HttpGet("AdminDashboard")]
        public IActionResult AdminDashboard()
        {
            return View();
        }

        [HttpGet("UserDashboard")]
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}